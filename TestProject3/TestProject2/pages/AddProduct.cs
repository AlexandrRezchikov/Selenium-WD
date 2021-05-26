using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TestProject2.business_page;
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
        public AddProduct AddPrdt(Product product)
        {
            prodName.SendKeys(product.prodName);
            driver.FindElement(By.XPath($"//option[contains(text(),'{product.Category}')]")).Click();
            driver.FindElement(By.XPath($"//option[contains(text(),'{product.Supplier}')]")).Click();
            UnitPrice.SendKeys(product.UnitPrice);
            QuantityPerUnit.SendKeys(product.QuantityPerUnit);
            UnitsInStock.SendKeys(product.UnitsInStock);
            UnitsOnOrder.SendKeys(product.UnitsOnOrder);
            ReorderLevel.SendKeys(product.ReorderLevel);
            driver.FindElement(By.Id(product.Discontinued)).Click();
            btnSend.Click();
            return new AddProduct(driver);
        }

    }
}
