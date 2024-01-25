namespace SeleniumNUnitPastebin.MainPage
{
    public class MainPage
    {
        private readonly string code = "Hello from Webdriver";
        private readonly string title = "helloweb";
        public readonly MainPageMap Map;
        public MainPage(IWebDriver driver)
        {
            Map = new MainPageMap(driver);
        }
        public void FillPasteForm()
        {
            InsertCode(code);
            SetExpiration();
            AddTitle(title);
            Map.SubmitButton.Click();
        }
        public void InsertCode(string message)
        {
            Map.TextArea.Click();
            Map.TextArea.SendKeys(message);
        }
        public void SetExpiration()
        {
            Map.ExpirationPeriodToggle.Click();
            Map.DesiredExpiration.Click();
        }
        public void AddTitle(string title)
        {
            Map.PasteTitle.SendKeys(title);
        }
        public string getResultScreenText()
        {
            return Map.ResultScreen.Text;
        }

    }
}