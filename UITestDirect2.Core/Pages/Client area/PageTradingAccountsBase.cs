using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public abstract class PageTradingAccountsBase : PageCommon
    {
        public PageTradingAccountsBase(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public NgWebElement LnkMyAccount
        {
            get { return FindElement(By.LinkText("My account")); }
        }

        public NgWebElement LnkManageFunds
        {
            get { return FindElement(By.LinkText("Manage funds")); }
        }

        public NgWebElement LnkPartners
        {
            get { return FindElement(By.LinkText("Partners")); }
        }

        public NgWebElement LnkTradingAccounts
        {
            get { return FindElement(By.LinkText("Trading Accounts")); }
        }

        public NgWebElement LnkDemoAccounts
        {
            get { return FindElement(By.LinkText("Demo Accounts")); }
        }

        public NgWebElement MsgSuccess
        {
            get { return FindElement(By.CssSelector("div.ui-messages.ui-widget.ui-corner-all.ui-messages-success")); }
        }
        
        public NgWebElement LnkCreateNewAccount
        {
            get { return FindElement(By.Id("create-account")); }
        }

        public NgWebElement BtnUploadYourDocuments
        {
            get { return FindElement(By.Id("upload-doc-btn")); }                             
        }

        public NgWebElement BtnCheckYourDocuments
        {
            get { return FindElement(By.Id("check-doc-btn")); }
        }

        public NgWebElement BtnMakeFirstDeposit
        {
            get { return FindElement(By.Id("make-deposit-btn")); }                            
        }

    }
}
