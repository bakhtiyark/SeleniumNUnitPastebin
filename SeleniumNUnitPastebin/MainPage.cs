using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectModel.Source.Pages
{
    public class HomePage
    {
        private readonly string code = "Hello from Webdriver";
        private readonly string title = "helloweb";
        private readonly IWebDriver driver = new ChromeDriver();
        public void FillPasteForm()
        {
            InsertCode(code);
            SetExpiration();
            AddTitle(title);

            IWebElement submitButton = driver.FindElement(By.XPath("//button[contains(text(), \"Create New Paste\")]"));
            submitButton.Click();
        }
        public void InsertCode(string message)
        {
            IWebElement textArea = driver.FindElement(By.Id("postform-text"));
            textArea.Click();
            textArea.SendKeys(message);
        }
        public void SetExpiration()
        {
            IWebElement expirationPeriodToggle = driver.FindElement(By.Id("select2-postform-expiration-container"));
            expirationPeriodToggle.Click();
            IWebElement desiredExpiration = driver.FindElement(By.XPath("//li[text()='10 Minutes']"));
            desiredExpiration.Click();
        }
        public void AddTitle(string title)
        {
            IWebElement pasteTitle = driver.FindElement(By.Id("postform-name"));
            pasteTitle.SendKeys(title);
        }

    }
}