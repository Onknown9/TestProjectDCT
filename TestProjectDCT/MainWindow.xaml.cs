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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frame.Navigate(new HomePage());
        }
        private void Button_List_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ListView());
        }
        private void Button_Home_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new HomePage());
        }
        private void Button_Details_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new CryptoDetails());
        }
        private void Button_Settings_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new SettingsView());
        }
    }
}
