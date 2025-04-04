using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GissaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Slumpa fram ett tal 1-1000
    int slumptal = Random.Shared.Next(1, 1001);
    List<int> listaGissningar = [];
    int antalFörsök = 0;
    int maxAntalFörsök = 10;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickGissa(object sender, RoutedEventArgs e)
    {
        // Läs av ruta gissning
        string input = txbGissning.Text;

        // Konvertera till ett heltal
        bool lyckades = int.TryParse(input, out int gissning);

        // Lyckades konverteringen?
        if (lyckades)
        {
            // Lagra i listan
            listaGissningar.Add(gissning);
            antalFörsök++;

            // Har vi nått max antal
            if (antalFörsök >= maxAntalFörsök)
            {
                txbResultat.Text = "Tyvärr, du har max antal försök!";
            }
            else
            {
                // Jämföra gissning med slumptal
                if (gissning == slumptal)
                {
                    txbResultat.Text = $"Din gissning var rätt ({gissning})";
                }
                else if (gissning > slumptal)
                {
                    txbResultat.Text = $"Din gissning var för hög ({gissning})";
                }
                else
                {
                    txbResultat.Text = $"Din gissning var för låg ({gissning})";
                }
            }
        }
        else
        {
            txbResultat.Text = "Ogiltig inmatning. Vg försök igen!";
        }
    }

    private void KlickVisaFacit(object sender, RoutedEventArgs e)
    {
        txbResultat.Text = $"Rätt svar är {slumptal}";
        
    }

    private void KlickVisaGissningar(object sender, RoutedEventArgs e)
    {
        // Skriv ut alla gissningar som finns i lista 
        // I stora rutan txbGissningar
        foreach (var tal in listaGissningar)
        {
            txbGissningar.Text += $"{tal}\n";
        }
    }

    private void KlickSpelaIgen(object sender, RoutedEventArgs e)
    {
        // Slumpa ett nytt tal
        slumptal = Random.Shared.Next(1, 1001);

        // Töm listan
        listaGissningar = [];

        // Rensa gränssnittet
        txbGissning.Text = "";
        txbResultat.Text = "";
        txbGissningar.Text = "";
    }
}