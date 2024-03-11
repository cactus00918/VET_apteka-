using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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
using Excel = Microsoft.Office.Interop.Excel;
using vet_apteka_Таня_проект;


namespace VET_apteka
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Window
    {
        
        public Catalog()
        {
            InitializeComponent();
            //показывает данные в ListView

            using (ApplicationContext context = new ApplicationContext())
            {
                var allType = context.products.ToList();
                allType.Insert(0, new products
                {
                    category = "Все типы"
                });
                Filter.Items.Clear();
                Filter.SelectedIndex = 0;
                Filter.ItemsSource = allType;
               
               

                btn_poisk();

              // var currentList = context.products.ToList();
              // VET_app.ItemsSource = currentList;
                
               
                
            }

        }

        //поиск и фильтрация, активируется по кнопке применить 
        private void btn_poisk()
        {
            using (ApplicationContext context = new ApplicationContext())
            {

                var currentList = context.products.ToList();
                //фильтрация
                if (Filter.SelectedIndex > 0)
                    currentList = currentList.Where(p => p.category.Contains(((products)Filter.SelectedItem).category)).ToList();
                
                   
                //поиск
                    currentList = currentList.Where(p => p.name_product.ToLower().Contains(txtpoisk.Text.ToLower())).ToList();
                    VET_app.ItemsSource = currentList.OrderBy(p => p.name_product).ToList();

                

            }
        }

        
        public void btn_export(object sender, RoutedEventArgs e)
        {
            /*
                var application = new Excel.Application();//создаем объект приложения эксель
                application.SheetsInNewWorkbook = 1;//задаем 1 рабочее пространство
                Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);//задаем значение рабочему полю

                int startRowIndex = 1;

                Excel.Worksheet worksheet = application.Worksheets.Item[1];//задаем 1 лист рабочему пространству

                worksheet.Cells[1][startRowIndex] = "Название продукта";//задаем текст 1 столбцу строке startRowIndex
                startRowIndex++;

                Excel.Range cells = worksheet.Range[worksheet.Cells[1][startRowIndex], worksheet.Cells[2][startRowIndex]];//задаем диапазон текста
                cells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;//стиль границы
                cells.Borders.Weight = Excel.XlBorderWeight.xlThin;//ширина границ

                cells.ColumnWidth = 30;//задали ширину ячейкам

                worksheet.Cells[1][startRowIndex] = "Количество";
                worksheet.Cells[2][startRowIndex] = "Цена";
                startRowIndex++;
                foreach (var item in VET_app)
                {
                    cells = worksheet.Range[worksheet.Cells[1][startRowIndex], worksheet.Cells[2][startRowIndex]];//задаем диапазон текста
                    cells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;//стиль границы
                    cells.Borders.Weight = Excel.XlBorderWeight.xlThin;//ширина границ

                    worksheet.Cells[1][startRowIndex] = item.kolichestvo.ToString();
                    worksheet.Cells[2][startRowIndex] = item.price.ToString();
                    startRowIndex++;
                }
                application.Visible = true;//делаем видимым приложение

            */
            

        }

                
            


        

        //кнопки
        private void btn_MIN(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_CLOSE(object sender, RoutedEventArgs e)
        {
            this.Close();
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

        //добавление новых данных
        private void btn_redact(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Redact redact = new Redact(null);
                redact.Show();
                this.Close();
            }
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            btn_poisk();
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_poisk();
        }
    }
}
