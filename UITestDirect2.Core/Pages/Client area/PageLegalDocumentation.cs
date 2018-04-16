using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageLegalDocumentation : PageCommon
    {
        public PageLegalDocumentation(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/profile/downloads/legal-documentation";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\LegalDocumentation.jpg"; }
        }

        public NgWebElement BtnClientAgreement 
        {
            get { return FindElements(By.CssSelector("a.btn.btn-green"))[0]; }
        }

        public NgWebElement BtnClientAgreementAr
        {
            get { return FindElements(By.CssSelector("a.btn.btn-green"))[1]; }
        }

        public NgWebElement BtnComplaintsHandlingProcedure
        {
            get { return FindElements(By.CssSelector("a.btn.btn-green"))[2]; }
        }

        public NgWebElement BtnOrderExecutionPolicy
        {
            get { return FindElements(By.CssSelector("a.btn.btn-green"))[3]; }
        }

        public NgWebElement BtnOrderExecutionPolicyAr
        {
            get { return FindElements(By.CssSelector("a.btn.btn-green"))[4]; }
        }

        public NgWebElement BtnClientCategorisationNotice
        {
            get { return FindElements(By.CssSelector("a.btn.btn-green"))[5]; }
        }

        public NgWebElement BtnConflictsOfInterestPolicy 
        {
            get { return FindElements(By.CssSelector("a.btn.btn-green"))[6]; }
        }

        public NgWebElement BtnFxProWallet 
        {
            get { return FindElements(By.CssSelector("a.btn.btn-green"))[7]; }
        }

        public NgWebElement BtnRiskDisclosure 
        {
            get { return FindElements(By.CssSelector("a.btn.btn-green"))[8]; }
        }

        public NgWebElement BtnRiskDisclosureAr
        {
            get { return FindElements(By.CssSelector("a.btn.btn-green"))[9]; }
        }

        public NgWebElement BtnRetailRiskDisclosure
        {
            get { return FindElements(By.CssSelector("a.btn.btn-green"))[10]; }
        }

        public NgWebElement BtnTermsAndConditionsForFixedSpreadAccount 
        {
            get { return FindElements(By.CssSelector("a.btn.btn-green"))[11]; }
        }
    }
}
