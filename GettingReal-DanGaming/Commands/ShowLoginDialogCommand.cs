using GettingReal_DanGaming.ViewModels;
using GettingReal_DanGaming.Views;
using System.Windows.Input;

namespace GettingReal_DanGaming.Commands
{
    internal class ShowLoginDialogCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is MainViewModel mvm)
            {
                if (mvm.EmployeeVM == null)
                {
                    Login loginDialog = new Login();
                    bool? result = loginDialog.ShowDialog();

                    if (result == true)
                    {
                        mvm.EmployeeVM = loginDialog.EmployeeVM;
                    }
                } 
                else
                {
                    mvm.EmployeeVM = null;
                }
            }
        }
    }
}
