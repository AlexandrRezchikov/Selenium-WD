using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TestProject2.Page;

namespace TestProject2.pages
{
    class AddProduct : AbstractPage
    {
        public AddProduct(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "ProductName")]
        private IWebElement prodName;
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'Beverages')]")]
        private IWebElement Category;
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'Exotic Liquids')]")]
        private IWebElement Supplier;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        private IWebElement UnitPrice;
        [FindsBy(How = How.Id, Using = "QuantityPerUnit")]
        private IWebElement QuantityPerUnit;
        [FindsBy(How = How.Id, Using = "UnitsInStock")]
        private IWebElement UnitsInStock;
        [FindsBy(How = How.Id, Using = "UnitsOnOrder")]
        private IWebElement UnitsOnOrder;
        [FindsBy(How = How.Id, Using = "ReorderLevel")]
        private IWebElement ReorderLevel;
        [FindsBy(How = How.Id, Using = "Discontinued")]
        private IWebElement Discontinued;
        [FindsBy(How = How.XPath, Using = "//input[@class='btn btn-default']")]
        private IWebElement btnSend;
        public AddProduct AddPrdt()
        {
            prodName.SendKeys("Fresh fruits");
            Category.Click();
            Supplier.Click();
            UnitPrice.SendKeys("100");
            QuantityPerUnit.SendKeys("10 boxes");
            UnitsInStock.SendKeys("40");
            UnitsOnOrder.SendKeys("0");
            ReorderLevel.SendKeys("10");
            Discontinued.Click();
            btnSend.Click();
            return new AddProduct(driver);
        }

    }
}
