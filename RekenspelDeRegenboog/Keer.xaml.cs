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
    /// Interaction logic for Keer.xaml
    /// </summary>
    public partial class Keer : Window
    {
        public Keer()
        {
            InitializeComponent();
            generateSom();
        }

        // Variabelen die hoeveelheid goede en foute sommen bijhouden.

        int iUitkomst;
        int iGoed = 0;
        int iFout = 0;

        Random random = new Random();

        public void generateSom() // Maakt de keersom
        {
            int iGetal1 = random.Next(1, 10); // Tafels van 1 tot 10 voor getal 1 en getal 2
            int iGetal2 = random.Next(1, 10);
            iUitkomst = iGetal1 * iGetal2; // Inhoud variabele iUitkomst
            lbKeer.Content = iGetal1 + " X " + iGetal2 + " = ";
        }

        private void txtKeer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtKeer.Text == iUitkomst.ToString()) // Als antwoord goed is 1 bij iGoed variabele toevoegen en window laten zien met Antwoord is goed.
                {
                    MessageBox.Show("Super, je antwoord is goed!");
                    iGoed++;
                    lbGoed.Content = iGoed;
                }
                else
                {
                    MessageBox.Show("Antwoord is fout!"); // Bij fout antwoord boodschap antwoord is fout en 1 bij foute variable toevoegen.
                    iFout++;
                    lbFout.Content = iFout;
                }
                if (iGoed < 5)
                {
                    generateSom();
                }
                else
                {
                    MessageBox.Show("Je bent klaar!\nGoede antwoorden: " + iGoed + "\nFoute antwoorden: " + iFout); // Als er vijf sommen goed zijn de uitslag laten zien met aantal goed en foute antwoorden.
                    MainWindow p = new MainWindow();
                    p.Show();
                    this.Close();
                }
                txtKeer.Text = "";
            }
        }

        private void btnKeerTerug_Click(object sender, RoutedEventArgs e) // terug naar menu knop
        {
            MainWindow p = new MainWindow();
            p.Show();
            this.Close();
        }
    }
}
