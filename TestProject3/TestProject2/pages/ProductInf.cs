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
    class ProductInf : AbstractPage
    {
        public ProductInf(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input[@id='ProductName']")]
        public IWebElement pn;
        [FindsBy(How = How.Id, Using = "CategoryId")]
        public IWebElement cat;
        [FindsBy(How = How.XPath, Using = "//select[@id='SupplierId']")]
        public IWebElement sup;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        public IWebElement up;
        [FindsBy(How = How.XPath, Using = "//input[@id='QuantityPerUnit']")]
        public IWebElement qp;
        [FindsBy(How = How.Id, Using = "UnitsInStock")]
        public IWebElement us;
        [FindsBy(How = How.Id, Using = "UnitsOnOrder")]
        public IWebElement uoo;
        [FindsBy(How = How.Id, Using = "ReorderLevel")]
        public IWebElement rl;

    }
}
