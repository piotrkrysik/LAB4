using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Geometria;

namespace Lab4;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnOblicz_Click(object sender, RoutedEventArgs e)
    {
        DaneWejścioweOkno okno1 = new DaneWejścioweOkno();
        okno1.ShowDialog();

        double szerokość = okno1.Szerokość;
        double wysokość = okno1.Wysokość;

        double pole = szerokość * wysokość;
        double obwód = 2 * szerokość + 2 * wysokość;

        DaneWyjścioweOkno okno2 = new DaneWyjścioweOkno(obwód, pole);
        okno2.ShowDialog();
    }

    private void btnKula_Click(object sender, RoutedEventArgs e)
    {
        Kula kulka = new Kula(promień: 3, gęstość: 67, cenaZaKG: 1.56);
        lblKula.Content = kulka.ToString();
    }

    private void btnStożek_Click(object sender, RoutedEventArgs e)
    {
        Stożek stożuś = new Stożek(wysokość:6, promień: 3, gęstość: 67, cenaZaKG:1.56);
        lblStożek.Content = stożuś.ToString();
    }

    private void btnBrzydzizg_Click(object sender, RoutedEventArgs e)
    {
        List<IWyświetl> lista = new List<IWyświetl>();
        lista.Add(new Kula(promień: 6,gęstość: 76, cenaZaKG: 6.3));
        lista.Add(new Kula(promień: 3, gęstość: 56, cenaZaKG: 2.3));
        lista.Add(new Stożek(wysokość: 4,promień: 3, gęstość: 56, cenaZaKG: 2.3));
        lista.Add(new Student(imię: "Stefan", nazwisko: "Siwy"));
        lista.Add(new Student(imię: "Marian", nazwisko: "Rudy"));
        lista.Add(new Student(imię: "Darek", nazwisko: "Biały"));

        lista.Sort();

        lstBox.Dodaj(lista);
    }
}