using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_PR
{
    /// <summary>
    /// Логика взаимодействия для Kabinet.xaml
    /// </summary>
    public partial class Kabinet : Window
    {
        public Kabinet()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow log = new MainWindow();
            log.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Errorlogin.Text = "";
            Erroremail.Text = "";
            Errorpass.Text = "";
            LogRed.Visibility = Visibility.Hidden;
            EmailRed.Visibility = Visibility.Hidden;
            PassRed.Visibility = Visibility.Hidden;

            int Errors = 0;

            var login = Login.Text;

            var email = Email.Text;

            var pass = Password.Text;

            var context = new AppDbContext();

            do
            {
                if (login.Length == 0)
                {
                    Errorlogin.Text = ("Логин не может быть пустым.");
                    LogRed.Visibility = Visibility.Visible;
                    Errors++;
                }
                if (email.Length == 0)
                {
                    Erroremail.Text = ("Почта не может быть пустой.");
                    EmailRed.Visibility = Visibility.Visible;
                    Errors++;
                }
                if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@(mail\.ru|gmail\.com|yandex\.ru)$"))
                {
                    Erroremail.Text = ("Доступные адреса: @mail.ru, @gmail.com, @yandex.ru.");
                    EmailRed.Visibility = Visibility.Visible;
                    Errors++;
                }
                if (pass.Length < 5)
                {
                    Errorpass.Text = ("Пароль не может быть меньше 5 символов.");
                    PassRed.Visibility = Visibility.Visible;
                    Errors++;                  
                }
                break;
            }
            while (Errors != 0);

            if (Errors == 0)
            {
                var user = new User { Login = login, Email = email, Password = pass };
                var users = context.Users.SingleOrDefault(x => x.Login == Imya.Text);
                if (users is not null)
                {
                    context.Users.Remove(users);
                    context.SaveChanges();                   
                }
                context.Users.Add(user);
                context.SaveChanges();
                Imya.Text = login;
                Vivod.Text = "Успешно изменено!";
            }

        }
    }
}
