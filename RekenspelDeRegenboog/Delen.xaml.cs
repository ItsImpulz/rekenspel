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

namespace RekenspelDeRegenboog
{
    /// <summary>
    /// Interaction logic for Delen.xaml
    /// </summary>
    public partial class Delen : Window
    {
        public Delen()
        {
            InitializeComponent();
            generateSom();
        }

        int iUitkomst;
        int iGoed = 0;
        int iFout = 0;

        Random random = new Random();

        public void generateSom()
        {
            int iGetal1 = random.Next(1, 10);
            int iGetal2 = random.Next(1, 10);
            iGetal1 = iGetal2 * iGetal1;
            iUitkomst = iGetal1 / iGetal2;
            lbDelen.Content = iGetal1 + " : " + iGetal2 + " = ";
        }

        private void txtDelen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtDelen.Text == iUitkomst.ToString())
                {
                    MessageBox.Show("Antwoord is goed!");
                    iGoed++;
                    lbGoed.Content = iGoed;
                }
                else
                {
                    MessageBox.Show("Antwoord is fout!");
                    iFout++;
                    lbFout.Content = iFout;
                }
                if (iGoed < 5)
                {
                    generateSom();
                }
                else
                {
                    MessageBox.Show("Je bent klaar!\nGoede antwoorden: " + iGoed + "\nFoute antwoorden: " + iFout);
                    MainWindow p = new MainWindow();
                    p.Show();
                    this.Close();
                }
                txtDelen.Text = "";
            }
        }

        private void btnDelenTerug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow p = new MainWindow();
            p.Show();
            this.Close();
        }

        
    }
}


       