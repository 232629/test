using FluentAssertions;
using NUnit.Framework;
using UITestDirect2.Core.Helpers;
using UITestDirect2.Core.Pages.Client_area;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Mena
    {
        [Test]
        //[Ignore("wait fast reg")]
        [TestCase("en")]
        public void MakeDepositIngenico(string lng)
        {
            #region Test Data 

            string login = "875584@testing.test";
            string pas = "Password1";
            var currencies = new[] {"EUR", "GBP", "USD"};

            #endregion

            //Create user with account currency = 'currency'
            LoginHelper.Login(ngWebDriver, lng, login, pas);

            PageTradingAccountsReal pageTradingAccountsReal = new PageTradingAccountsReal(ngWebDriver, lng);
            pageTradingAccountsReal.WaitLoadPage(pageTradingAccountsReal);
            pageTradingAccountsReal.BtnMakeFirstDeposit.Click();
            
            PageDeposit pageDeposit = new PageDeposit(ngWebDriver, lng);
            pageDeposit.WaitLoadPage(pageDeposit);

            pageDeposit.BtnIngenico.Click();
            
            PageDepositIngenico pageDepositIngenico = new PageDepositIngenico(ngWebDriver, lng);
            pageDepositIngenico.WaitLoadPage(pageDepositIngenico);

            Assert.AreEqual("The minimum deposit accepted depends on the currency selected.\r\nThe maximum deposit accepted depends on the currency selected.", pageDepositIngenico.LblLimitation.Text);
            pageDepositIngenico.CmbCurrency.GetValuesList().Should().BeEquivalentTo(currencies);

            foreach (var currency in currencies)
            {
                pageDepositIngenico.CmbCurrency.SetValueAfterClick(currency);
                Assert.AreEqual("The minimum deposit amount accepted is 100 "+ currency + ".\r\nThe maximum deposit amount accepted is 10000 " + currency + ".", pageDepositIngenico.LblLimitation.Text);
            }

            pageDepositIngenico.BtnDeposit.Click();
            //redirect to Ingenico
        }
    }
}
