using System.Windows;
using GettingReal_DanGaming.ViewModels;

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
    }
}