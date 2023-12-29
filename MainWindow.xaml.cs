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
using Octopath2RandomizerTracker.Models;
using System.Diagnostics;

namespace Octopath2RandomizerTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static bool Ctrl_Held { get; set; } = false;

        public MainWindow()
        {
            InitializeComponent();
            this.Icon = new BitmapImage(new Uri("pack://application:,,,/Octopath2RandomizerTracker;component/Images/Icon.png"));
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) { 
            var window = Window.GetWindow(this);
            window.KeyDown += HandleKeyPressed;
            window.KeyUp += HandleKeyPressed;
        }

        private void HandleKeyPressed(object sender, KeyEventArgs e) {
            if ((e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl) && e.IsDown) {
                Debug.WriteLine("Ctrl_Held swapped to true");
                Ctrl_Held = true;
            } else {
                Debug.WriteLine("Ctrl_Held swapped to false");
                Ctrl_Held = false;
            }
        }
    }
 
}