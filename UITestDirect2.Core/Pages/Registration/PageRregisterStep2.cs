using System.Threading;
using OpenQA.Selenium;
using Protractor;
using UITestDirect2.Core.CustomElements;

namespace UITestDirect2.Core.Pages.Registration
{
    public class PageRregisterStep2 : PageBase
    {
        public PageRregisterStep2(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/register/step2";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\registerStep2.jpg"; }
        }

        public NgCustomSelectElement CmbEmployment
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-employment")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbEmploymentType
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-employment-type")), NgWebDriver); }
        }

            public NgWebElement TxtEmploymentOther
            {
                get { return FindElement(By.Id("input-employment-other")); }
            }

        public NgCustomSelectElement CmbLevelOfEducation
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-education-level")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbAnnualIncome
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-annual-income")), NgWebDriver); }
        }
        
        public NgCustomSelectElement CmbEstimatedNetWorth
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-estimated-worth")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbSourceOfIncome
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-income-source")), NgWebDriver); }
        }

            public NgWebElement TxtSourceOfIncomeOther
            {
                get { return FindElement(By.Id("input-income-source-other")); }
            }

        public NgCustomSelectElement CmbDeposit
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-anticipate-deposit")), NgWebDriver); }
        }

        public NgCustomCheckboxElement ChkToTradeCFDs
        {
            get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=join-reason-all]"))); }
        }

            public NgCustomCheckboxElement ChkToTradeCFDsOnForex
            {
                get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=join-reason-0]"))); }
            }
            public NgCustomCheckboxElement ChkToTradeCFDsOnShares
            {
                get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=join-reason-1]"))); }
            }
            public NgCustomCheckboxElement ChkToTradeCFDsOnIndices
            {
                get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=join-reason-2]"))); }
            }

        public NgWebElement BtnUScitizenYes
        {
            get { return FindElement(By.CssSelector("label#label-uscitizen-yes")); }
        }

        public NgWebElement TxtUsTaxCode
        {
            get { return FindElement(By.Id("input-us-tax-code")); }
        }

        public NgWebElement BtnUScitizenNo
        {
            get { return FindElement(By.CssSelector("label#label-uscitizen-no")); }
        }

        #region Trading Experience

        public NgCustomSelectElement CmbTradingExperience
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-trading-experience")), NgWebDriver); }
        }

            /// <summary>
            /// Yes, I have traded on a real account         
            /// </summary>
            public NgCustomSelectElement CmbExperience
            {
                get { return new NgCustomSelectElement(FindElement(By.Id("select-years-experience")), NgWebDriver); }
            }

            public NgCustomSelectElement CmbHowManyTimesYouTraded
            {
                get { return new NgCustomSelectElement(FindElement(By.Id("select-trades-last-year-quarter")), NgWebDriver); }
            }

            /// <summary>
            /// Yes, I have traded on a demo account
            /// </summary>        



            /// <summary>
            /// No
            /// </summary>
            public NgCustomCheckboxElement ChkHaveRelevantEducational
            {
                get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=knowledge-map-0]"))); }
            }

            public NgCustomCheckboxElement ChkIRegularlyMonitorNews
            {
                get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=knowledge-map-1]"))); }
            }

            public NgCustomCheckboxElement ChkIHaveReadMaterialOnTrading
            {
                get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=knowledge-map-2]"))); }
            }

            public NgCustomCheckboxElement ChkAllOfAbove
            {
                get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=knowledge-all]"))); }
            }

            public NgCustomCheckboxElement ChkNoneOfAbove
            {
                get { return new NgCustomCheckboxElement(FindElement(By.CssSelector("label.custom-checkbox[for=knowledge-none]"))); }
            }

        #endregion

        public NgCustomSelectElement CmbQuestion1
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-knowledge-1")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbQuestion2
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-knowledge-2")), NgWebDriver); }
        }

        public NgCustomSelectElement CmbQuestion3
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-knowledge-3")), NgWebDriver);}
        }

        #region If regulator = DFSA and Country = UAE and Net worth >= 1 000 000
        /// <summary>
        /// Fields ChkprofessionalClient use only for regulator DFSA 
        /// </summary>
        public NgWebElement ChkProfessionalClientYes
        {
            get { return FindElement(By.Id("label-professional-client-yes")); }
        }

        public NgWebElement ChkProfessionalClientNo
        {
            get { return FindElement(By.Id("label-professional-client-no")); }
        }

        /// <summary>
        /// Field CmbLeveragedProductExperience uses only for regulator DFSA
        /// </summary>
        public NgCustomSelectElement CmbLeveragedProductExperience
        {
            get { return new NgCustomSelectElement(FindElement(By.Id("select-leveragedProductExperience")), NgWebDriver); }
        }

        /// <summary>
        /// Field TxtLeveragedProductExperienceOther uses only for regulator DFSA
        /// </summary>
        public NgWebElement TxtLeveragedProductExperienceOther
        {
            get { return FindElement(By.Id("input-leveragedProductExperienceOther")); }
        }
        #endregion


        public NgWebElement BtnNexStep
        {
            get { return FindElement(By.Id("submit-step-3")); }
        }

        public NgWebElement BtnPreviousStep
        {
            get { return FindElement(By.Id("back-step-3")); }
        }

    }
}
