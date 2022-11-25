using System.Text.RegularExpressions;
using System.Windows.Input;
using NosGame.MVVM;
using NosGame.Utils;
using Window = System.Windows.Window;

namespace NosGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReadPoints.LoadArray();
            DataContext = new ViewModel();
        }

        private void PreviewText(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
        
        private static readonly Regex Regex = new("[^0-9.-]+"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !Regex.IsMatch(text);
        }
    }
}