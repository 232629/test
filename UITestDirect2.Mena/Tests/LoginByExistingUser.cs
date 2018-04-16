using NUnit.Framework;
using UITestDirect2.Core.Helpers;
using UITestDirect2.Core.Pages.Registration;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Mena
    {
        /// <summary>
        /// Логин известным пользователем.
        /// 
        ///Сценарий: 
        ///1. Логинимся с не верным паролем.
        ///2. Логинимся с верным паролем.
        /// </summary>
        [Test]
        [Ignore("wait fast reg")]
        [TestCase("en")]
        [TestCase("ar")]
        public void LoginByExistingUser(string lng)
        {
            #region Test Data

            var login = "1111111@testing.test";
            var badPass = "111";

            #endregion

            PageLogin pageLogin = new PageLogin(ngWebDriver, lng);
            pageLogin.GoToPage(pageLogin.ExpectedUrl);
            Assert.AreEqual(pageLogin.ExpectedUrl, ngWebDriver.Url);
            //ввод не правильного пароля
            pageLogin.TxtEmail.SendKeys(login);
            pageLogin.TxtPassword.SendKeys(badPass);
            pageLogin.BtnLogin.Click();
            //Проверить сообщение невалидного пароля
            Assert.AreEqual(@"Login faild. Check your email and password", pageLogin.MsgError.Text);

            //ввод правильного пароля
            LoginHelper.Login(ngWebDriver, lng);

        }
    }
}
