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
using Harjoitus_19;

namespace Harjoitus_19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Käytetty chatgpt apuna
    public partial class MainWindow : Window
    {
        public static List<Page> Kerrokset = new List<Page>();
        Hissi hissi = new Hissi();

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 6; i++)
            {
                Kerrokset.Add(new Kerros(i + 1));
            }

            VaihdaKerrosta(1);
        }

        void VaihdaKerrosta(int kerros)
        {
            if (kerros >= 1 && kerros <= 6)
            {
                if (kerros > hissi.HissiKerros && hissi.HissiKerros == 3)
                {
                    Console.WriteLine("Virheellinen kerros! Et voi mennä ylöspäin kerrokseen 4.");
                }
                else
                {
                    Frame_Main.NavigationService.Navigate(Kerrokset[kerros - 1]);
                    hissi.HissiKerros = kerros;
                    tb_Kerros.Text = "Kerros " + hissi.HissiKerros;
                }
            }
            else
            {
                Console.WriteLine("Virheellinen kerros! Kerroksen tulee olla väliltä 1-6.");
            }
        }

        private void btn_Kerros_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int kerros = int.Parse(button.Tag.ToString());

            VaihdaKerrosta(kerros);
        }
    }
}