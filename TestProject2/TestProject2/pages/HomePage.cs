using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject2.Page;

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
        private IWebElement logout;

        //IWebElement logout = driver.FindElement(By.XPath("//a[@href='/Account/Logout']"));
        public void Logout()
        {
            Assert.AreEqual("Logout", logout.Text);
        }
        public AllProducts Click()
        {
            allprdt.Click();
            return new AllProducts(driver);
        }
        public void LogOut()
        {
            logout.Click();
        }
    }
}
