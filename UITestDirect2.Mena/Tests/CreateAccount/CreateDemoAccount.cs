using System.Threading;
using NUnit.Framework;
using UITestDirect2.Core.Helpers;
using UITestDirect2.Core.Pages.Client_area;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Mena
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountType"></param>
        /// <param name="lng"></param>
        [Test]
        [TestCase("MT4", "en")]
        [TestCase("MT5", "en")]
        [TestCase("cTrader", "en")]
        public void CreateDemoAccount(string accountType, string lng)
        {
            #region Test Data 

            #endregion

            LoginHelper.Login(ngWebDriver, lng);

            PageTradingAccountsReal pageTradingAccountsReal = new PageTradingAccountsReal(ngWebDriver, lng);
            pageTradingAccountsReal.WaitLoadPage(pageTradingAccountsReal);

            PageTradingAccountsDemo pageTradingAccountsDemo = new PageTradingAccountsDemo(ngWebDriver, lng);

            pageTradingAccountsDemo.LnkDemoAccounts.Click();
            pageTradingAccountsDemo.LnkCreateNewAccount.Click();
            PageCreateDemoAccount pageCreateDemoAccount = new PageCreateDemoAccount(ngWebDriver, lng);
            pageCreateDemoAccount.WaitLoadPage(pageCreateDemoAccount);

            //take is count Account Currency Base
            pageCreateDemoAccount.CmbSelectAccountType.SetValueAfterClick(accountType);
            var countCurrency =  pageCreateDemoAccount.CmbSelectCurrencyBase.Count();
            pageCreateDemoAccount.LnkBack.Click();

            for (int i = 0; i < countCurrency; i++)
            {
                pageTradingAccountsDemo.LnkCreateNewAccount.Click();
                pageCreateDemoAccount.WaitLoadPage(pageCreateDemoAccount);
                pageCreateDemoAccount.CmbSelectAccountType.SetValueAfterClick(accountType);
                pageCreateDemoAccount.CmbSelectLeverage.SetValueAfterClick(0);
                pageCreateDemoAccount.CmbSelectCurrencyBase.SetValueAfterClick(i);
                pageCreateDemoAccount.TxtAmount.SendKeys("1000");
                pageCreateDemoAccount.BtnCreate.Click();
                pageCreateDemoAccount.WaitLoadPage(pageTradingAccountsDemo);
                Thread.Sleep(3000);
            }
        }
    }
}
