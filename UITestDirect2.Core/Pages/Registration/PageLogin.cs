using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Registration
{
    public class PageLogin : PageBase
    {
        public PageLogin(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }
        
        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/login";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\Login.jpg"; }
        }

        public NgWebElement LnkCreateAnAccount
        {
            get { return FindElement(By.CssSelector("a#login-real-account.border-link")); }
        }

        public NgWebElement TxtEmail
        {
            get { return FindElement(By.Id("login-input-email")); }
        }

        public NgWebElement TxtPassword
        {
            get { return FindElement(By.Id("login-input-password")); }
        }

        public NgWebElement ChkStaySignedIn

        {
            get { return FindElement(By.CssSelector("span.custom-control-indicator")); }
        }

        public NgWebElement BtnLogin
        {
            get { return FindElement(By.Id("login-signin-button")); }
        }

        public NgWebElement MsgError
        {
            get { return WaitDisplayElements(FindElement(By.CssSelector("div.text-danger"))); }
        }

        public NgWebElement LnkFogotPassword
        {
            get { return FindElement(By.CssSelector("div.restore-pass-block>a")); }
        }
        
    }
}
