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

namespace AritmetikApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickBeräkna(object sender, RoutedEventArgs e)
    {
        // Läs av rutorna: txbTal1, txbTal2, txbOperator
        string tal1String = txbTal1.Text;
        string tal2String = txbTal2.Text;
        string op = txbOperator.Text;

        // KOnvertera till heltal
        int.TryParse(tal1String, out int tal1);
        int.TryParse(tal2String, out int tal2);

        if (op == "+")
        {
            int resultat = tal1 + tal2;
            lblResultat.Content = $"{resultat}";
        }
        else if (op == "-")
        {
            int resultat = tal1 - tal2;
            lblResultat.Content = $"{resultat}";
        }
        else if (op == "*")
        {
            int resultat = tal1 * tal2;
            lblResultat.Content = $"{resultat}";
        }
        else if (op == "/")
        {
            int resultat = tal1 / tal2;
            lblResultat.Content = $"{resultat}";
        }
        else
        {
            lblResultat.Content = "Ogiltig inmatning!";
        }
    }
}