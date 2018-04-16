using NUnit.Framework;
using UITestDirect2.Core.Helpers;
using UITestDirect2.Core.Pages.Client_area;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Mena
    {
        [Test]
        [TestCase("en")]
        public void LegalDocumentation(string lng)
        {
            #region Test Data 

            #endregion

            //Create user 
            LoginHelper.Login(ngWebDriver, lng);

            PageTradingAccountsReal pageTradingAccountsReal = new PageTradingAccountsReal(ngWebDriver, lng);
            pageTradingAccountsReal.WaitLoadPage(pageTradingAccountsReal);
            pageTradingAccountsReal.BtnMenuProfile.Click();
            pageTradingAccountsReal.LnkMenuMyProfile.Click();
            
            PageProfile pageProfile = new PageProfile(ngWebDriver, lng);
            pageTradingAccountsReal.WaitLoadPage(pageProfile);
            pageProfile.LnkLegalDocumentation.Click();

            PageLegalDocumentation pageLegalDocumentation = new PageLegalDocumentation(ngWebDriver, lng);
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

            pageLegalDocumentation.BtnClientAgreement.Click();
            Assert.AreEqual(@"https://datarepo.fxpro.co.uk/legal/mena/Client_Agreement.pdf", ngWebDriver.WrappedDriver.Url);
            ngWebDriver.WrappedDriver.Navigate().Back();
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

            pageLegalDocumentation.BtnClientAgreementAr.Click();
            Assert.AreEqual(@"https://datarepo.fxpro.co.uk/legal/mena/Client_Agreement_ar.pdf", ngWebDriver.WrappedDriver.Url);
            ngWebDriver.WrappedDriver.Navigate().Back();
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

            pageLegalDocumentation.BtnComplaintsHandlingProcedure.Click();
            Assert.AreEqual(@"https://datarepo.fxpro.co.uk/legal/mena/Complaints_Handling_Procedure.pdf", ngWebDriver.WrappedDriver.Url);
            ngWebDriver.WrappedDriver.Navigate().Back();
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

            pageLegalDocumentation.BtnOrderExecutionPolicy.Click();
            Assert.AreEqual(@"https://datarepo.fxpro.co.uk/legal/mena/Order_Execution_Policy.pdf", ngWebDriver.WrappedDriver.Url);
            ngWebDriver.WrappedDriver.Navigate().Back();
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

            pageLegalDocumentation.BtnOrderExecutionPolicyAr.Click();
            Assert.AreEqual(@"https://datarepo.fxpro.co.uk/legal/mena/Order_Execution_Policy_ar.pdf", ngWebDriver.WrappedDriver.Url);
            ngWebDriver.WrappedDriver.Navigate().Back();
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

            pageLegalDocumentation.BtnClientCategorisationNotice.Click();
            Assert.AreEqual(@"https://datarepo.fxpro.co.uk/legal/mena/Client_Categorisation_Notice.pdf", ngWebDriver.WrappedDriver.Url);
            ngWebDriver.WrappedDriver.Navigate().Back();
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

            pageLegalDocumentation.BtnConflictsOfInterestPolicy.Click();
            Assert.AreEqual(@"https://datarepo.fxpro.co.uk/legal/mena/Conflict_of_Interest_Policy.pdf", ngWebDriver.WrappedDriver.Url);
            ngWebDriver.WrappedDriver.Navigate().Back();
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

            pageLegalDocumentation.BtnFxProWallet.Click();
            Assert.AreEqual(@"https://datarepo.fxpro.co.uk/legal/mena/FxPro_Wallet.pdf", ngWebDriver.WrappedDriver.Url);
            ngWebDriver.WrappedDriver.Navigate().Back();
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

            pageLegalDocumentation.BtnRiskDisclosure.Click();
            Assert.AreEqual(@"https://datarepo.fxpro.co.uk/legal/mena/Risk_Disclosure_Notice.pdf", ngWebDriver.WrappedDriver.Url);
            ngWebDriver.WrappedDriver.Navigate().Back();
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

            pageLegalDocumentation.BtnRiskDisclosureAr.Click();
            Assert.AreEqual(@"https://datarepo.fxpro.co.uk/legal/mena/Risk_Disclosure_Notice_ar.pdf", ngWebDriver.WrappedDriver.Url);
            ngWebDriver.WrappedDriver.Navigate().Back();
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

            pageLegalDocumentation.BtnRetailRiskDisclosure.Click();
            Assert.AreEqual(@"https://datarepo.fxpro.co.uk/legal/mena/Retail_FX_Risk_Disclosure_Statement.pdf", ngWebDriver.WrappedDriver.Url);
            ngWebDriver.WrappedDriver.Navigate().Back();
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

            pageLegalDocumentation.BtnTermsAndConditionsForFixedSpreadAccount.Click();
            Assert.AreEqual(@"https://datarepo.fxpro.co.uk/legal/mena/Terms_and_Conditions_for_Fixed_Spread_Account.pdf", ngWebDriver.WrappedDriver.Url);
            ngWebDriver.WrappedDriver.Navigate().Back();
            pageTradingAccountsReal.WaitLoadPage(pageLegalDocumentation);

        }
    }
}
