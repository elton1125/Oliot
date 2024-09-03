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

namespace Harjoitus_26
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Kirjasto kirjasto = new Kirjasto();

        public MainWindow()
        {
            InitializeComponent();

            kirjasto.LisääKirja(new Kirja { Nimi = "Harry Potter", Kirjailija = "Test", Sivumäärä = 320 });
            kirjasto.LisääKirja(new Kirja { Nimi = "Aleksis kivi", Kirjailija = "Tester", Sivumäärä = 400 });

            DataContext = kirjasto;
        }

        private void LisääKirja_Click(object sender, RoutedEventArgs e)
        {
            Kirja uusiKirja = new Kirja { Sivumäärä = 0 };
            kirjasto.LisääKirja(uusiKirja);
        }

        private void PoistaKirja_Click(object sender, RoutedEventArgs e)
        {
            Kirja valittuKirja = lv_Kirjat.SelectedItem as Kirja;
            if (valittuKirja != null)
            {
                kirjasto.PoistaKirja(valittuKirja);
            }
        }

        private void LainaaKirja_Click(object sender, RoutedEventArgs e)
        {
            Kirja valittuKirja = lv_Kirjat.SelectedItem as Kirja;
            if (valittuKirja != null)
            {
                try
                {
                    kirjasto.LainaaKirja(valittuKirja);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PalautaKirja_Click(object sender, RoutedEventArgs e)
        {
            Kirja valittuKirja = lv_Kirjat.SelectedItem as Kirja;
            if (valittuKirja != null)
            {
                try
                {
                    kirjasto.PalautaKirja(valittuKirja);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
