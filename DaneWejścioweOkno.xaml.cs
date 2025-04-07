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
    /// Logika interakcji dla klasy DaneWejścioweOkno.xaml
    /// </summary>
    public partial class DaneWejścioweOkno : Window
    {
        public double Szerokość { get; private set; }
        public double Wysokość { get; private set; } 

        public DaneWejścioweOkno()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Szerokość = double.Parse(txtSzerokość.Text);
            Wysokość = double.Parse(txtWysokość.Text);
            this.Close();
        }
    }
}
