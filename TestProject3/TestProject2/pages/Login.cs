using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject2.business_page;
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
        private IWebElement nameElement;
        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement passwordElement;
        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement btnlogin;
        [FindsBy(How = How.XPath, Using = "//h2")]
        public IWebElement h2;


        public HomePage LogIn(User user)
        {
            nameElement.SendKeys(user.nameUser);
            passwordElement.SendKeys(user.passwordUser);
            btnlogin.Click();            
            return new HomePage(driver);
        }
    }
}
