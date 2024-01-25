namespace SeleniumNUnitPastebin.Tests
{
    public class MainPageTest : BaseTest
    {
        [Test]
        [Description("Submitted text should match the input")]
        public void FormTests()
        {
            // TODO : Fix this weird issue
            Pages.Main.FillPasteForm();
            string resultText = Pages.Main.getResultScreenText();
            
            Assert.True(resultText.Contains("Hello from Webdriver"));
        }
    }
}