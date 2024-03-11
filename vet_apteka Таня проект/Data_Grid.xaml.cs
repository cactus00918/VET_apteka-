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
using VET_apteka;

namespace vet_apteka_Таня_проект
{
    /// <summary>
    /// Логика взаимодействия для Data_Grid.xaml
    /// </summary>
    public partial class Data_Grid : Window
    {
        //показывает данные в DataGrid
        public Data_Grid()
        {
            InitializeComponent();
            using (ApplicationContext context = new ApplicationContext())
            {
                DGrid.ItemsSource = context.products.ToList();
            }
        }

        //редактирование уже готовой части
        private void Edit_ListView(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                Redact redact = new Redact((sender as Button).DataContext as products);
                redact.Show();
                this.Close();
            }

        }

        //добавление нового продукта
        private void Edit(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                Redact redact = new Redact(null);
                redact.Show();
                this.Close();
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



        private void btn_Exit(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

       

        private void DGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
