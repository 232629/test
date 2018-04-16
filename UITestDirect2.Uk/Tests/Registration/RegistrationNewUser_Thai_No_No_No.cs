using System;
using NUnit.Framework;
using UITestDirect2.Core.Helpers;
using UITestDirect2.Core.Infrastructure;
using UITestDirect2.Core.Pages.Client_area;
using UITestDirect2.Core.Pages.Registration;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Uk
    {
        /// <summary>
        /// Registration new Thai user
        /// 
        /// 0 step: 
        /// Country > United Arab Emirates
        /// 1 step:
        /// 2 step:
        /// Do you have trading experience? > No
        /// 3 step:
        /// Verify your profile now? > No
        /// </summary>  
        [Test]
        //[Retry(3)]
        [TestCase("en")]
        [Description(
            "1 step: Country > UnitedArabEmirates \n\r2 step: \n\r3 step: Do you have trading experience? > No \n\r4 step: Verify your profile now? > No")]
        public void RegistrationNewUser_Thai_No_No(string lng)
        {
            #region Test Data

            var randomPart = RegistrationHelper.GetRandomNumberPhone(new Random(), 6);

            DataStep0 dataStep0 = new DataStep0();
            dataStep0.TxtEmail = randomPart + "@testing.test";
            Log.Info("Email new user = " + dataStep0.TxtEmail);
            dataStep0.TxtPassword = "Password1";
            Log.Info("Password new user = " + dataStep0.TxtPassword);
            dataStep0.TxtFirstName = "TestNameThailand";
            dataStep0.TxtLastName = "TestLastNameThailand";
            dataStep0.CmbCountry = "Thailand";
            dataStep0.BtnNexStep = true;

            DataStep1 dataStep1 = new DataStep1();
            dataStep1.TxtAddress = "Walking Street 1";
            dataStep1.TxtPostcode = "1234567890";
            dataStep1.TxtCity = "Muang Pattaya";
            dataStep1.TxtBirthdate = "01/01/1990";
            dataStep1.TxtPhone = "66000000000";
            dataStep1.CmbNationality = "Thailand";
            dataStep1.BtnNexStep = true;

            DataStep2 dataStep2 = new DataStep2();
            //Employment Information
            dataStep2.CmbEmployment = "Employed";
            dataStep2.CmbEmploymentType = "Financial Services";
            dataStep2.CmbLevelOfEducation = "High School";
            //Financial Information
            dataStep2.CmbAnnualIncome = "> $1,000,000";
            dataStep2.CmbEstimatedNetWorth = "$1,000,000 – $5,000,000";
            dataStep2.CmbSourceOfIncome = "Savings / Investments";
            dataStep2.CmbDeposit = "> $1,000,000";
            dataStep2.ChkToTradeCFDs = true;
            //Trading Experience
            dataStep2.CmbTradingExperience = "No";
                dataStep2.ChkHaveRelevantEducational = true;
                dataStep2.ChkIRegularlyMonitorNews = true;
                dataStep2.ChkIHaveReadMaterialOnTrading = true;

            dataStep2.BtnNexStep = true;

            DataStep3 dataStep3 = new DataStep3();
            dataStep3.CmbAccountType = "MT5";
            dataStep3.CmbLeverage = "1:50";
            dataStep3.CmbCurrencyBase = "EUR";
            dataStep3.BtnVerifyYourProfileNo = true;
            dataStep3.ChkReceiveCompanyNews = true;
            dataStep3.ChkReceiveTechnicalAnalysis = true;
            dataStep3.ChkAcceptRisks = true;
            dataStep3.CmbLanguage = "English";
            dataStep3.ChkClientAgreement = true;
            dataStep3.BtnComplete = true;

            #endregion

            //Login page
            PageLogin pageLogin = new PageLogin(ngWebDriver, lng);
            pageLogin.GoToPage(pageLogin.ExpectedUrl);
            Assert.AreEqual(pageLogin.ExpectedUrl, ngWebDriver.Url);
            pageLogin.LnkCreateAnAccount.Click();
            ngWebDriver.WaitForAngular();

            //Registration Step 0
            RegistrationHelper.RegistrationStep0(ngWebDriver, dataStep0, lng);

            //Registration Step 1
            RegistrationHelper.RegistrationStep1(ngWebDriver, dataStep1, lng);

            //Registration Step 2
            RegistrationHelper.RegistrationStep2(ngWebDriver, dataStep2, lng);

            //Registration Step 3
            RegistrationHelper.RegistrationStep3(ngWebDriver, dataStep3, lng);

            PageTradingAccountsReal pageTradingAccountsReal = new PageTradingAccountsReal(ngWebDriver, lng);
            pageTradingAccountsReal.WaitLoadPage(pageTradingAccountsReal);

        }
    }
}
