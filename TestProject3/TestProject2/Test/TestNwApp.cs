using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TestProject2.business_page;
using TestProject2.pages;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver driver;
        private User user = new User("user", "user");
        private Product product = new Product("Fresh fruits", "Beverages", "Exotic Liquids", "100", "10 boxes", "40", "0", "10", "Discontinued");

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void LoginTest()
        {
            Login login = new Login(driver);
            HomePage homePage = login.LogIn(user);
            //Thread.Sleep(2000);
            Assert.AreEqual("Logout", homePage.logout.Text);
        }
        [Test]
        public void AddProductTest()
        {
            Login login = new Login(driver);
            HomePage homePage = login.LogIn(user);
            Thread.Sleep(1000);
            AllProducts allProducts = homePage.Click();
            Thread.Sleep(1000);
            AddProduct addProduct = allProducts.ClickBtn();
            Thread.Sleep(1000);
            addProduct.AddPrdt(product);
            Assert.AreEqual("Create new", allProducts.btncreatenew.Text);
        }

        [Test]
        public void Test3()
        {
            Login login = new Login(driver);
            HomePage homePage = login.LogIn(user);
            Thread.Sleep(1000);
            AllProducts allProducts = homePage.Click();
            Thread.Sleep(1000);
            ProductInf productInf = allProducts.CheckAdd();
            Thread.Sleep(1000);
            Assert.AreEqual("Fresh fruits", productInf.pn.GetAttribute("value"));
            Assert.IsTrue(productInf.cat.Text.Contains("Beverages"));
            Assert.IsTrue(productInf.sup.Text.Contains("Exotic Liquids"));
            Assert.AreEqual("100,0000", productInf.up.GetAttribute("value"));
            Assert.AreEqual("10 boxes", productInf.qp.GetAttribute("value"));
            Assert.AreEqual("40", productInf.us.GetAttribute("value"));
            Assert.AreEqual("0", productInf.uoo.GetAttribute("value"));
            Assert.AreEqual("10", productInf.rl.GetAttribute("value"));
        }

        [Test]
        public void Test4()
        {
            Login login = new Login(driver);
            HomePage homePage = login.LogIn(user);
            Thread.Sleep(1000);
            AllProducts allProducts = homePage.Click();
            Thread.Sleep(1000);
            allProducts.Remove();
            Assert.IsTrue(driver.PageSource.Contains("Fresh fruits"));
        }

        [Test]
        public void Test5()
        {
            Login login = new Login(driver);
            HomePage homePage = login.LogIn(user);
            homePage.LogOut();
            Assert.AreEqual("Login", login.h2.Text);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}