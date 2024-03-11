using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace vet_apteka_Таня_проект
{
    /// <summary>
    /// Логика взаимодействия для Redact.xaml
    /// </summary>
    public partial class Redact : Window
    {
        private products products = new products();
        public Redact(products selectedProduct)
        {
            InitializeComponent();
            if (selectedProduct != null)
            {
                products = selectedProduct;

            }
            DataContext = products;
            products item = DataContext as products;
            if (item != null)
            {
                txtName_product.Text = item.name_product;
                txtCategory.Text = item.category;
                txtKolichestvo.Text = item.kolichestvo;
                txtPrice.Text = item.price;
            }
        }

        
       //редктирование данных       

        private void Edit_ListView(object sender,  RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                products product = DataContext as products;
                if (product != null)
                {
                    product.name_product = txtName_product.Text;
                    product.category = txtCategory.Text;
                    product.kolichestvo = txtKolichestvo.Text;
                    product.price = txtPrice.Text;



                    db.products.Update(product);
                    db.SaveChanges();
                    MessageBox.Show("Информация сохранена");
                    Catalog catalog = new Catalog();
                    catalog.Show();
                    this.Hide();
                }
                else
                {
                    product.name_product = txtName_product.Text;
                    product.category = txtCategory.Text;
                    product.kolichestvo = txtKolichestvo.Text;
                    product.price = txtPrice.Text;

                    db.Add(product);
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Информация сохранена");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
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

        

        private void btn_Exit(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(); 
            main.Show();
            this.Close();
        }
    }
}
