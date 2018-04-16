using NUnit.Framework;
using UITestDirect2.Core.Pages.Registration;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Mena
    {
        /// <summary>
        /// Восстановление пароля.
        /// 
        ///Сценарий: 
        ///1. Запрашиваем код восстановления сщвестным пользователем.
        ///2. Проверяем пришедший код.
        /// </summary>
        [Test]
        [Ignore("not finished")]
        [TestCase("en")]
        public void FogotPassword(string lng)
        {
            #region Test Data

            var login = "aa@aa.aa";

            #endregion

            PageLogin pageLogin = new PageLogin(ngWebDriver, lng);
            pageLogin.GoToPage(pageLogin.ExpectedUrl);
            pageLogin.WaitLoadPage(pageLogin);
            Assert.AreEqual(pageLogin.ExpectedUrl, ngWebDriver.Url);
            //AssertHelper.AssertScreenShot(webDriver, pageLogin.ScreenShot, 0);
            pageLogin.LnkFogotPassword.Click();


            PageFogetPassword pageFogetPassword = new PageFogetPassword(ngWebDriver, lng);
            pageFogetPassword.WaitLoadPage(pageFogetPassword);
            Assert.AreEqual(pageFogetPassword.ExpectedUrl, ngWebDriver.Url);
            //AssertHelper.AssertScreenShot(webDriver, pageFogetPassword.ScreenShot, 0);
            pageFogetPassword.TxtEmail.SendKeys(login);
            pageFogetPassword.BtnResetPassword.Click();

            PageActivationCode pageActivationCode = new PageActivationCode(ngWebDriver, lng);
            pageActivationCode.WaitLoadPage(pageActivationCode);
            Assert.AreEqual(pageActivationCode.ExpectedUrl, ngWebDriver.Url);
            //AssertHelper.AssertScreenShot(webDriver, pageActivationCode.ScreenShot, 0);
            pageActivationCode.TxtActivationCode.SendKeys("666");
            pageActivationCode.BtnSend.Click();
            pageActivationCode.BtnClose.Click();

            pageLogin.WaitLoadPage(pageLogin);
            Assert.AreEqual(pageLogin.ExpectedUrl, ngWebDriver.Url);

        }

    }
}
