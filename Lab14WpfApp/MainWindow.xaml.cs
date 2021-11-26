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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab14WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List <Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Холодильник",
                Price = 100,
                Image = "Data/1.jpg",
                Category = Category.Appliances
            });
            products.Add(new Product()
            {
                Name = "Молоко",
                Price = 80,
                Image = "Data/2.jpg",
                Category = Category.Food
            });
            products.Add(new Product()
            {
                Name = "Телевизор",
                Price = 1000,
                Image = "Data/3.png",
                Category = Category.Appliances
            });

            ProductList.ItemsSource = products;
        }
    }
}
