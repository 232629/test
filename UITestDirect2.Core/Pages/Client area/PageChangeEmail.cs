using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageChangeEmail : PageCommon
    {
        public PageChangeEmail(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/profile/email";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\ProfileEmail.jpg"; }
        }

        public NgWebElement TxtStreetNumber
        {
            get { return FindElement(By.Id("input-street_number")); }
        }

        public NgWebElement TxtEmail
        {
            get { return FindElement(By.Id("input-email")); }
        }

        public NgWebElement BtnConfirm
        {
            get { return FindElement(By.CssSelector("button.btn-green.arrow.btn")); }
        }

    }
}
