using OpenQA.Selenium;
using Protractor;
using UITestDirect2.Core.CustomElements;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageDepositBankWire : PageCommon
    {
        public PageDepositBankWire(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/wallet/deposit/bankwire";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\WalletDepositBankwire.jpg"; }
        }

        public NgCustomSelectElement CmbAccountNumber
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("account-number")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbCountry
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-country")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbBank
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-bank")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbCurrency
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("currency")), NgWebDriver); }
        }

        public NgWebElement BtnGetTransferDetails
        {
            get { return FindElement(By.Id("deposit-submit")); }
        }

        public NgWebElement LnkBack
        {
            get { return FindElement(By.Id("back-link")); }
        }
    }
}
