using GettingReal_DanGaming.ViewModels;
using System.Windows.Input;

namespace GettingReal_DanGaming.Commands
{
    internal class RemoveProductCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            bool result = true;
            if (parameter is AddProductViewModel addProductVM)
            {
                if (addProductVM.SelectedProduct == null)
                {
                    result = false;
                }
            }

            CommandManager.InvalidateRequerySuggested();
            return result;
        }

        public void Execute(object? parameter)
        {
            if (parameter is AddProductViewModel addProductVM)
            {
                if (addProductVM.SelectedProduct == null)
                {
                    return;
                }

                addProductVM.ProductsVM.Remove(addProductVM.SelectedProduct);
                addProductVM.SelectedProduct = null;
            }
        }
    }
}
