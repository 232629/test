using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Registration
{
    public class PageThankYou : PageBase
    {
        public PageThankYou(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/register/thankyou";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\RegisterThankyou.jpg"; }
        }

        public NgWebElement LnkContinueToFxPro
        {
            get { return FindElement(By.LinkText("")); }
        }


        public NgWebElement LblWelcome
        {
            get { return WaitDisplayElements(FindElement(By.CssSelector("div.welcome-holder>h2"))); }
        }
        

    }
}
