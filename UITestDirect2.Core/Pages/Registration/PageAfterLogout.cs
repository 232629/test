using Protractor;

namespace UITestDirect2.Core.Pages.Registration
{
    public class PageAfterLogout : PageBase
    {
        public PageAfterLogout(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/after-logout";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\AfterLogout.jpg"; }
        }       

    }
}
