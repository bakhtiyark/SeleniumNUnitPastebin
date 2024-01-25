namespace SeleniumNUnitPastebin.Tests
{
    public class MainPageTest : BaseTest
    {
        [Test]
        [Description("Submitted text should match the input")]
        public void FormTests()
        {
            Pages.Main.FillPasteForm(taskNumber:1);
            string resultText = Pages.Main.GetResultScreenText();
            
            Assert.True(resultText.Contains(TestData.TaskCode[1]));
        }
        [Test]
        [Description("Submitted text should match the input")]
        public void FormMultilineTests()
        {
            Pages.Main.FillPasteForm(taskNumber:2);
            string resultText = Pages.Main.GetResultScreenText();
            
            Assert.True(resultText.Contains(TestData.TaskCode[2]));
        }
    }
}