using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using TestProject2.Page;

namespace TestProject2.pages
{
    class InfoProduct : AbstractPage
    {
        public InfoProduct(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input[@id='ProductName']")]
        public IWebElement ProductName;
        [FindsBy(How = How.Id, Using = "CategoryId")]
        public IWebElement Category;
        [FindsBy(How = How.XPath, Using = "//select[@id='SupplierId']")]
        public IWebElement Supplier;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        public IWebElement UnitPrice;
        [FindsBy(How = How.XPath, Using = "//input[@id='QuantityPerUnit']")]
        public IWebElement QuantityPerUnit;
        [FindsBy(How = How.Id, Using = "UnitsInStock")]
        public IWebElement UnitsInStock;
        [FindsBy(How = How.Id, Using = "UnitsOnOrder")]
        public IWebElement UnitsOnOrder;
        [FindsBy(How = How.Id, Using = "ReorderLevel")]
        public IWebElement ReorderLevel;

    }
}
