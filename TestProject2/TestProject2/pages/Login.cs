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
    class Login : AbstractPage
    {
        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement name;
        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement password;
        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement btnlogin;
        [FindsBy(How = How.XPath, Using = "//h2")]
        private IWebElement h2;


        public HomePage LogIn()
        {
            name.SendKeys("user");
            password.SendKeys("user");
            btnlogin.Click();            
            return new HomePage(driver);
        }
        public void CheckOut()
        {
            Assert.AreEqual("Login", h2.Text);
        }
    }
}
