using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageChangePassword : PageCommon
    {
        public PageChangePassword(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/profile/password";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\ProfilePassword.jpg"; }
        }

        public NgWebElement TxtCurrentPassword
        {
            get { return FindElement(By.Id("input-current-password")); }
        }

        public NgWebElement TxtNewPassword
        {
            get { return FindElement(By.Id("input-new-password")); }
        }

        public NgWebElement TxtRepeatPassword
        {
            get { return FindElement(By.Id("input-confirm-password")); }
        }

        public NgWebElement BtnChange
        {
            get { return FindElement(By.CssSelector("button.btn-green.arrow.btn")); }
        }

    }
}
