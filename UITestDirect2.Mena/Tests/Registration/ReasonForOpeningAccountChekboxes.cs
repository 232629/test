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
        /// Steps3
        /// What is the reason you want to open an account with FxPro?
        /// </summary>
        [Test]
        [TestCase("en")]
        [Description("")]
        public void ReasonForOpeningAccountChekboxes(string lng)
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

            DataStep1 dataStep1 = new DataStep1();
            dataStep1.TxtAddress = "Al Safa Street 1";
            dataStep1.TxtCity = "Dubai";
            dataStep1.CmbEmirate = "Dubai";
            dataStep1.TxtBirthdate = "01/01/1990";
            dataStep1.TxtPhone = "971500000000";
            dataStep1.CmbNationality = "United Arab Emirates";
            dataStep1.BtnNexStep = true;

            #endregion

            //Login page
            PageLogin pageLogin = new PageLogin(ngWebDriver, lng);
            pageLogin.GoToPage(pageLogin.ExpectedUrl);
            Assert.AreEqual(pageLogin.ExpectedUrl, ngWebDriver.Url);
            pageLogin.LnkCreateAnAccount.Click();
            ngWebDriver.WaitForAngular();

            //Регистрация Шаг0
            RegistrationHelper.RegistrationStep0(ngWebDriver, dataStep0, lng);

            //Registration Step 1
            RegistrationHelper.RegistrationStep1(ngWebDriver, dataStep1, lng);

            //Registration Step 2
            PageRregisterStep2 pageRregisterStep2 = new PageRregisterStep2(ngWebDriver, lng);
            Assert.AreEqual(pageRregisterStep2.ExpectedUrl, ngWebDriver.Url); ;

            //What is the reason you want to open an account with FxPro?
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDs.Selected);
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDsOnForex.Selected);
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDsOnShares.Selected);
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDsOnIndices.Selected);

            pageRregisterStep2.ChkToTradeCFDs.Click();
            Assert.IsTrue(pageRregisterStep2.ChkToTradeCFDs.Selected);
            Assert.IsTrue(pageRregisterStep2.ChkToTradeCFDsOnForex.Selected);
            Assert.IsTrue(pageRregisterStep2.ChkToTradeCFDsOnShares.Selected);
            Assert.IsTrue(pageRregisterStep2.ChkToTradeCFDsOnIndices.Selected);

            pageRregisterStep2.ChkToTradeCFDs.Click();
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDs.Selected);
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDsOnForex.Selected);
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDsOnShares.Selected);
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDsOnIndices.Selected);

            pageRregisterStep2.ChkToTradeCFDsOnForex.Click();
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDs.Selected);
            Assert.IsTrue(pageRregisterStep2.ChkToTradeCFDsOnForex.Selected);
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDsOnShares.Selected);
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDsOnIndices.Selected);

            pageRregisterStep2.ChkToTradeCFDsOnShares.Click();
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDs.Selected);
            Assert.IsTrue(pageRregisterStep2.ChkToTradeCFDsOnForex.Selected);
            Assert.IsTrue(pageRregisterStep2.ChkToTradeCFDsOnShares.Selected);
            Assert.IsFalse(pageRregisterStep2.ChkToTradeCFDsOnIndices.Selected);

            pageRregisterStep2.ChkToTradeCFDsOnIndices.Click();
            Assert.IsTrue(pageRregisterStep2.ChkToTradeCFDs.Selected);
            Assert.IsTrue(pageRregisterStep2.ChkToTradeCFDsOnForex.Selected);
            Assert.IsTrue(pageRregisterStep2.ChkToTradeCFDsOnShares.Selected);
            Assert.IsTrue(pageRregisterStep2.ChkToTradeCFDsOnIndices.Selected);
        }
    }
}
