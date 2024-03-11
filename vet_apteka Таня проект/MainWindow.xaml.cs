using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;
using vet_apteka_Таня_проект;

namespace VET_apteka
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //авторизация подключение к бд
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var currentUser = db.account.FirstOrDefault(p => p.login == txtEmail.Text & p.password == txtPassword.Password);

                if (currentUser != null)
                {

                    if (currentUser.type_user == "Admin" || currentUser.type_user == "admin" || currentUser.type_user == "Administrator" || currentUser.type_user == "administrator"
                        || currentUser.type_user == "Админ" || currentUser.type_user == "Администратор" || currentUser.type_user == "админ" || currentUser.type_user == "администратор")
                    {
                        Data_Grid dGrid = new Data_Grid();
                        dGrid.Show();
                        this.Close();
                    }
                    else
                    {
                        Capcha capcha = new Capcha();
                        capcha.Show();
                        this.Close();
                    }
                }

            }
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
        //переход на страницу регистрации, по кнопке регистрация
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Regisration regisration = new Regisration();
            regisration.Show();
            this.Close();
        }
    }
}
