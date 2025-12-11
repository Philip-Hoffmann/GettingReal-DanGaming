using GettingReal_DanGaming.Models;
using GettingReal_DanGaming.ViewModels;

namespace DanGamingTests
{
    [TestClass]
    public class AddProductTest
    {
        MainViewModel mvm;
        ProductViewModel pvm;
        Product product;

        [TestInitialize]
        public void SetupBeforeTest()
        {
            //Arrange
            mvm = new MainViewModel(); 
            
            product = new Product()
            {
                Name = "ND75",
                Description = "Super cool keyboard with cool screen.",
                Brand = "ChillKey",
                Price = 1500.99,
                Quantity = 4,
                MinimumQuantity = 3,
                DateOfRecipt = DateTime.Now,
                CategoryId = 2,
                SubcategoryId = 1
            };

            pvm = new ProductViewModel(product);
        }
        [TestCleanup]
        public void CleanUpAfterTest()
        {
            string fileName = "products.csv";
            File.Create(fileName);
        }
        [TestMethod]
        public void CanAddProductToMainViewModelAndCVSFile()
        {
            //Act 
            mvm.AddProduct(pvm);

            //Assert 
            Assert.HasCount(1, mvm.ProductsVM);

            ProductViewModel addedPvm = mvm.ProductsVM.Single();

            Assert.AreEqual(pvm.Name, addedPvm.Name);
            Assert.AreEqual(pvm.Description, addedPvm.Description);
            Assert.AreEqual(pvm.Brand, addedPvm.Brand);
            Assert.AreEqual(pvm.Price, addedPvm.Price);
            Assert.AreEqual(pvm.Quantity, addedPvm.Quantity);
            Assert.AreEqual(pvm.CategoryId, addedPvm.CategoryId);
            Assert.AreEqual(pvm.SubcategoryId, addedPvm.SubcategoryId);
            
            string[] productLines = File.ReadAllLines("products.csv");
            string[] csvProduct = productLines.Single().Split(";");

            //Assert
            Assert.AreEqual("1", csvProduct[0]);
            Assert.AreEqual("ND75", csvProduct[1]);
            Assert.AreEqual("Super cool keyboard with cool screen.", csvProduct[2]);
            Assert.AreEqual("ChillKey", csvProduct[3]);
            Assert.AreEqual("1500,99", csvProduct[4]);
            Assert.AreEqual("4", csvProduct[5]);
            Assert.AreEqual("3", csvProduct[6]);
            Assert.IsNotEmpty(csvProduct[7]);
            Assert.AreEqual("2", csvProduct[8]);
            Assert.AreEqual("1", csvProduct[9]);
        }
    }
}

