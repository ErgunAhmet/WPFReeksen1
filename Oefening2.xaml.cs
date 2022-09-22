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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        double dWidth;
        double dLength;
        public Window1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            dWidth = Convert.ToDouble(txtWidth.Text);
            dLength = Convert.ToDouble(txtLength.Text);

            double dCircumference = Math.Round((dWidth * 2 + dLength * 2),3);
            double dSurface = Math.Round( (dWidth * dLength),3);

            txtOutput.Text = "Circumference of the rectangle: " + Convert.ToString(dCircumference)
                + "\r\n" + "The surface of the rectangle: " + Convert.ToString(dSurface);
        }
    }
}
