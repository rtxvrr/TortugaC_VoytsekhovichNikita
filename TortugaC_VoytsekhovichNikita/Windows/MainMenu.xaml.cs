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
using TortugaC_VoytsekhovichNikita.ClassHepler;
using TortugaC_VoytsekhovichNikita.EF;

namespace TortugaC_VoytsekhovichNikita.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        //List<Product> ProductsAll = new List<Product>();
        List<Category> categories = new List<Category>();
        public MainMenu()
        {
            InitializeComponent();
            categories = Class1.Context.Category.ToList();
            categories.Insert(0, new Category() { Title = "Все блюда" });
            lvCategory.ItemsSource = categories;
            lvCategory.SelectedIndex = 0;
            Filter();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cart cart = new Cart();
            this.Close();
            cart.Show();
        }

        public void Filter()
        {
            List<Product> products = Class1.Context.Product.ToList();
            int idCategory = (lvCategory.SelectedItem as Category).ID;
            if (idCategory != 0)
            {
                products = products.Where(i => i.CategoryID == idCategory).ToList();
            }
            else
            {
                products = Class1.Context.Product.ToList();
            }
            
            lvMenu.ItemsSource = products;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();

            mw.Show();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            lvMenu.SelectedItem = (sender as Button).DataContext;
            var prod = lvMenu.SelectedItem as Product;
            ClassHepler.Information.ListOfOrder.Add(prod);
        }

        private void lvCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lvMenu.SelectedItem = (sender as Button).DataContext;
            var prod = lvMenu.SelectedItem as Product;
            Information im = new Information(prod);
            im.ShowDialog();

        }
    }
}
