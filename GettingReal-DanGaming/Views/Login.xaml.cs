using GettingReal_DanGaming.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GettingReal_DanGaming.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public LoginViewModel LoginVM { get; set; } = new LoginViewModel();
        public EmployeeViewModel EmployeeVM { get; set; }

        public Login()
        {
            InitializeComponent();
            DataContext = LoginVM;
            LoginVM.Close = CloseDialog;
        }

        private void CloseDialog(bool result)
        {
            if (result)
            {
                EmployeeVM = LoginVM.EmployeeVM;
            }

            DialogResult = result;
            Close();
        }
    }
}
