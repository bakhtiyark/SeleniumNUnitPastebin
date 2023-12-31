using NUnit.Framework.Interfaces;

namespace SeleniumNUnitPastebin.Tests
{
    public class Tests
    {
        private IWebDriver driver;
        private HomePage page;
        private string expectedText;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://pastebin.com";
            // Perhaps there's a better way to wait for elements?
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            page = new HomePage(driver);

            string jsonData = File.ReadAllText("../../../framework/datalayer.json");
            dynamic testData = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
            expectedText = testData.code;

        }

        [Test]
        public void Test()
        {
            page.FillPasteForm();

            IWebElement resultScreen = driver.FindElement(By.XPath("//ol[@class=\"text\"]"));
            string resultText = resultScreen.Text;
            Assert.True(resultText.Contains(expectedText));
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}