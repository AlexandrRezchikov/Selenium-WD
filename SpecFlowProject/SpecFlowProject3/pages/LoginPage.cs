using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using TestProject2.business_page;
using TestProject2.Page;

namespace TestProject2.pages
{
    class LoginPage : AbstractPage
    {
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement nameElement;
        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement passworElement;
        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement buttonLogin;
        [FindsBy(How = How.XPath, Using = "//h2")]
        public IWebElement labelHomePage;


        public HomePage LogIn(User user)
        {
            nameElement.SendKeys(user.nameUser);
            passworElement.SendKeys(user.passwordUser);
            buttonLogin.Click();            
            return new HomePage(driver);
        }
        public void EnterUserName(string nameUser)
        {
            nameElement.SendKeys(nameUser);
        }
        public void EnterUserPassword(string passwordUser)
        {
            passworElement.SendKeys(passwordUser);
        }
        public void GoToHomePage()
        {
            buttonLogin.Click();
        }
    }
}
