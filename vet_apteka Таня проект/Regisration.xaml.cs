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
using Microsoft.EntityFrameworkCore;

namespace VET_apteka
{
    /// <summary>
    /// Логика взаимодействия для Regisration.xaml
    /// </summary>
    public partial class Regisration : Window
    {
        public Regisration()
        {
            InitializeComponent();
        }

        //кнопки
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

        //регистрация чтоб вносились данные в бд
        private void Button_registration(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                account Account = new account();
                Account.fio = txtName.Text;
                Account.n_phone = txtNumber.Text;
                Account.login = txtEmail.Text;
                Account.password = txtPassword.Password;

                db.Add(Account);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Информация сохранена");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        //переход на страницу авторизации с кнопки авторизация
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
