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
            Login loginDialog = new Login();
            loginDialog.ShowDialog();
        }
    }
}
