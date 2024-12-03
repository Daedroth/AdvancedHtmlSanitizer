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

namespace AhsTestWpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void SantizeBtn_OnClick(object sender, RoutedEventArgs e)
    {
        var input = SaniTextInput.Text;
        var sanitizer = new Ahs.HtmlSanitizer();
        var output = sanitizer.Sanitize(input);
        SaniTextOutput.Text = output;
    }
}