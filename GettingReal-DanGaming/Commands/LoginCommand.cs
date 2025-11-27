using System.Windows.Input;
using GettingReal_DanGaming.ViewModels;

namespace GettingReal_DanGaming.Commands
{
    public class LoginCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            bool result = true;
            if (parameter is LoginViewModel loginVm)
            {
                if (
                    string.IsNullOrWhiteSpace(loginVm.EmployeeId) ||
                    string.IsNullOrWhiteSpace(loginVm.EmployeePincode)
                )
                {
                    result = false;
                }
            }

            CommandManager.InvalidateRequerySuggested();
            return result;
        }

        public void Execute(object? parameter)
        {
            if (parameter is LoginViewModel loginVm)
            {
                loginVm.Login();
            }
        }
    }
}
