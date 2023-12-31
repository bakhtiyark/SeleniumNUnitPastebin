using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjectModel.Source.Pages;

namespace SeleniumNUnitPastebin.Tests
{
    public class Tests
    {
        private IWebDriver driver;
        private HomePage page;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://pastebin.com";
            // Perhaps there's a better way to wait for elements?
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            page = new HomePage(driver);

        
        }

        [Test]
        public void Test()
        {
            page.FillPasteForm();

            IWebElement resultScreen = driver.FindElement(By.XPath("//ol[@class=\"text\"]"));
            string resultText = resultScreen.Text;
            string expectedText = "Hello from Webdriver";
            Assert.True(resultText.Contains(expectedText));
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}