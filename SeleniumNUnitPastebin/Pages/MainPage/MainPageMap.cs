using SeleniumNUnitPastebin.Utilities;
namespace SeleniumNUnitPastebin.MainPage;

    public class MainPageMap
    {
        protected Helpers Helper { get; }
        public MainPageMap(IWebDriver driver)
        {
            Helper = new Helpers(driver);
        }
        public IWebElement PasteTitle => Helper.LocateElement(Locators.ID, "postform-name");
        public IWebElement HighlightDropdown => Helper.LocateElement(Locators.ID, "select2-postform-format-container");
        public IWebElement BashOption => Helper.LocateElement(Locators.Xpath,"//li[text()=\"Bash\"]");
        public IWebElement DesiredExpiration => Helper.LocateElement(Locators.Xpath, "//li[text()='10 Minutes']");
        public IWebElement ExpirationPeriodToggle => Helper.LocateElement(Locators.ID, "select2-postform-expiration-container");
        public IWebElement TextArea => Helper.LocateElement(Locators.ID, "postform-text");
        public IWebElement SubmitButton => Helper.LocateElement(Locators.Xpath, "//button[contains(text(), \"Create New Paste\")]");
        public IWebElement ResultScreenCode => Helper.LocateElement(Locators.Xpath, "//ol");
        public IWebElement ResultScreenTitle => Helper.LocateElement(Locators.Xpath, "//div[@class=\"info-top\"]//h1"); 
        public IWebElement ResultScreenHighlight => Helper.LocateElement(Locators.Xpath, "//a[@class=\"btn -small h_800\"]"); 

    }