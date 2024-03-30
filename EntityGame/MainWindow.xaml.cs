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
using EntityGame.GameDataSetTableAdapters;

namespace EntityGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WeaponTypeTableAdapter weapontype = new WeaponTypeTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            WeaponTypeDataGrid.ItemsSource = weapontype.GetData();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pageframe1.Content = new Players();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pageframe2.Content = new Weapons();
        }
    }
}
