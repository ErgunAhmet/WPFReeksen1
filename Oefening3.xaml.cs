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
    /// Interaction logic for Oefening3.xaml
    /// </summary>
    public partial class Oefening3 : Window
    {
        double dAmountWithoutVat;
        double dVatPercent;
        public Oefening3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            dAmountWithoutVat = Convert.ToDouble(txtWithoutVat.Text);
            dVatPercent = Convert.ToDouble(txtVat.Text);

            double dVat = dAmountWithoutVat * (dVatPercent / 100);
            double dTotal = dAmountWithoutVat + dVat;

            txtOutput.Text = 
                lblWithoutVAT
                + txtWithoutVat.Text
                + "\r\n"
                + lblVAT
                + txtVat.Text
                + "\r\n"
                + "Vat: "
                + Convert.ToString(dVat)
                + "%"
                + "\r\n"
                + "Amount with Vat: "
                + Convert.ToString(value: dTotal);
        }
    }
}
