using GettingReal_DanGaming.Models;
using GettingReal_DanGaming.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GettingReal_DanGaming.Commands
{
    internal class AddAllProductsCommand : ICommand
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
                foreach (ProductViewModel product in addProductVM.ProductsVM)
                {
                    if (
                        string.IsNullOrWhiteSpace(product.Name) ||
                        string.IsNullOrWhiteSpace(product.Brand) ||
                        product.Price < 0 ||
                        product.CategoryId == 0 ||
                        product.Quantity < 0
                    )
                    {
                        result = false;
                        break;
                    }
                }
            }

            CommandManager.InvalidateRequerySuggested();
            return result;
        }

        public void Execute(object? parameter)
        {
            if (parameter is AddProductViewModel addProductVM)
            {
                addProductVM.Close.Invoke(true);
            }
        }
    }
}
