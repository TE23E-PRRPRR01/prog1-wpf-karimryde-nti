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

namespace KalkApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickPlus(object sender, RoutedEventArgs e)
    {
        // Läsa av textrutorna
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;

        // Omvandla till heltal (int)
        int.TryParse(tal1, out int tal1Int);
        int.TryParse(tal2, out int tal2Int);

        // Uträkningen
        int resultat = tal1Int + tal2Int;

        // Skriv ut resultatrutan
        txbResult.Text = $"{tal1} + {tal2} = {resultat}";
    }
    private void KlickMinus(object sender, RoutedEventArgs e)
    {
        // Läsa av textrutorna
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;

        // Omvandla till heltal (int)
        int.TryParse(tal1, out int tal1Int);
        int.TryParse(tal2, out int tal2Int);

        // Uträkningen
        int resultat = tal1Int - tal2Int;

        // Skriv ut resultatrutan
        txbResult.Text = $"{resultat}";
    }
    private void KlickGånger(object sender, RoutedEventArgs e)
    {
        // Läsa av textrutorna
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;

        // Omvandla till heltal (int)
        int.TryParse(tal1, out int tal1Int);
        int.TryParse(tal2, out int tal2Int);

        // Uträkningen
        int resultat = tal1Int * tal2Int;

        // Skriv ut resultatrutan
        txbResult.Text = $"{resultat}";
    }
    private void KlickDelat(object sender, RoutedEventArgs e)
    {
        // Läsa av textrutorna
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;

        // Omvandla till heltal (int)
        double.TryParse(tal1, out double tal1Double);
        double.TryParse(tal2, out double tal2Double);

        // Uträkningen
        double resultat = tal1Double / tal2Double;

        // Skriv ut resultatrutan
        txbResult.Text = $"{resultat}";
    }
}