using project_tz.Models;
using project_tz.Metod;
using project_tz.Forms;
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

namespace project_tz.Forms
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public Product Product { get; set; }
        public UserWindow(Product product)
        {
            InitializeComponent();

            Product = product;
            DataContext = Product;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddMethod.AddProduct(Product.Id, Product.Name, Product.Price, Product.Description);
            MainWindow mainwindow = new MainWindow();
            Close();
            mainwindow.ShowDialog();
        }

        private void Cancel_Copy_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.ShowDialog();
        }
    }
}
