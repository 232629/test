using OpenQA.Selenium;
using Protractor;
using UITestDirect2.Core.CustomElements;

namespace UITestDirect2.Core.Pages.Registration
{
    public class PageRregisterStep3 : PageBase
    {
        public PageRregisterStep3(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/register/step3";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\registerStep3.jpg"; }
        }

        public NgCustomSelectElement CmbAccountType
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-account-type")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbLeverage
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-leverage")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbCurrencyBase
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-currency-base")), NgWebDriver); }
        }

        public NgWebElement BtnVerifyYourProfileYes
        {
            get { return FindElement(By.Id("label-verify_profile-yes")); }
        }
        public NgWebElement BtnVerifyYourProfileNo
        {
            get { return FindElement(By.Id("label-verify_profile-no")); }
        }

        public NgCustomCheckboxElement ChkReceiveCompanyNews
        {
            get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=subscription-news]"))); }
        }

        public NgCustomCheckboxElement ChkReceiveTechnicalAnalysis
        {
            get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=subscription-analysis]"))); }
        }

        public NgCustomSelectElement CmbLanguage
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-preferred-language")), NgWebDriver); }
        }

        public NgCustomCheckboxElement ChkAcceptRisks
        {
            get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=risk-aware]"))); }
        }
        public NgWebElement LblSubmissionRiskAwareness
        {
            get { return FindElement(By.CssSelector("label#label-risk-aware>span.custom-control-description")); }
        }

        public NgCustomCheckboxElement ChkClientAgreement
        {
            get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=terms-conditions]"))); }
        }
        public NgWebElement LblSubmissionTermsConditions
        {
            get { return FindElement(By.CssSelector("label#label-terms-conditions>span.custom-control-description")); }
        }

        public NgWebElement BtnPreviousStep
        {
            get { return FindElement(By.Id("back-step-4")); }
        }

        public NgWebElement BtnComplete
        {
            get { return FindElement(By.Id("submit-step-4")); }
        }

    }
}
