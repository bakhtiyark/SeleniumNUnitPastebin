using SeleniumNUnitPastebin.Utilities;
namespace SeleniumNUnitPastebin.MainPage;

    // This class stores the locators to all of the elements that can be interacted with on the page
    public class MainPageMap
    {
        protected Helpers Helper { get; }
        public MainPageMap(IWebDriver driver)
        {
            Helper = new Helpers(driver);
        }

        //Page elements used for synchronisation
        public By InventoryContainer => By.Id("inventory_container");

        //Page elements for interaction
        public IWebElement PasteTitle => Helper.LocateElement(Locators.ID, "postform-name");
        public IWebElement HighlightDropdown => Helper.LocateElement(Locators.ID, "select2-postform-format-container");
        public IWebElement BashOption => Helper.LocateElement(Locators.Xpath,"//li[text()=\"Bash\"]");
        public IWebElement DesiredExpiration => Helper.LocateElement(Locators.Xpath, "//li[text()='10 Minutes']");
        public IWebElement ExpirationPeriodToggle => Helper.LocateElement(Locators.ID, "select2-postform-expiration-container");
        public IWebElement TextArea => Helper.LocateElement(Locators.ID, "postform-text");
        public IWebElement SubmitButton => Helper.LocateElement(Locators.Xpath, "//button[contains(text(), \"Create New Paste\")]");
        public IWebElement ResultScreen => Helper.LocateElement(Locators.Xpath, "//ol");

    }