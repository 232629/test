using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Registration
{
    public class PageFogetPassword : PageBase
    {
        public PageFogetPassword(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/login/forgot-password/email";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\LoginForgot-passwordEmail.jpg"; }
        }

        public NgWebElement TxtEmail
        {
            get { return FindElement(By.CssSelector("input#input-email")); }
        }

        public NgWebElement BtnResetPassword
        {
            get { return FindElement(By.Id("reset-password-button")); }
        }

        public NgWebElement BtnClose
        {
            get { return FindElement(By.CssSelector("a.close")); }
        }

    }
}
