using System.Windows;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace EpostApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        // Läs av epost & meddelanden
        string epost = tbxEpost.Text;
        string meddelande = tbxMeddelande.Text;

        // Koppla upp på en mail-server
        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        smtp.Credentials = new NetworkCredential("karye.webb", "xxx");

        // Sanity check
        if (epost != "" && meddelande != "")
        {
            smtp.Send("karim@gmail.com", epost, "Epost från appen", meddelande);
            lblStatus.Content = "OK";
        }
        else
        {
            lblStatus.Content = "Fel! Något av fälten är tomma.";

        }
    }

    private void ChangedEpost(object sender, RoutedEventArgs e)
    {
        // Läs av epost & meddelanden
        string epost = tbxEpost.Text;

        // Kontrollera epostformatet med regex
        string regexEpost = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        if (!Regex.IsMatch(epost, regexEpost))
        {
            // Visa felmeddelande
            lblStatus.Content = "Du måste ange en giltig epostadress!";
        }
        else
        {
            
        }
    }
}