namespace SeleniumNUnitPastebin.Core;

public class TestData
{
    public static Dictionary<int, string> TaskCode = new Dictionary<int, string>
    {
        { 1, "Hello from Webdriver" },
        { 2, @"git config --global user.name  ""New Sheriff in Town""
git reset $(git commit-tree HEAD^{tree} -m ""Legacy code"")
git push origin master --force" },

    };
    public static Dictionary<int, string> TaskTitle = new Dictionary<int, string>
    {
        { 1, "helloweb" },
        { 2, "how to gain dominance among developers" },
    };
}