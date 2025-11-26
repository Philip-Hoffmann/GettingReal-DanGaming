using GettingReal_DanGaming.ViewModels;
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
