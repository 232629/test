using OpenQA.Selenium;
using Protractor;
using UITestDirect2.Core.CustomElements;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageCreateDemoAccount : PageCommon
    {
        public PageCreateDemoAccount(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/accounts/demo/create";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\AccountsDemoCreate.jpg"; }
        }

        public NgCustomSelectElement CmbSelectAccountType
        {
            get { return new NgCustomSelectElement(FindElement(By.CssSelector("ng-select#select-account-type")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbSelectLeverage
        {
            get { return new NgCustomSelectElement(FindElement(By.CssSelector("ng-select#select-leverage")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbSelectCurrencyBase
        {
            get { return new NgCustomSelectElement(FindElement(By.CssSelector("ng-select#select-currency-base")), NgWebDriver); }
        }

        public NgWebElement TxtAmount
        {
            get { return FindElement(By.Id("amount")); }
        }

        public NgWebElement BtnCreate
        {
            get { return FindElement(By.CssSelector("button.btn-green.arrow.btn")); }
        }

        public NgWebElement LnkBack
        {
            get { return FindElement(By.LinkText("Back")); }
        }

    }
}
