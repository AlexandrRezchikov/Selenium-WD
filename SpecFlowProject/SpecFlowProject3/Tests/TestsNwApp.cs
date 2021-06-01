using NUnit.Framework;
using System.Threading;
using TestProject2.business_page;
using TestProject2.pages;
using TestProject2.service.ui;
using TestProject2.Tests;

namespace TestProject1
{
    public class Tests : BaseTests
    {
        private User user = new User("user", "user");
        private Product product = new Product("Fresh fruits", "Beverages", "Exotic Liquids", "100,000", "10 boxes", "40", "0", "10", "Discontinued");

        /*[Test]
        public void Test1()
        {
            HomePage homePage = NwAppService.UserToLogin(user, driver);
            Assert.AreEqual("Logout", homePage.logout.Text);
        }
        [Test]
        public void Test2()
        {
            AllProducts allProducts = NwAppService.CreateProduct(user, product, driver);
            Assert.AreEqual("Create new", allProducts.buttonCreateNew.Text);
        }

        [Test]
        public void Test3()
        {
            HomePage homePage = NwAppService.UserToLogin(user, driver);
            Thread.Sleep(2000);
            AllProducts allProducts = homePage.GoToAllProducts();
            Thread.Sleep(2000);
            InfoProduct infoProduct = allProducts.ProductCheck();
            Thread.Sleep(2000);
            Assert.AreEqual(product.prodName, infoProduct.ProductName.GetAttribute("value"));
            Assert.IsTrue(infoProduct.Category.Text.Contains(product.Category));
            Assert.IsTrue(infoProduct.Supplier.Text.Contains(product.Supplier));
            //Assert.AreEqual(product.UnitPrice, infoProduct.UnitPrice.GetAttribute("value"));
            Assert.AreEqual(product.QuantityPerUnit, infoProduct.QuantityPerUnit.GetAttribute("value"));
            Assert.AreEqual(product.UnitsInStock, infoProduct.UnitsInStock.GetAttribute("value"));
            Assert.AreEqual(product.UnitsOnOrder, infoProduct.UnitsOnOrder.GetAttribute("value"));
            Assert.AreEqual(product.ReorderLevel, infoProduct.ReorderLevel.GetAttribute("value"));
        }

        [Test]
        public void Test4()
        {
            HomePage homePage = NwAppService.UserToLogin(user, driver);
            Thread.Sleep(2000);
            AllProducts allProducts = homePage.GoToAllProducts();
            Thread.Sleep(2000);
            allProducts.GoToRemove();
            Assert.IsTrue(driver.PageSource.Contains(product.prodName));
        }

        [Test]
        public void Test5()
        {
            HomePage homePage = NwAppService.UserToLogin(user, driver);
            Thread.Sleep(2000);
            LoginPage loginPage = homePage.GoToLogout();
            Assert.AreEqual("Login", loginPage.labelHomePage.Text);
        }*/
    }
}





