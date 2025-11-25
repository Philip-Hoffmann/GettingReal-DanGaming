using GettingReal_DanGaming.ViewModels;
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

namespace GettingReal_DanGaming
{
    public partial class MainWindow : Window
    {
        public MainViewModel mvm { get; set; } = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = mvm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Opret en instans af dit nye vindue
            // Vi bruger det fulde navn fra din x:Class: GettingReal_DanGaming.AddProduct
            var addWindow = new GettingReal_DanGaming.AddProduct();

            // Vis vinduet
            addWindow.Show();

            // OBS: Hvis du vil lukke Login-vinduet samtidig, kan du tilføje:
            // this.Close();
        }
    }
}