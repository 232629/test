using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Registration
{
    public class PageActivationCode : PageBase
    {
        public PageActivationCode(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/login/forgot-password/code";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\LoginForgot-passwordCode.jpg"; }
        }

        public NgWebElement TxtActivationCode
        {
            get { return FindElement(By.Id("input-activation-code")); }
        }

        
        public NgWebElement BtnSend
        {
            get { return FindElement(By.Id("forgot-password-button")); }
        }

        public NgWebElement BtnClose
        {
            get { return FindElement(By.CssSelector("a.close")); }
        }

    }
}
