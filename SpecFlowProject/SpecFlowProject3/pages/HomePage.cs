using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
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
        public IWebElement buttonAllProducts;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Logout')]")]
        public IWebElement logout;
        public AllProducts GoToAllProducts()
        {
            buttonAllProducts.Click();
            return new AllProducts(driver);
        }
        public LoginPage GoToLogout()
        {
            logout.Click();
            return new LoginPage(driver);
        }
        public void CheckElementLogout(string logoutButton)
        {
            Assert.AreEqual(logoutButton, logout.Text);
        }
    }
}
