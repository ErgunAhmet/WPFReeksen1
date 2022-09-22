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
    /// Interaction logic for oefening4.xaml
    /// </summary>
    public partial class oefening4 : Window
    {
        double dNumber;
        public oefening4()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            dNumber = Convert.ToDouble(txtNumber.Text);

            double dSquare = dNumber * dNumber;
            txtOutput.Text = "Square of "+ txtNumber.Text + " is " + Convert.ToString(dSquare);
        }
    }
}
