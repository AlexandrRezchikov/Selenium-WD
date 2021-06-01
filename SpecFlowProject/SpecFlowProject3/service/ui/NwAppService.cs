using OpenQA.Selenium;
using System.Threading;
using TestProject2.business_page;
using TestProject2.pages;

namespace TestProject2.service.ui
{
    class NwAppService
    {
        public static AllProducts CreateProduct(User user,Product product, IWebDriver driver)
        {
            HomePage homePage = UserToLogin(user, driver);
            AllProducts allProducts = homePage.GoToAllProducts();
            Thread.Sleep(2000);
            ProductEditing productEditing = allProducts.CreateNewProduct();
            Thread.Sleep(2000);
            productEditing.AddNewProduct(product);
            return allProducts;
        }
        public static HomePage UserToLogin(User user, IWebDriver driver)
        {
            LoginPage loginPage = new LoginPage(driver);
            HomePage homePage = loginPage.LogIn(user);
            return homePage;
        }
    }
}
