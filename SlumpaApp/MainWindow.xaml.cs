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

namespace SlumpaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSlumpa(object sender, RoutedEventArgs e)
    {
        // Läsa av maxvärde
        //int max = int.Parse(txbMax.Text) + 1;

        // Läsa av utan risk för krasch!
        if (!int.TryParse(txbMax.Text, out int max))
        {
            max = 100;
        }

        // Slumpa ett tal 1-100
        int slumptal = Random.Shared.Next(1, max + 1);

        // Skriv ut slumptalet i textboxen
        txbResultat.Text = $"{slumptal}";
    }
}