using NUnit.Framework;
using UITestDirect2.Core.Helpers;
using UITestDirect2.Core.Pages.Client_area;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Mena
    {
        [Test]
        [TestCase("EUR", "en")]
        [TestCase("USD", "en")]
        [TestCase("GBP", "en")]
        public void BankTransferDeposit(string currency, string lng)
        {
            #region Test Data 

            #endregion

            //Create user with account currency = 'currency'
            LoginHelper.Login(ngWebDriver, lng);

            PageTradingAccountsReal pageTradingAccountsReal = new PageTradingAccountsReal(ngWebDriver, lng);
            pageTradingAccountsReal.WaitLoadPage(pageTradingAccountsReal);
            pageTradingAccountsReal.BtnQuickDeposit.Click();
            
            PageDeposit pageDeposit = new PageDeposit(ngWebDriver, lng);
            pageDeposit.WaitLoadPage(pageDeposit);
            pageDeposit.BtnBankwire.Click();

            PageDepositBankWire pageDepositBankWire = new PageDepositBankWire(ngWebDriver, lng);
            pageDepositBankWire.WaitLoadPage(pageDepositBankWire);
            pageDepositBankWire.CmbAccountNumber.SetValueAfterClick(0);
            pageDepositBankWire.CmbBank.SetValueAfterClick(0);
            pageDepositBankWire.CmbCurrency.SetValueAfterClick(currency);
            pageDepositBankWire.BtnGetTransferDetails.Click();

            PageTransferInstructions pageTransferInstructions = new PageTransferInstructions(ngWebDriver, lng);
            pageTransferInstructions.WaitLoadPage(pageTransferInstructions);
            
            Assert.AreEqual("Beneficiary name", pageTransferInstructions.LblName(0).Text);
            Assert.AreEqual("Benificiary bank name", pageTransferInstructions.LblName(1).Text);
            Assert.AreEqual("Bank address", pageTransferInstructions.LblName(2).Text);
            Assert.AreEqual("SWIFT/BIC", pageTransferInstructions.LblName(3).Text);
            Assert.AreEqual("IBAN", pageTransferInstructions.LblName(4).Text);
            Assert.AreEqual("Payment details", pageTransferInstructions.LblName(5).Text);
            Assert.AreEqual("Currency", pageTransferInstructions.LblName(6).Text);

            Assert.AreEqual("FxPro Global Markets MENA Limited", pageTransferInstructions.LblValue(0).Text);
            Assert.AreEqual("Emirates NBD", pageTransferInstructions.LblValue(1).Text);
            Assert.AreEqual("P.O. Box 777 Baniyas Road, Dubai United Arab Emirates", pageTransferInstructions.LblValue(2).Text);
            Assert.AreEqual("EBILAEADXXX", pageTransferInstructions.LblValue(3).Text);
            Assert.IsTrue(pageTransferInstructions.LblValue(5).Text.Contains("FXPRO WALLET NUMBER:"));
            Assert.AreEqual(currency, pageTransferInstructions.LblValue(6).Text);

        }
    }
}
