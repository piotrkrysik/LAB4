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

namespace Lab4
{
    /// <summary>
    /// Logika interakcji dla klasy DaneWyjścioweOkno.xaml
    /// </summary>
    public partial class DaneWyjścioweOkno : Window
    {
        public DaneWyjścioweOkno(double obwód, double pole)
        {
            InitializeComponent();
            lblObwód.Content = obwód.ToString("F2");
            lblPole.Content = pole.ToString("F2");
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
