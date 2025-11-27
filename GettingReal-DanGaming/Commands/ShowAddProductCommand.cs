using GettingReal_DanGaming.ViewModels;
using System;
using System.Windows.Input;

namespace GettingReal_DanGaming.Commands
{
    internal class ShowAddProductCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            bool result = true;
            if (parameter is MainViewModel mvm)
            {
                if (mvm.EmployeeVM == null)
                {
                    result = false;
                }
            }

            CommandManager.InvalidateRequerySuggested();
            return result;
        }

        public void Execute(object? parameter)
        {
            if (parameter is MainViewModel mvm)
            {
                AddProduct addProductDialog = new AddProduct();
                bool? result = addProductDialog.ShowDialog();

                if (result == true)
                {
                    foreach (ProductViewModel product in addProductDialog.ProductsVM)
                    {
                        mvm.AddProduct(product);
                    }
                }
            }
        }
    }
}
