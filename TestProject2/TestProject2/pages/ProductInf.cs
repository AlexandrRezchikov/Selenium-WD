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
        private IWebElement pn;
        [FindsBy(How = How.Id, Using = "CategoryId")]
        private IWebElement cat;
        [FindsBy(How = How.XPath, Using = "//select[@id='SupplierId']")]
        private IWebElement sup;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        private IWebElement up;
        [FindsBy(How = How.XPath, Using = "//input[@id='QuantityPerUnit']")]
        private IWebElement qp;
        [FindsBy(How = How.Id, Using = "UnitsInStock")]
        private IWebElement us;
        [FindsBy(How = How.Id, Using = "UnitsOnOrder")]
        private IWebElement uoo;
        [FindsBy(How = How.Id, Using = "ReorderLevel")]
        private IWebElement rl;
        public ProductInf Check()
        {
            Assert.AreEqual("Fresh fruits", pn.GetAttribute("value"));
            //Assert.IsTrue(cat.Text.Contains("Beverages"));
            Assert.AreEqual("Beverages", cat.Text);
            Assert.IsTrue(sup.Text.Contains("Exotic Liquids"));
            Assert.AreEqual("100,0000", up.GetAttribute("value"));
            Assert.AreEqual("10 boxes", qp.GetAttribute("value"));
            Assert.AreEqual("40", us.GetAttribute("value"));
            Assert.AreEqual("0", uoo.GetAttribute("value"));
            Assert.AreEqual("10", rl.GetAttribute("value"));
            return new ProductInf(driver);
        }

    }
}
