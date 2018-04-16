using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using FluentAssertions;
using NUnit.Framework;
using UITestDirect2.Core.Helpers;
using UITestDirect2.Core.Infrastructure;
using UITestDirect2.Core.Pages.Client_area;
using UITestDirect2.Core.Pages.Registration;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Mena
    {
        /// <summary>
        /// https://fxpropm.atlassian.net/wiki/spaces/DIR2/pages/138248431/Dummy+partnerships
        /// Registration new UAE user 
        /// 
        /// 0 step: 
        /// DFSA
        /// Country > United Arab Emirates
        /// 1 step:
        /// 2 step:
        /// Are you a US citizen or a US resident for tax purposes? > No
        /// Do you have trading experience? > No
        /// 3 step:
        /// Verify your profile now? > No
        /// </summary>
        [Test]
        //[Retry(3)]
        [TestCase("en")]
        [Description(
            "1 step: DFSA, Country > UnitedArabEmirates \n\r2 step: \n\r3 step: Are you a US citizen or a US resident for tax purposes? > No, Do you have trading experience? > No \n\r4 step: Verify your profile now? > No")]
        public void Partner_Arabia_No_No_No(string lng)
        {
            #region Test Data

            var goodPartner1Name = "good_partner1";
            var goodPartner1Id = "0808331";

            var goodPartner2Name = "good_partner2";
            var goodPartner2Id = "0808332";

            var goodPartner3MenaName = "good_partner3";
            var goodPartner3MenaId = "0808333";

            var goodPartner3GmName = "good_partner3";
            var goodPartner3GmId = "0808334";


            var randomPart = RegistrationHelper.GetRandomNumberPhone(new Random(), 6);
            
            DataStep0 dataStep0 = new DataStep0();
            dataStep0.TxtEmail = randomPart + "@testing.test";
            Log.Info("Email new user = " + dataStep0.TxtEmail);
            dataStep0.TxtPassword = "Password1";
            Log.Info("Password new user = " + dataStep0.TxtPassword);
            dataStep0.TxtFirstName = "TestNameArabia";
            dataStep0.TxtLastName = "TestLastNameArabia";
            dataStep0.CmbCountry = "Saudi Arabia";
            dataStep0.BtnNexStep = true;

            DataStep1 dataStep1 = new DataStep1();
            dataStep1.TxtAddress = "Halat Mahish Street 1";
            dataStep1.TxtCity = "Al Qatif";
            //dataStep1.CmbEmirate = "Dubai";
            dataStep1.TxtBirthdate = "01/01/1990";
            dataStep1.TxtPhone = "971500000000";
            dataStep1.CmbNationality = "Saudi Arabia";
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
            dataStep2.UsCitizen = new DataStep2.DataUsCitizen(btnUScitizen: false);
            //Trading Experience
            dataStep2.CmbTradingExperience = "No";
                dataStep2.ChkHaveRelevantEducational = true;
                dataStep2.ChkIRegularlyMonitorNews = true;
                dataStep2.ChkIHaveReadMaterialOnTrading = true;

            dataStep2.CmbQuestion1 = "500 EUR";
            dataStep2.CmbQuestion2 = "A take profit order";
            dataStep2.CmbQuestion3 = "1:50";

            dataStep2.ChkProfessionalClientNo = true;

            dataStep2.BtnNexStep = true;

            DataStep3 dataStep3 = new DataStep3();
            dataStep3.CmbAccountType = "MT5";
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


            //null
            //without partner; Jurisdiction = mena; Country = Arabia; default; default
            pageTradingAccountsReal.LnkCreateNewAccount.Click();
            PageCreateRealAccount pageCreateRealAccount = new PageCreateRealAccount(ngWebDriver, lng);
            pageCreateRealAccount.WaitLoadPage(pageCreateRealAccount);
            //NO
            pageCreateRealAccount.CmbSelectAccountType.GetValuesList().Should().BeEquivalentTo(new[] { "cTrader", "MT4", "MT5" });
            pageCreateRealAccount.CmbSelectAccountType.SetValueAfterClick(0);
            pageCreateRealAccount.CmbSelectCurrencyBase.GetValuesList().Should().BeEquivalentTo(new[] { "EUR", "GBP", "USD" });

            //0808331
            //good_partner1; Jurisdiction = mena; Country = all; mt4m, xtrader; EUR, USD
            pageTradingAccountsReal.GoToPage(pageTradingAccountsReal.BaseUrl  + "/partner/" + goodPartner1Id);
            pageTradingAccountsReal.WaitLoadPage(pageTradingAccountsReal);
            pageTradingAccountsReal.LnkCreateNewAccount.Click();
            pageCreateRealAccount.WaitLoadPage(pageCreateRealAccount);
            //YES
            Assert.AreEqual(goodPartner1Name, pageCreateRealAccount.CmbSelectPartnership.GetValue());
            pageCreateRealAccount.CmbSelectAccountType.GetValuesList().Should().BeEquivalentTo(new[] { "MT4", "cTrader" });
            pageCreateRealAccount.CmbSelectAccountType.SetValueAfterClick(0);
            pageCreateRealAccount.CmbSelectCurrencyBase.GetValuesList().Should().BeEquivalentTo(new[] { "EUR", "USD" });
            Thread.Sleep(3000);

            //0808332
            //good_partner2; Jurisdiction = gm; Country = other; default; default
            pageTradingAccountsReal.GoToPage(pageTradingAccountsReal.BaseUrl + "/partner/" + goodPartner2Id);
            pageTradingAccountsReal.WaitLoadPage(pageTradingAccountsReal);
            pageTradingAccountsReal.LnkCreateNewAccount.Click();
            pageCreateRealAccount.WaitLoadPage(pageCreateRealAccount);
            //NO
            pageCreateRealAccount.CmbSelectAccountType.GetValuesList().Should().BeEquivalentTo(new[] { "cTrader", "MT4", "MT5" });
            pageCreateRealAccount.CmbSelectAccountType.SetValueAfterClick(0);
            pageCreateRealAccount.CmbSelectCurrencyBase.GetValuesList().Should().BeEquivalentTo(new[] { "EUR", "GBP", "USD" });
            Thread.Sleep(3000);

            //0808333
            //goodPartner3Mena; Jurisdiction = mena; Country = Arabia; null; null
            pageTradingAccountsReal.GoToPage(pageTradingAccountsReal.BaseUrl + "/partner/" + goodPartner3MenaId);
            pageTradingAccountsReal.WaitLoadPage(pageTradingAccountsReal);
            pageTradingAccountsReal.LnkCreateNewAccount.Click();
            pageCreateRealAccount.WaitLoadPage(pageCreateRealAccount);
            //YES
            Assert.AreEqual(goodPartner3MenaName, pageCreateRealAccount.CmbSelectPartnership.GetValue());
            Thread.Sleep(3000);

            //0808334
            //goodPartner3Gm; Jurisdiction = mena; Country = UAE; default; default
            pageTradingAccountsReal.GoToPage(pageTradingAccountsReal.BaseUrl + "/partner/" + goodPartner3GmId);
            pageTradingAccountsReal.WaitLoadPage(pageTradingAccountsReal);
            pageTradingAccountsReal.LnkCreateNewAccount.Click();
            pageCreateRealAccount.WaitLoadPage(pageCreateRealAccount);
            //NO
            pageCreateRealAccount.CmbSelectAccountType.GetValuesList().Should().BeEquivalentTo(new[] { "cTrader", "MT4", "MT5" });
            pageCreateRealAccount.CmbSelectAccountType.SetValueAfterClick(0);
            pageCreateRealAccount.CmbSelectCurrencyBase.GetValuesList().Should().BeEquivalentTo(new[] { "EUR", "GBP", "USD" });

        }
    }
}
