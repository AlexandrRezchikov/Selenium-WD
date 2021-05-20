using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

        public void formlogin()
        {
            IWebElement login = driver.FindElement(By.Id("Name"));
            IWebElement passwr = driver.FindElement(By.Id("Password"));
            IWebElement submitBtn = driver.FindElement(By.XPath("//input[@type='submit']"));

            login.SendKeys("user");
            passwr.SendKeys("user");
            submitBtn.Click();
        }

        [Test]
        public void Test1()
        {
            formlogin();

            IWebElement logout = driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));
            Assert.AreEqual("Logout", logout.Text);

        }
        [Test]
        public void Test2()
        {
            formlogin();

            IWebElement allpr = driver.FindElement(By.XPath("(//a[contains(text(),'All Products')])[2]"));
            allpr.Click();

            IWebElement createnew = driver.FindElement(By.XPath("//a[contains(text(),'Create new')]"));
            createnew.Click();

            IWebElement prodname = driver.FindElement(By.Id("ProductName"));
            prodname.SendKeys("Fresh fruits");

            IWebElement category = driver.FindElement(By.XPath("//option[contains(text(),'Beverages')]"));
            category.Click();

            IWebElement supplier = driver.FindElement(By.XPath("//option[contains(text(),'Exotic Liquids')]"));
            supplier.Click();

            IWebElement UnitPrice = driver.FindElement(By.Id("UnitPrice"));
            UnitPrice.SendKeys("100");

            IWebElement QuantityPerUnit = driver.FindElement(By.Id("QuantityPerUnit"));
            QuantityPerUnit.SendKeys("10 boxes");

            IWebElement UnitsInStock = driver.FindElement(By.Id("UnitsInStock"));
            UnitsInStock.SendKeys("40");

            IWebElement UnitsOnOrder = driver.FindElement(By.Id("UnitsOnOrder"));
            UnitsOnOrder.SendKeys("0");

            IWebElement ReorderLevel = driver.FindElement(By.Id("ReorderLevel"));
            ReorderLevel.SendKeys("10");

            IWebElement Discontinued = driver.FindElement(By.Id("Discontinued"));
            Discontinued.Click();

            IWebElement btn = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            btn.Click();

            IWebElement tcreate = driver.FindElement(By.XPath("//a[contains(text(),'Create new')]"));
            Assert.AreEqual("Create new", tcreate.Text);

        }

        [Test]
        public void Test3()
        {
            formlogin();

            IWebElement allpr = driver.FindElement(By.XPath("(//a[contains(text(),'All Products')])[2]"));
            allpr.Click();

            IWebElement ff = driver.FindElement(By.XPath("(//a[contains(text(),'Fresh fruits')])[1]"));
            ff.Click();

            IWebElement pn = driver.FindElement(By.XPath("//input[@id='ProductName']"));
            Assert.AreEqual("Fresh fruits", pn.GetAttribute("value"));

            IWebElement cat = driver.FindElement(By.Id("CategoryId"));
            Assert.IsTrue(cat.Text.Contains("Beverages"));

            IWebElement sup = driver.FindElement(By.XPath("//select[@id='SupplierId']"));
            Assert.IsTrue(sup.Text.Contains("Exotic Liquids"));

            IWebElement up = driver.FindElement(By.Id("UnitPrice"));
            Assert.AreEqual("100,0000", up.GetAttribute("value"));

            IWebElement qp = driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']"));
            Assert.AreEqual("10 boxes", qp.GetAttribute("value"));

            IWebElement us = driver.FindElement(By.Id("UnitsInStock"));
            Assert.AreEqual("40", us.GetAttribute("value"));

            IWebElement uoo = driver.FindElement(By.Id("UnitsOnOrder"));
            Assert.AreEqual("0", uoo.GetAttribute("value"));

            IWebElement rl = driver.FindElement(By.Id("ReorderLevel"));
            Assert.AreEqual("10", rl.GetAttribute("value"));
        }

        [Test]
        public void Test4()
        {
            formlogin();

            IWebElement allpr = driver.FindElement(By.XPath("(//a[contains(text(),'All Products')])[2]"));
            allpr.Click();

            IWebElement remove = driver.FindElement(By.XPath("(//a[contains(text(),'Remove')])[78]"));
            remove.Click();

            driver.SwitchTo().Alert().Accept();
            Assert.IsTrue(driver.PageSource.Contains("Fresh fruits"));
        }

        [Test]
        public void Test5()
        {
            formlogin();

            IWebElement logout = driver.FindElement(By.XPath("//a[@href='/Account/Logout']"));
            logout.Click();

            IWebElement log = driver.FindElement(By.XPath("//h2[contains(.,'Login')]"));
            Assert.IsTrue(log.Text.Contains("Login"));

            IWebElement na = driver.FindElement(By.XPath("//label[@for='Name']"));
            Assert.AreEqual("Name", na.Text);

            IWebElement pswrd = driver.FindElement(By.XPath("//label[@for='Password']"));
            Assert.AreEqual("Password", pswrd.Text);

        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}