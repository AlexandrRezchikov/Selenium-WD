using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestProject2.business_page;
using TestProject2.pages;
using TestProject2.service.ui;

namespace SpecFlowProject3.Steps
{
    [Binding]
    public class ProductEditingSteps
    {
        private IWebDriver driver;
        private Product product = new Product("Fresh fruits", "Beverages", "Exotic Liquids", "100,000", "10 boxes", "40", "0", "10", "Discontinued");
        private AllProducts allProducts;

        [Given(@"I Open ""(.*)"" url")]
        public void GivenIOpenUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Given(@"I type ""(.*)"" login and ""(.*)"" password and click on submit button")]
        public void GivenITypeLoginAndPasswordAndClickOnSubmitButton(string login, string password)
        {
            User user = new User(login, password);
            HomePage homePage = NwAppService.UserToLogin(user, driver);
        }

        [Given(@"I Click on All Products")]
        public void GivenIClickOnAllProducts()
        {
            new HomePage(driver).GoToAllProducts();
        }

        [Given(@"I Click on Create New")]
        public void GivenIClickOnCreateNew()
        {
            allProducts = new AllProducts(driver);
            allProducts.CreateNewProduct();
        }

        [Given(@"I Enter values into fields")]
        public void GivenIEnterValuesIntoFields()
        {
            new ProductEditing(driver).AddNewProduct(product);
        }

        [When(@"I click on submit Button")]
        public void WhenIClickOnSubmitButton()
        {
            new ProductEditing(driver).ClickButtonSubmit();
        }

        [Then(@"The Create/edit form has closed")]
        public void ThenTheCreateEditFormHasClosed()
        {
            Assert.AreEqual("Create new", allProducts.buttonCreateNew.Text);
            driver.Close();
            driver.Quit();
        }
    }
}