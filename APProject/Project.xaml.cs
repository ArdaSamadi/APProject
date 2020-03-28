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

namespace APProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Check2.IsEnabled = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Check2.IsEnabled = false;
        }

        private void Check3_Unchecked(object sender, RoutedEventArgs e)
        {
            Check4.IsEnabled = false;
        }

        private void Check3_Checked(object sender, RoutedEventArgs e)
        {
            Check4.IsEnabled = true;
        }

        private void Check5_Checked(object sender, RoutedEventArgs e)
        {
            Check6.IsEnabled = true;
        }

        private void Check5_Unchecked(object sender, RoutedEventArgs e)
        {
            Check6.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tab2.IsSelected = true;
        }
    }
}
