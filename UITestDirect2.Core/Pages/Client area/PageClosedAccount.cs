using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageClosedAccount : PageBase
    {
        public PageClosedAccount(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/closed-account";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\ClosedAccount.jpg"; }
        }

        public NgWebElement LblHader
        {
            get { return WaitDisplayElements(FindElement(By.CssSelector("div.col-lg-6>h2"))); }
        }

        public NgWebElement LblBody
        {
            get { return WaitDisplayElements(FindElement(By.CssSelector("div.col-lg-6>div"))); }
        }

        public NgWebElement LnkLogout
        {
            get { return FindElement(By.CssSelector("a.border-link")); }
        }


    }
}
