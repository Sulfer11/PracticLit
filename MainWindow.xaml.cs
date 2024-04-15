using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_PR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        int schet1 = 0;
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var login = Login.Text;

            var password = Password.Password;

            var context = new AppDbContext();
            
            var user = context.Users.SingleOrDefault(x => (x.Login == login || x.Email == login)  && (x.Password == password || x.Password == Password_Tb.Text));

            LogRed.Visibility = Visibility.Hidden;
            PassRed.Visibility = Visibility.Hidden;

            var errorLog = context.Users.SingleOrDefault(x => x.Login == login);
            var errorPass = context.Users.SingleOrDefault(x => x.Password == password);
            if (errorLog is null)
            {
                LogRed.Visibility = Visibility.Visible;
            }
            if (errorPass is null)
            {
                PassRed.Visibility = Visibility.Visible;
            }

            if (user is null) 
            {
                Errorpass.Text = ("Неправильный Логин или Пароль!");
                schet1++;
                if (schet1 == 3)
                {
                    Login.IsEnabled = false;
                    Password.IsEnabled = false;
                    Password_Tb.IsEnabled = false;
                    MessageBox.Show("Вход заблокирован на 15 секунд!");
                    await Task.Delay(15000);
                    Login.IsEnabled = true;
                    Password.IsEnabled = true;
                    Password_Tb.IsEnabled = true;
                    schet1 = 0;
                }
                return;
            }
            

            Errorpass.Text = ("Вы успешно вошли в аккаунт!");
            this.Hide();
            Success success = new Success();
            success.Show();
            success.Hello.Text = "Здравствуйте," + login + "!";
            success.Imya1.Text = login;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Reg reg = new Reg();
            reg.Show();
        }
        bool check = true;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (check == true)
            {
                Password.Visibility = Visibility.Visible;
                Password.Password = Password_Tb.Text;
                Password_Tb.Visibility = Visibility.Collapsed;
                Button button = (Button)sender;
                button.Content = new Image { Source = new BitmapImage(new Uri("Image/5.png", UriKind.Relative)) };
                check = false;
            }
            else
            {
                Password.Visibility = Visibility.Collapsed;
                Password_Tb.Text = Password.Password;
                Password_Tb.Visibility = Visibility.Visible;
                Button button = (Button)sender;
                button.Content = new Image { Source = new BitmapImage(new Uri("Image/3.png", UriKind.Relative)) };
                check = true;
            }
        }
    }
}