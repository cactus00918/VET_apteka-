using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace VET_apteka
{
    /// <summary>
    /// Логика взаимодействия для Capcha.xaml
    /// </summary>
    public partial class Capcha : Window
    {

        //капча
        public int n = 0;
        public DispatcherTimer timer = new DispatcherTimer();
        public Capcha()
        {
            InitializeComponent();
        }

        private string GenerateCaptcha()
        {
            const int digitCount = 6;
            const string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ123456789";

            StringBuilder captcha = new StringBuilder(digitCount);

            Random random = new Random();
            for (int i = 0; i < digitCount; i++)
            {
                captcha.Append(allowedChars[random.Next(allowedChars.Length)]);

            }

            return captcha.ToString();
        }

        // Поле ввода для ввода капчи пользователем
        private void VerifyCaptcha_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(verifyCaptcha.Text))
            {
                MessageBox.Show("Please enter captcha");
                return;
            }

            string userInput = verifyCaptcha.Text;

            if (!string.Equals(userInput, captchaLabel.Text))
            {
                MessageBox.Show("Incorrect captcha, please try again");
                verifyCaptcha.Clear();
                captchaLabel.Text = string.Empty;
                Generate_Click(sender, e);
                timer.Interval = TimeSpan.FromSeconds(1);
                n = 10;
                timerblock.Text = n.ToString();
                confirm.IsEnabled = false;
                timer.Tick += timerTick;
                timer.Start();


                return;
            }
            else
            {
                // Капча введена верно, выполнить действие
                MessageBox.Show("Captcha Verified");
                Catalog catalog = new Catalog();
                catalog.Show();
                this.Hide();
            }
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            // Генерация случайной капчи
            string captcha = GenerateCaptcha();

            // Отображение капчи пользователю
            captchaLabel.Text = captcha;
        }

        void timerTick(object sender, EventArgs e)
        {
            if (n > 0)
            {
                confirm.IsEnabled = false;
                n--;
                timerblock.Text = n.ToString();
            }
            else
            {
                confirm.IsEnabled = true;
                timerblock.Text = string.Empty;
                n = 10;
                timer.Stop();
            }
        }

        private void btn_MIN(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_CLOSE(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_MAX(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
        }

    }
}
