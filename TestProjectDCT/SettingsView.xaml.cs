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

namespace TestProjectDCT
{
    /// <summary>
    /// Логика взаимодействия для SettingsView.xaml
    /// </summary>
    public partial class SettingsView : Page
    {
        public SettingsView()
        {
            InitializeComponent();
        }
        private void BlackMode_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.TestProjectDCT = "Black";
            Properties.Settings.Default.Save();
        }
        private void LightMode_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.TestProjectDCT = "Light";
            Properties.Settings.Default.Save();
        }
    }
}
