using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestProject2.pages;

namespace SpecFlowProject3.Steps
{
    [Binding]
    class LoginUserSteps
    {
        private IWebDriver driver;

        [Given(@"I open ""(.*)"" url")]
        public void GivenIOpenUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [When(@"I type in string name ""(.+)""")]
        public void WhenITypeInStringName(string userName)
        {
            new LoginPage(driver).EnterUserName(userName);
        }
        
        [When(@"I type in string password ""(.+)""")]
        public void WhenITypeInStringPassword(string passwordUser)
        {
            new LoginPage(driver).EnterUserPassword(passwordUser);
        }
        
        [When(@"clik to button submit")]
        public void WhenClikToButtonSubmit()
        {
            new LoginPage(driver).GoToHomePage();
        }
        
        [Then(@"I check the user input and the ""(.*)"" button")]
        public void ThenICheckTheUserInputAndTheButton(string logoutButton)
        {
            new HomePage(driver).CheckElementLogout(logoutButton);
            driver.Close();
            driver.Quit();
        }
    }
}
