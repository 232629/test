using System;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;
using UITestDirect2.Core.Infrastructure;
using UITestDirect2.Core.Pages.Registration;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Mena
    {
        /// <summary>
        /// Test
        /// </summary>
        [Test]
        //[Ignore("for testing")]
        [TestCase("en")]
        public void Test(string lng)
        {
            #region Test Data

            var login = "aa@aa.aa";
            Stopwatch time = new Stopwatch();

            #endregion

            //PageLogin pageLogin = new PageLogin(ngWebDriver, lng);
            //pageLogin.GoToPage(pageLogin.ExpectedUrl);
            //pageLogin.WaitLoadPage(pageLogin);


            //pageLogin.LnkCreateAnAccount.Click();

            //PageRegister pageRegister = new PageRegister(ngWebDriver, lng);
            //pageRegister.WaitLoadPage(pageRegister);

            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    time.Reset();
                    time.Start();
                    ngWebDriver.WrappedDriver.Navigate().GoToUrl("https://cookies.technowdb.info/cookie.php/?gc");
                    time.Stop();

                    if (time.Elapsed.Milliseconds > 5000)
                        Log.Error("N = " + i + ". Time = " + time.Elapsed.Milliseconds + " ms.");
                    else
                        Log.Info("N = " + i + ". Time = " + time.Elapsed.Milliseconds + " ms.");


                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    time.Stop();
                    Log.Info("N = " + i + ". Time = " + time.Elapsed.Milliseconds + " ms." + ". Exeption: " + e);
                }

            }

        }

    }
}
