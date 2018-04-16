using OpenQA.Selenium;
using Protractor;
using UITestDirect2.Core.CustomElements;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageCreateRealAccount : PageCommon
    {
        public PageCreateRealAccount(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/accounts/real/create";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\AccountsRealCreate.jpg"; }
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

        public NgCustomSelectElement CmbSelectPartnership
        {
            get { return new NgCustomSelectElement(FindElement(By.CssSelector("ng-select#select-partnership")), NgWebDriver); }
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
