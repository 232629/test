using NUnit.Framework;
using UITestDirect2.Core.Pages.Registration;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Uk
    {
        /// <summary>
        /// Test
        /// </summary>
        [Test]
        [Ignore("for testing")]
        [TestCase("en")]
        public void Test(string lng)
        {
            #region Test Data

            var login = "aa@aa.aa";

            #endregion

            PageLogin pageLogin = new PageLogin(ngWebDriver, lng);
            pageLogin.GoToPage(pageLogin.ExpectedUrl);
            pageLogin.WaitLoadPage(pageLogin);


            pageLogin.LnkCreateAnAccount.Click();

            PageRegister pageRegister = new PageRegister(ngWebDriver, lng);
            pageRegister.WaitLoadPage(pageRegister);



        }

    }
}
