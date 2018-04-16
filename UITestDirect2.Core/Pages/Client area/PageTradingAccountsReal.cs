using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageTradingAccountsReal : PageTradingAccountsBase
    {
        private readonly string _screenShot;

        public PageTradingAccountsReal(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/accounts/real";
            }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\AccountsReal.jpg"; }
        }
    }
}
