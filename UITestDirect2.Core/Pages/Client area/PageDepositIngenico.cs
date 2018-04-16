using OpenQA.Selenium;
using Protractor;
using UITestDirect2.Core.CustomElements;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageDepositIngenico : PageCommon
    {
        public PageDepositIngenico(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/wallet/deposit/ingenico";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\WalletDepositIngenico.jpg"; }
        }

        public NgCustomSelectElement CmbTradingAccountNumber
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("account-number")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbCountry
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-country")), NgWebDriver); }
        }

        public NgWebElement TxtAmount
        {
            get { return FindElement(By.Id("amount")); }
        }

        public NgWebElement LblLimitation
        {
            get { return FindElement(By.CssSelector("label.popular-amount")); }
        }

        public NgCustomSelectElement CmbCurrency
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("currency")), NgWebDriver); }
        }

        public NgWebElement BtnDeposit
        {
            get { return FindElement(By.Id("deposit-submit")); }
        }

        public NgWebElement LnkBack
        {
            get { return FindElement(By.Id("back-link")); }
        }
    }
}
