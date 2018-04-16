using OpenQA.Selenium;
using Protractor;
using UITestDirect2.Core.CustomElements;

namespace UITestDirect2.Core.Pages.Registration
{
    public class PageRregisterStep1 : PageBase
    {
        public PageRregisterStep1(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/register/step1";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\registerStep1.jpg"; }
        }

        public string UsedBrowser
        {
            get { return Browser; }
        }

        public NgWebElement TxtAddress
        {
            get { return FindElement(By.Id("input-address")); }
        }

        public NgWebElement TxtPostcode
        {
            get { return FindElement(By.Id("input-postcode")); }
        }
        
        public NgWebElement TxtCity
        {
            get { return FindElement(By.Id("input-town")); }
        }

        /// <summary>
        /// Field Emirate uses only by United Arab Emirates
        /// </summary>
        public NgCustomSelectElement CmbEmirate
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-emirate")), NgWebDriver); }
        }

        public NgWebElement TxtBirthdate
        {
            get { return FindElement(By.CssSelector("input[name = birthdate]")); }
        }

        public NgWebElement TxtPhone
        {
            get { return FindElement(By.Id("input-phone")); }
        }

        /// <summary>
        /// Field QQ uses only by China
        /// </summary>
        public NgWebElement TxtQq
        {
            get { return FindElement(By.Id("input-qq")); }
        }
        /// <summary>
        /// Field CmbChanneLearnAboutFxPro use only by China
        /// </summary>
        public NgCustomSelectElement CmbChanneLearnAboutFxPro
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbNationality
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-nationality")), NgWebDriver); }
        }

        public NgWebElement BtnNexStep
        {
            get { return FindElement(By.Id("submit-step-2")); }
        }

    }
}
