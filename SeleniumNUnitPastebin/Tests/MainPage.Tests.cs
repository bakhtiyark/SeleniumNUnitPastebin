namespace SeleniumNUnitPastebin.Tests
{
    public class MainPageTest : BaseTest
    {
        [Test]
        [Description("Submitted text should match the input")]
        public void FormTests()
        {
            Pages.Main.FillPasteForm(taskNumber:1);
            string resultText = Pages.Main.GetResultScreenCode();
            
            Assert.True(resultText.Contains(TestData.TaskCode[1]));
        }
        [Test]
        [Description("Submitted code, highlight option and title should match the input")]
        public void FormMultilineTests()
        {
            Pages.Main.FillPasteForm(taskNumber:2);
            var result = Pages.Main.GetPageResults();
            
            Assert.That(result["Highlight"], Is.EqualTo(TestData.HighlightOption));
            Assert.That(result["Title"], Is.EqualTo(TestData.TaskTitle[2]));
            Assert.That(result["Code"], Is.EqualTo(TestData.TaskCode[2]));
        }
    }
}