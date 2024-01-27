namespace SeleniumNUnitPastebin.MainPage
{
    public class MainPage
    {
        private readonly MainPageMap Map;
        public MainPage(IWebDriver driver)
        {
            Map = new MainPageMap(driver);
        }
        public void FillPasteForm(int taskNumber)
        {
            InsertCode(TestData.TaskCode[taskNumber]);
            HighlightText(taskNumber);
            SetExpiration();
            AddTitle(TestData.TaskTitle[taskNumber]);
            Map.SubmitButton.Click();
        }

        private void InsertCode(string message)
        {
            Map.TextArea.Click();
            Map.TextArea.SendKeys(message);
        }
        private void HighlightText(int taskNumber)
        {
            if (taskNumber != 2) return;
            Map.HighlightDropdown.Click();
            Map.BashOption.Click();
        }

        private void SetExpiration()
        {
            Map.ExpirationPeriodToggle.Click();
            Map.DesiredExpiration.Click();
        }

        private void AddTitle(string title)
        {
            Map.PasteTitle.SendKeys(title);
        }
        public string GetResultScreenCode()
        {
            return Map.ResultScreenCode.Text;
        }
        public string GetResultScreenTitle()
        {
            return Map.ResultScreenTitle.Text;
        }

        public string GetResultScreenHighlight()
        {
            return Map.ResultScreenHighlight.Text;
        }
        public Dictionary<string, string> GetPageResults()
        {
            var results = new Dictionary<string, string>
            {
                { "Code", GetResultScreenCode() },
                { "Title", GetResultScreenTitle() },
                { "Highlight", GetResultScreenHighlight() }
            };

            return results;
        }


    }
}