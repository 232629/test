using OpenQA.Selenium;
using Protractor;
using UITestDirect2.Core.CustomElements;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageManageBankDetails : PageCommon
    {
        public PageManageBankDetails(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/bank/details";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\ManageBankDetails.jpg"; }
        }

        public NgWebElement TxtBankName
        {
            get { return FindElement(By.Id("input-bank-name")); }
        }

        public NgWebElement TxtBankAddress
        {
            get { return FindElement(By.Id("input-bank-address")); }
        }

        public NgWebElement TxtAccountName
        {
            get { return FindElement(By.Id("input-account-name")); }
        }

        public NgCustomSelectElement CmbCurrency
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-account-currency")), NgWebDriver); }
        }

        public NgWebElement TxtIban
        {
            get { return FindElement(By.Id("input-account-iban")); }
        }

        public NgWebElement TxtBic
        {
            get { return FindElement(By.Id("input-account-swift")); }
        }

        public NgWebElement BtnSave
        {
            get { return FindElement(By.Id("create-detail-btn")); }
        }

        public NgWebElement LnkBack
        {
            get { return FindElement(By.Id("back-link")); }
        }
    }
}
