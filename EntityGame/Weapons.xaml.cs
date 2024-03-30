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
    /// Логика взаимодействия для Weapons.xaml
    /// </summary>
    public partial class Weapons : Page
    {
        WeaponTableAdapter weapons = new WeaponTableAdapter();
        public Weapons()
        {
            InitializeComponent();
            WeaponsGrid.ItemsSource = weapons.GetData();
        }


    }
}
