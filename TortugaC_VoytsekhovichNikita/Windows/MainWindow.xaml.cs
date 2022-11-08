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
using TortugaC_VoytsekhovichNikita.Windows;

namespace TortugaC_VoytsekhovichNikita
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNumber1_Click(object sender, RoutedEventArgs e)
        {
            int TableNumber = 1;
            MainMenu menu = new MainMenu(TableNumber);
            this.Close();

            menu.Show();
        }

        private void btnNumber2_Click(object sender, RoutedEventArgs e)
        {
            int TableNumber = 2;
            MainMenu menu = new MainMenu(TableNumber);
            this.Close();

            menu.Show();
        }

        private void btnNumber3_Click(object sender, RoutedEventArgs e)
        {
            int TableNumber = 3;
            MainMenu menu = new MainMenu(TableNumber);
            this.Close();

            menu.Show();
        }

        private void btnNumber4_Click(object sender, RoutedEventArgs e)
        {
            int TableNumber = 4;
            MainMenu menu = new MainMenu(TableNumber);
            this.Close();

            menu.Show();
        }

        private void btnNumber5_Click(object sender, RoutedEventArgs e)
        {
            int TableNumber = 5;
            MainMenu menu = new MainMenu(TableNumber);
            this.Close();

            menu.Show();
        }

        private void btnNumber6_Click(object sender, RoutedEventArgs e)
        {
            int TableNumber = 6;
            MainMenu menu = new MainMenu(TableNumber);
            this.Close();

            menu.Show();
        }

        private void btnNumber7_Click(object sender, RoutedEventArgs e)
        {
            int TableNumber = 7;
            MainMenu menu = new MainMenu(TableNumber);
            this.Close();

            menu.Show();
        }

        private void btnNumber8_Click(object sender, RoutedEventArgs e)
        {
            int TableNumber = 8;
            MainMenu menu = new MainMenu(TableNumber);
            this.Close();

            menu.Show();
        }
    }
}
