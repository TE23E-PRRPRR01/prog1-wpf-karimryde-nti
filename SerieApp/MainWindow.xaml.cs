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

namespace SerieApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    int summa = 0;
    int antalKlick = 0;
    private void KlickAddera(object sender, RoutedEventArgs e)
    {
        // Räkna upp antal klick
        antalKlick++;

        // Läs av talet
        string talet = txbTal.Text;

        // Konvertera till heltal
        int.TryParse(talet, out int tal);

        // Lägg till i summan
        summa = summa + tal;

        // Skriv ut summan
        txbResultat.Text = $"{summa}";
    }
}