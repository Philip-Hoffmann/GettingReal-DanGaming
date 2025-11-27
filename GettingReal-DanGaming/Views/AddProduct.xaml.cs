using System.Windows;
using System.Windows.Controls;
using GettingReal_DanGaming.ViewModels;

namespace GettingReal_DanGaming
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProductViewModel AddProductVM { get; set; } = new AddProductViewModel();
        public List<ProductViewModel> ProductsVM { get; set; } = new List<ProductViewModel>();

        public AddProduct()
        {
            InitializeComponent();
            DataContext = AddProductVM;
            AddProductVM.Close = CloseDialog;
        }

        private void CloseDialog(bool result)
        { 
            if (result)
            {
                ProductsVM = AddProductVM.ProductsVM.ToList();
            }

            DialogResult = result;
            Close();
        }

        private void category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddProductVM.UpdateCategoryName();
            AddProductVM.UpdateSubcategories();
        }

        private void subcategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddProductVM.UpdateSubcategoryName();
        }
    }
}
