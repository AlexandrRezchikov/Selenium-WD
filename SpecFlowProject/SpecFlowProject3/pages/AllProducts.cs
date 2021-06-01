using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using TestProject2.business_page;
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
        public IWebElement buttonCreateNew;
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Fresh fruits')])[1]")]
        private IWebElement freshfruits;
        [FindsBy(How = How.XPath, Using = "//tr[td[a[text()='Fresh fruits']]]/td[a[text()='Remove']]")]
        public IWebElement buttonRemove;
    
        public InfoProduct ProductCheck()
        {
            freshfruits.Click();
            return new InfoProduct(driver);
        }
        
        public ProductEditing CreateNewProduct()
        {
            buttonCreateNew.Click();
            return new ProductEditing(driver);
        }
        public AllProducts GoToRemove()
        {
            buttonRemove.Click();
            driver.SwitchTo().Alert().Accept();
            return new AllProducts(driver);
        }
    }
}
