using GettingReal_DanGaming.Models;
using GettingReal_DanGaming.ViewModels;
using System.Windows.Input;

namespace GettingReal_DanGaming.Commands
{
    internal class AddProductCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is AddProductViewModel addProductVM)
            {
                Product product = new Product();
                ProductViewModel productVM = new ProductViewModel(product);

                addProductVM.ProductsVM.Add(productVM);
                addProductVM.SelectedProduct = productVM;
            }
        }
    }
}
