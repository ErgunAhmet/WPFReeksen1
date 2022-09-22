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

namespace Reeks1Variabelen
{
    /// <summary>
    /// Interaction logic for Oefening5.xaml
    /// </summary>
    public partial class Oefening5 : Window
    {
        double dCelcius;
        public Oefening5()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            dCelcius = Convert.ToDouble(txtCelcius.Text);

            double dFarenheit = dCelcius * 1.8 + 32;
            double dKelvin = dCelcius + 273.15;

            txtOutput.Text = "Degrees Farenheit: " + Convert.ToString(dFarenheit) + "\r\n" +
                "Degrees Kelvin: " + Convert.ToString(dKelvin);
        }
    }
}
