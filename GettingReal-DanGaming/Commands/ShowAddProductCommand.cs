using System;
using System.Windows.Input;

namespace GettingReal_DanGaming.Commands
{
    internal class ShowAddProductCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            AddProduct addProductDialog = new AddProduct();
            addProductDialog.ShowDialog();
        }
    }
}
