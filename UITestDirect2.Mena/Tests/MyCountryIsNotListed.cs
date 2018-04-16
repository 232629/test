using System.Threading;
using NUnit.Framework;
using UITestDirect2.Core.Pages.Registration;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Mena
    {
        /// <summary>
        /// Сountry of residence > My country is not listed.
        /// Redirect to https://direct.fxpro.com/register?lang=XX#step1
        /// </summary>
        [Test]
        //[Retry(3)]
        [TestCase("en")]
        [TestCase("ar")]
        [Description(
            "Сountry of residence > My country is not listed")]
        public void MyCountryIsNotListed(string lng)
        {
            #region Test Data

            #endregion

            //Login page
            PageLogin pageLogin = new PageLogin(ngWebDriver, lng);
            pageLogin.GoToPage(pageLogin.ExpectedUrl);
            Assert.AreEqual(pageLogin.ExpectedUrl, ngWebDriver.Url);
            pageLogin.LnkCreateAnAccount.Click();
            ngWebDriver.WaitForAngular();
            //Register page
            PageRegister pageRegister = new PageRegister(ngWebDriver, lng);
            pageRegister.CmbCountry.SetValueAfterClick("My country is not listed");
            //ngWebDriver.WaitForAngular();

            Thread.Sleep(5000);

            switch (lng)
            {
                case "en":
                    Assert.AreEqual(@"https://direct.fxpro.com/register?lang=en#step1", ngWebDriver.WrappedDriver.Url);
                    break;
                case "ar":
                    Assert.AreEqual(@"https://direct.fxpro.com/register?lang=ar#step1", ngWebDriver.WrappedDriver.Url);
                    break;
            }
        }
    }
}
