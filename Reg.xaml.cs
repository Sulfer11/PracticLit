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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            Errorlog.Text = "";
            Erroremail.Text = "";
            Errorpass.Text = "";
            Errorpass1.Text = ""; 
            
            int Errors = 0;
           

            var login = Login.Text;
            var email = Email.Text;
            var pass = Password.Text;
            var pass1 = Password1.Text;
            var context = new AppDbContext();

            var user_exists = context.Users.FirstOrDefault(x => x.Login == login);
            if (user_exists is not null)
            {
                Succsefull.Text = ("Такой пользователь уже существует.");
                return;
            }
            do
            {
                if (login.Length == 0)
                {
                    Errorlog.Text = ("Логин не может быть пустым.");
                    
                    Errors++;
                }
                if (email.Length == 0)
                {
                    Erroremail.Text += ("Почта не может быть пустой.");
                    
                    Errors++;
                }
                if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@(mail\.ru|gmail\.com|yandex\.ru)$"))
                {
                    Erroremail.Text += (" Доступные адреса: @mail.ru, @gmail.com, @yandex.ru");
                    
                    Errors++;
                }
                if (pass.Length < 8)
                {
                    Errorpass.Text = ("Пароль не может быть меньше 8 символов.");
                    
                    Errors++;
                }

                if (pass != pass1)
                {
                    Errorpass1.Text = ("Пароли не совпадают.");
                    
                    Errors++;
                }
                break;
            }
            while (Errors != 0) ;

            if (Errors == 0)
            {
                var user = new User { Login = login, Email = email, Password = pass };
                context.Users.Add(user);
                context.SaveChanges();
                Succsefull.Text = ("Вы зарегестрировались!");

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow log = new MainWindow();
            log.Show();
        }
    }
}
