using SeleniumNUnitPastebin.MainPage;

internal class Pages : BaseTest
{
    public static MainPage Main;

    public static void Init(IWebDriver driver)
    {
        Main = new MainPage(driver);
    }
}