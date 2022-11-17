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

namespace WPF_Shovkun_PR2_Tasks
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Версия программного продукта: 1.0");
        }

        private void R1_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Red;
        }

        private void G2_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Green;
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Blue;
        }
    }
}
