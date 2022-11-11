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
using TortugaC_VoytsekhovichNikita.Windows;
using Table = TortugaC_VoytsekhovichNikita.EF.Table;

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
            lvTables.ItemsSource = Class1.Context.Table.ToList();
            
        }

        private void btnTableSelect_Click(object sender, RoutedEventArgs e)
        {
            
            lvTables.SelectedItem = (sender as Button).DataContext;
            var selectedtableid = lvTables.SelectedItem as Table;
            ClassHepler.Information.IDTable = selectedtableid;
            MessageBox.Show("Вы выбрали столик: " + selectedtableid.ID);
            MainMenu menu = new MainMenu();
            this.Close();
            menu.Show();
        }
    }
}
