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

        private void NextTab_Click(object sender, RoutedEventArgs e)
        {
            Tab2.IsSelected = true;
        }

        

        private void Check_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox check = sender as CheckBox;
            Combo.Items.Add(check.Content);
        }

        private void Check_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox check = sender as CheckBox;
            Combo.Items.Remove(check.Content);
        }
    }
}
