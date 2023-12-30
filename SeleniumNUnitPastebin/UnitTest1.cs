using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.Source.Pages;

namespace SeleniumNUnitPastebin
{
    public class Tests
    {
        private IWebDriver driver;
        readonly HomePage page = new HomePage();
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://pastebin.com";
        }

        [Test]
        public void Test1()
        {
            page.FillPasteForm();

            IWebElement resultScreen = driver.FindElement(By.XPath("//ol[@class=\"text\"]"));
            // TO BE REPLACED With something similar to PW's contains() method
            Assert.True(resultScreen != null);
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}