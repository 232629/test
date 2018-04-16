using OpenQA.Selenium;
using Protractor;
using UITestDirect2.Core.CustomElements;

namespace UITestDirect2.Core.Pages.Registration
{
    public class PageRegister : PageBase
    {
        public PageRegister(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get { return BaseUrl + "/" + Language + "/register"; }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\register.jpg"; }
        }

        public NgWebElement LnkLang
        {
            get { return FindElement(By.CssSelector("a.nav-link.dropdown-toggle")); }
        }

        public NgWebElement TxtEmail
        {
            get { return FindElement(By.Id("register-input-email")); }
        }

        public NgWebElement TxtPassword
        {
            get { return FindElement(By.Id("input-password")); }
        }
        
        public NgWebElement TxtFirstName
        {
            get { return FindElement(By.Id("input-first-name")); }
        }

        public NgWebElement TxtLastName
        {
            get { return FindElement(By.Id("input-last-name")); }
        }

        public NgCustomSelectElement CmbCountry
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-country")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbRegulator
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-regulators")), NgWebDriver); }
        }

        public NgWebElement BtnRegister
        {
            get { return FindElement(By.Id("submit-step-1")); }
        }

    }
}
