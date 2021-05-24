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
    class AllProducts : AbstractPage
    {
        public AllProducts(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Create new')]")]
        private IWebElement btncreatenew;
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Fresh fruits')])[1]")]
        private IWebElement freshfruits;
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Remove')])[78]")]
        private IWebElement remove;
    
        public ProductInf CheckAdd()
        {
            freshfruits.Click();
            return new ProductInf(driver);
        }
        
        public AddProduct ClickBtn()
        {
            btncreatenew.Click();
            return new AddProduct(driver);
        }
        public void CheckBtn()
        {
            Assert.AreEqual("Create new", btncreatenew.Text);
        }
        public AllProducts Remove()
        {
            remove.Click();
            driver.SwitchTo().Alert().Accept();
            Assert.IsTrue(driver.PageSource.Contains("Fresh fruits"));
            return new AllProducts(driver);
        }
    }
}
