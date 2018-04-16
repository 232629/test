using OpenQA.Selenium;
using Protractor;
using UITestDirect2.Core.CustomElements;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageDepositCard : PageCommon
    {
        public PageDepositCard(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/transactions/deposit/card";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\TransactionsDepositCard.jpg"; }
        }

        public NgCustomSelectElement CmbTradingAccountNumber
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("account-number")), NgWebDriver); }
        }

        public NgWebElement BtnHint
        {
            get { return FindElement(By.Id("dropdownMenuButton")); }
        }
        
        public NgWebElement TxtCardNumber
        {
            get { return FindElement(By.Id("card-number")); }
        }

        public NgWebElement TxtCardName
        {
            get { return FindElement(By.Id("card-name")); }
        }

        public NgCustomSelectElement CmbMonth
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("expiry-month")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbYear
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("expiry-year")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbCountry
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-country")), NgWebDriver); }
        }

        public NgWebElement TxtAmount
        {
            get { return FindElement(By.Id("amount")); }
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
