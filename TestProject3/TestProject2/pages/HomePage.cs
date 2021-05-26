
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TestProject2.Page;
using OpenQA.Selenium.Support.UI;

namespace TestProject2.pages
{
    class HomePage : AbstractPage
    {
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'All Products')])[2]")]
        private IWebElement allprdt;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Logout')]")]
        public IWebElement logout;
        public AllProducts Click()
        {
            allprdt.Click();
            return new AllProducts(driver);
        }
        public Login LogOut()
        {
            logout.Click();
            return new Login(driver);
        }
    }
}
