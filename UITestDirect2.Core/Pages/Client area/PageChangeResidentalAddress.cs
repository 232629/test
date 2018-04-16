using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageChangeResidentalAddress : PageCommon
    {
        public PageChangeResidentalAddress(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/profile/address";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\ProfileAddress.jpg"; }
        }

        public NgWebElement TxtStreetNumber
        {
            get { return FindElement(By.Id("input-street_number")); }
        }

        public NgWebElement TxtPostCode
        {
            get { return FindElement(By.Id("input-postcode")); }
        }

        public NgWebElement TxtCity
        {
            get { return FindElement(By.Id("input-town")); }
        }

        public NgWebElement TxStreetName
        {
            get { return FindElement(By.Id("input-street_name")); }
        }

        public NgWebElement TxtState
        {
            get { return FindElement(By.Id("input-state_province")); }
        }

        public NgWebElement TxtMovedToCurrentAddress
        {
            get { return FindElement(By.Id("input-move_year")); }
        }

        public NgWebElement BtnSave
        {
            get { return FindElement(By.CssSelector("button.btn-green.arrow.btn")); }
        }

    }
}
