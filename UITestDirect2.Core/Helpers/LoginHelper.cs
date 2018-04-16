using System;
using NUnit.Framework;
using Protractor;
using UITestDirect2.Core.Infrastructure;
using UITestDirect2.Core.Pages.Registration;

namespace UITestDirect2.Core.Helpers
{
    public static class LoginHelper
    {
        public static void Login(NgWebDriver ngWebDriver, string lng, string login = null, string pass = null)
        {
            if (login == null)
            {
                login = "fst" + RegistrationHelper.GetRandomNumberPhone(new Random(), 7) + "@testing.test";
                Log.Info("Email new user = " + login);
                pass = "Password1";
                Log.Info("Password new user = " + pass);
                APIHelper.CreateNewUser(login, pass);
            }

            PageLogin pageLogin = new PageLogin(ngWebDriver, lng);
            pageLogin.GoToPage(pageLogin.ExpectedUrl);
            pageLogin.WaitLoadPage(pageLogin);

            pageLogin.TxtEmail.Clear();
            pageLogin.TxtEmail.SendKeys(login);
            pageLogin.TxtPassword.Clear();
            pageLogin.TxtPassword.SendKeys(pass);
            pageLogin.ChkStaySignedIn.Click();
            System.Threading.Thread.Sleep(3000);            //bad decision
            pageLogin.BtnLogin.Click();           

        }

    }

}
       

