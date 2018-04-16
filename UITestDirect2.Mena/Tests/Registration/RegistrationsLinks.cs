using System;
using NUnit.Framework;
using UITestDirect2.Core.Helpers;
using UITestDirect2.Core.Infrastructure;
using UITestDirect2.Core.Pages.Registration;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Mena
    {
        /// <summary>
        /// All links for unregistered user must redirect /registration/step1 (except /registration/login)
        /// </summary>
        [Test]
        [TestCase("en")]
        [TestCase("ar")]
        [Description(@"All links for unregistered user must redirect /registration/step1 (except /registration/login)")]
        public void RegistrationsLinks(string lng)
        {
            #region Test Data
            var randomPart = RegistrationHelper.GetRandomNumberPhone(new Random(), 6);

            DataStep0 dataStep0 = new DataStep0();
            dataStep0.TxtEmail = randomPart + "@testing.test";
            Log.Info("Email new user = " + dataStep0.TxtEmail);
            dataStep0.TxtPassword = "Password1";
            Log.Info("Password new user = " + dataStep0.TxtPassword);
            dataStep0.TxtFirstName = "TestNameUAE";
            dataStep0.TxtLastName = "TestLastNameUAE";
            dataStep0.CmbCountry = "United Arab Emirates";
            dataStep0.BtnNexStep = true;
            #endregion

            //Before fill step 0

            //login
            PageLogin pageLogin = new PageLogin(ngWebDriver, lng);
            pageLogin.GoToPage(pageLogin.ExpectedUrl);
            pageLogin.WaitLoadPage(pageLogin);
            
            //register step 0
            PageRegister pageRegister = new PageRegister(ngWebDriver, lng);
            pageRegister.GoToPage(pageRegister.ExpectedUrl);
            pageRegister.WaitLoadPage(pageRegister);

            //register step 1
            PageRregisterStep1 pageRregisterStep1 = new PageRregisterStep1(ngWebDriver, lng);
            pageRregisterStep1.GoToPage(pageRregisterStep1.ExpectedUrl);
            pageRregisterStep1.WaitLoadPage(pageRegister, 1000);

            //register step 2
            PageRregisterStep2 pageRregisterStep2 = new PageRregisterStep2(ngWebDriver, lng);
            pageRregisterStep2.GoToPage(pageRregisterStep2.ExpectedUrl);
            pageRregisterStep2.WaitLoadPage(pageRegister, 1000);

            //register step 3
            PageRregisterStep3 pageRregisterStep3 = new PageRregisterStep3(ngWebDriver, lng);
            pageRregisterStep3.GoToPage(pageRregisterStep3.ExpectedUrl);
            pageRregisterStep3.WaitLoadPage(pageRegister, 1000);

            //redirect /register/thankyou to pageLogin
            PageThankYou pageThankYou = new PageThankYou(ngWebDriver, lng);
            pageThankYou.GoToPage(pageThankYou.ExpectedUrl);
            pageThankYou.WaitLoadPage(pageRegister, 1000);


            //After fill step 0 (page pageRegister not available)
            //login
            pageLogin.GoToPage(pageLogin.ExpectedUrl);
            pageLogin.WaitLoadPage(pageLogin);
            pageLogin.LnkCreateAnAccount.Click();
            pageRegister.WaitLoadPage(pageRegister);

            //Registration Step 0
            RegistrationHelper.RegistrationStep0(ngWebDriver, dataStep0, lng);
            pageRregisterStep1.WaitLoadPage(pageRregisterStep1);

            //register step 0
            pageRegister.GoToPage(pageRegister.ExpectedUrl);
            pageRegister.WaitLoadPage(pageRregisterStep1, 1000);

            //register step 1
            pageRregisterStep1.GoToPage(pageRregisterStep1.ExpectedUrl);
            pageRregisterStep1.WaitLoadPage(pageRregisterStep1);

            //register step 2
            pageRregisterStep2.GoToPage(pageRregisterStep2.ExpectedUrl);
            pageRregisterStep2.WaitLoadPage(pageRregisterStep1, 1000);

            //register step 3
            pageRregisterStep3.GoToPage(pageRregisterStep3.ExpectedUrl);
            pageRregisterStep3.WaitLoadPage(pageRregisterStep1, 1000);

            //redirect /register/thankyou to register/step1
            pageThankYou.WaitLoadPage(pageRregisterStep1);

        }
    }
}
