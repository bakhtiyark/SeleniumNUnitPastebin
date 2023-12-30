using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumNUnitPastebin
{
    public class Tests
    {
        private readonly string code = "Hello from Webdriver";
        private readonly string title = "helloweb";
        private IWebDriver driver;
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
            IWebElement textArea = driver.FindElement(By.Id("postform-text"));
            textArea.Click();
            textArea.SendKeys(code);
            
            IWebElement expirationPeriodToggle = driver.FindElement(By.Id("select2-postform-expiration-container"));
            expirationPeriodToggle.Click();
            IWebElement desiredExpiration = driver.FindElement(By.XPath("//li[text()='10 Minutes']"));
            desiredExpiration.Click();

            IWebElement pasteTitle = driver.FindElement(By.Id("postform-name"));
            pasteTitle.SendKeys(title);

            IWebElement submitButton = driver.FindElement(By.XPath("//button[contains(text(), \"Create New Paste\")]"));
            submitButton.Click();

            IWebElement resultScreen = driver.FindElement(By.XPath("//ol[@class=\"text\"]"));
            Assert.True(resultScreen != null);
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}