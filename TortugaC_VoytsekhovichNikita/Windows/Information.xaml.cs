using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        public Information(EF.Product productinfo)
        {
            InitializeComponent();
            tbDiscountBool.Visibility = Visibility.Hidden;
            PriceDiscountTB.Visibility = Visibility.Hidden;
            if (productinfo.Discount > 0)
            {
                tbDiscountBool.Visibility = Visibility.Visible;
                PriceDiscountTB.Visibility = Visibility.Visible;
            }
            TitleTB.Text = productinfo.Title;
            List<Product> products = Class1.Context.Product.Where(i => i.ID == productinfo.ID).ToList();
            IngridientsLV.ItemsSource = products;
            DescriptionLV.ItemsSource = products;
            //IngridientsTB.Text = productinfo.Ingridients;
            WeidghProductTB.Text = (productinfo.Weight * 1000 + " гр.").ToString();
            PriceTB.Text = productinfo.Price.ToString();
            PriceDiscountTB.Text = (productinfo.Price - (productinfo.Price * productinfo.Discount)).ToString();
            try
            {
                PhotoProduct.Source = new BitmapImage(new Uri(productinfo.Image));
            }
            catch (Exception)
            {
                
            }
            
            TitleTB.Text = productinfo.Title;
            string a = (productinfo.Discount * 100).ToString();
            DiscountProductTB.Text = a + " %";
        }
    }
}
