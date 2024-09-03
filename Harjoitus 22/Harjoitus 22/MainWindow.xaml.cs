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

namespace Harjoitus_22
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                double width = double.Parse(textBoxWidth.Text);
                double height = double.Parse(textBoxHeight.Text);
                double frameWidth = double.Parse(textBoxFrameWidth.Text);

                
                double framePerimeter = 2 * (width + height) + 4 * frameWidth;

                
                double glassArea = (width - 2 * frameWidth) * (height - 2 * frameWidth);

                
                double windowArea = width * height;

                
                textBlockFramePerimeter.Text = $"Karmin piiri: {framePerimeter:F2} cm";
                textBlockGlassArea.Text = $"Lasin pinta-ala: {glassArea:F2} cm^2";
                textBlockWindowArea.Text = $"Ikkunan pinta-ala: {windowArea:F2} cm^2";
            }
            catch (FormatException)
            {
                MessageBox.Show("Virheellinen syöte. Syötä numerot oikeassa muodossa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe laskiessa: {ex.Message}");
            }
        }
    }
}
