using System.Windows.Input;
using GettingReal_DanGaming.ViewModels;

namespace GettingReal_DanGaming.Commands
{
    public class CancelLoginCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is LoginViewModel loginVM)
            {
                loginVM.Close(false);
            }
        }
    }
}
