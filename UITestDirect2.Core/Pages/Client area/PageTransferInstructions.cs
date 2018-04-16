using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageTransferInstructions : PageCommon
    {
        public PageTransferInstructions(NgWebDriver driver, string lng = "en")
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
            get { return FolderExpectedScreenShots + "\\" + Language + "\\TransferInstructions.jpg"; }
        }

        public NgWebElement LblName(int i)
        {
            return FindElement(By.CssSelector("div.bankwire-receipt")).FindElements(By.TagName("dt"))[i];
        }

        public NgWebElement LblValue(int i)
        {
            return FindElement(By.CssSelector("div.bankwire-receipt")).FindElements(By.TagName("dd"))[i];
        }


        public NgWebElement BtnPrint
        {
            get { return FindElement(By.Id("print-btn")); }
        }

    }
}
