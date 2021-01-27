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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double n1 = 0;
        double n2 = 0;
        double temp = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clickAdd(object sender, RoutedEventArgs e)
        {
            n1 = Convert.ToInt32(first.Text);
            n2 = Convert.ToInt32(second.Text);
            temp = n1 + n2;
            final.Text = Convert.ToString(temp);
        }

        private void subClick(object sender, RoutedEventArgs e)
        {
            n1 = Convert.ToInt32(first.Text);
            n2 = Convert.ToInt32(second.Text);
            temp = n1 - n2;
            final.Text = Convert.ToString(temp);
        }

        private void mulClick(object sender, RoutedEventArgs e)
        {
            n1 = Convert.ToInt32(first.Text);
            n2 = Convert.ToInt32(second.Text);
            temp = n1 * n2;
            final.Text = Convert.ToString(temp);
        }

        private void divClick(object sender, RoutedEventArgs e)
        {
            n1 = Convert.ToInt32(first.Text);
            n2 = Convert.ToInt32(second.Text);
            temp = n1 / n2;
            final.Text = Convert.ToString(temp);
        }
    }
}
