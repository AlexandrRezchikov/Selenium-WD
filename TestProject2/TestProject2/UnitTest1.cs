using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TestProject2.pages;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
        }



        [Test]
        public void Test1()
        {
            Login login = new Login(driver);
            HomePage homePage = login.LogIn();
            //Thread.Sleep(2000);
            homePage.Logout();
        }
        [Test]
        public void Test2()
        {
            Login login = new Login(driver);
            HomePage homePage = login.LogIn();
            AllProducts allProducts = homePage.Click();
            AddProduct addProduct = allProducts.ClickBtn();
            addProduct.AddPrdt();
            allProducts.CheckBtn();
        }

        [Test]
        public void Test3()
        {
            Login login = new Login(driver);
            HomePage homePage = login.LogIn();
            AllProducts allProducts = homePage.Click();
            ProductInf productInf = allProducts.CheckAdd();
        }

        [Test]
        public void Test4()
        {
            Login login = new Login(driver);
            HomePage homePage = login.LogIn();
            AllProducts allProducts = homePage.Click();
            allProducts.Remove();
        }

        [Test]
        public void Test5()
        {
            Login login = new Login(driver);
            HomePage homePage = login.LogIn();
            homePage.LogOut();
            login.CheckOut();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}