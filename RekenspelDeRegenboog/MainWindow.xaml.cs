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

namespace RekenspelDeRegenboog
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
        

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            Min p = new Min();
            p.Show();
            this.Close();
        }

        private void btnKeer_Click(object sender, RoutedEventArgs e)
        {
            Keer p = new Keer();
            p.Show();
            this.Close();
        }

        private void btnDeel_Click(object sender, RoutedEventArgs e)
        {
            Delen p = new Delen();
            p.Show();
            this.Close();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            Plus p = new Plus();
            p.Show();
            this.Close();
        }

    }
}
