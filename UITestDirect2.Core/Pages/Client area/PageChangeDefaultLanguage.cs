using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageChangeDefaultLanguage : PageCommon
    {
        public PageChangeDefaultLanguage(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/profile/language";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\ProfileLanguage.jpg"; }
        }

        public NgWebElement BtnSave
        {
            get { return FindElement(By.CssSelector("button.btn-green.arrow.btn")); }
        }

    }
}
