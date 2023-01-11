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
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        public Cart()
        {
            InitializeComponent();
            Update();
        }
        public string totalPrice()
        {
            decimal totalCost = 0;
            foreach (EF.Product prod in ClassHepler.Information.ListOfOrder)
            {
                totalCost += prod.Price - (prod.Price * prod.Discount);
                WhiteSaturday.Content = "";
                
            }
            if ((DateTime.Now.Day == 29 || DateTime.Now.Day == 30 || DateTime.Now.Day == 31) && DateTime.Now.DayOfWeek.ToString() == "Saturday")
            {
                totalCost = totalCost - (totalCost * Convert.ToDecimal(0.11));
                WhiteSaturday.Content = "Акция Белая Суббота, cкидка на всё 11%";
            }

            return Convert.ToString(totalCost);
        }
        public void Update()
        {
            lvOrder.ItemsSource = null;
            tbfullPrice.Text = "Итоговая стоимость: " + totalPrice();
            tbTable.Text = "Столик №: " + ClassHepler.Information.IDTable.Title;
            lvOrder.ItemsSource = ClassHepler.Information.ListOfOrder.Distinct().OrderBy(i => i.ID);
        }
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            EF.Product btn = (sender as Button).DataContext as EF.Product;
            ClassHepler.Information.ListOfOrder.Add(btn);
            Update();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            lvOrder.SelectedItem = (sender as Button).DataContext;

            var prod = lvOrder.SelectedItem as EF.Product;
            ClassHepler.Information.ListOfOrder.Remove(prod);
            Update();
        }
        private void lvOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                if (lvOrder.SelectedItem is EF.Product)
                {
                    var prod = lvOrder.SelectedItem as EF.Product;
                    ClassHepler.Information.ListOfOrder.Remove(prod);
                    Update();
                }
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();

            mw.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Close();
            mm.Show();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            if (ClassHepler.Information.ListOfOrder.Count < 1)
            {
                MessageBox.Show($"Корзина пуста!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                EF.Order order = new EF.Order();
                order.Cost = Convert.ToDecimal(totalPrice());
                order.TableID = Convert.ToInt32(ClassHepler.Information.IDTable.ID);
                order.OderDate = DateTime.Now;
                order.EmployeeID = 1;
                order.StatusID = 2;
                ClassHepler.Class1.Context.Order.Add(order);
                ClassHepler.Class1.Context.SaveChanges();

                if (order.StatusID == 2)
                {
                    EF.ProductOrder orderProduct = new EF.ProductOrder();

                    foreach (EF.Product prod in ClassHepler.Information.ListOfOrder.Distinct())
                    {
                        orderProduct.OrderID = order.ID;
                        orderProduct.ProductID = prod.ID;
                        orderProduct.Count = prod.OrderProdCount;
                        orderProduct.StatusID = 2;
                        ClassHepler.Class1.Context.ProductOrder.Add(orderProduct);
                        
                    }
                    ClassHepler.Class1.Context.SaveChanges();
                    MessageBox.Show($"Заказ №{order.ID} успешно оформлен!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                    ClassHepler.Information.ListOfOrder.Clear();
                    Update();
                    MainWindow mw = new MainWindow();
                    this.Close();
                    mw.Show();
                }
                else
                {
                    MessageBox.Show("Отсутствует соединение с базой данных, невозможно создать заказ",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message).ToString();
            }
        }
    }
}
