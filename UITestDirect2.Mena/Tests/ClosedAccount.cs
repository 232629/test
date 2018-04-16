using NUnit.Framework;
using UITestDirect2.Core.Helpers;
using UITestDirect2.Core.Pages.Client_area;
using UITestDirect2.Core.Pages.Registration;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Mena
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="header"></param>
        /// <param name="msg"></param>
        /// <param name="lng"></param>
        [Test]
        [TestCase("auto205126@test.test", @"Failed Appropriateness", @"Based on the results of your appropriateness test, your knowledge and experience of the financial markets may mean that online trading is not suitable for you. As such, we cannot proceed with your application at this moment. A member of our Back Office Department will contact you soon to discuss the options available to you.", "en")]
        [TestCase("auto394488@test.test", @"Account Closed", @"We received your request to close your trading account. Should you have any questions, please contact our Back Office Department at backoffice@fxpro.ae", "en")]
        [TestCase("auto658776@test.test", @"Account Terminated", @"Your trading account has been terminated. Should you have any questions, please contact our Back Office Department at backoffice@fxpro.ae", "en")]
        public void ClosedAccount(string login, string header, string msg, string lng)
        {
            #region Test Data 

            #endregion

            LoginHelper.Login(ngWebDriver, lng, login, "Password1");

            PageClosedAccount pageClosedAccount = new PageClosedAccount(ngWebDriver, lng);
            pageClosedAccount.WaitLoadPage(pageClosedAccount);
            Assert.AreEqual(header, pageClosedAccount.LblHader.Text);
            Assert.AreEqual(msg, pageClosedAccount.LblBody.Text);
            pageClosedAccount.LnkLogout.Click();

            PageAfterLogout pageAfterLogout = new PageAfterLogout(ngWebDriver, lng);
            pageAfterLogout.WaitLoadPage(pageAfterLogout, 1000);

        }
    }
}
