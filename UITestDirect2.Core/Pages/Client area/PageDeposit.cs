using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageDeposit : PageCommon
    {
        public PageDeposit(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/wallet/deposit";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\WalletDeposit.jpg"; }
        }

        //public NgWebElement BtnFundingMethod(int i)
        //{
        //    return FindElements(By.CssSelector("a.method.deposit-row"))[i];
        //}

        public NgWebElement BtnBankwire
        {
            get {
                foreach (var btn in FindElements(By.CssSelector("a.method.deposit-row")))
                {
                    if (btn.GetAttribute("href").Contains("bankwire"))
                        return btn;
                }
                return null;
            }
        }

        public NgWebElement BtnIngenico
        {
            get
            {
                foreach (var btn in FindElements(By.CssSelector("a.method.deposit-row")))
                {
                    if (btn.GetAttribute("href").Contains("ingenico"))
                        return btn;
                }
                return null;
            }
        }

    }
}
