using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using Protractor;
using System.Configuration;
using UITestDirect2.Core.Infrastructure;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Uk
    {

        private static readonly string baseUrl = ConfigurationManager.AppSettings["serverAddress"];
        private static readonly string browser = ConfigurationManager.AppSettings["browser"];

        private IWebDriver webDriver;
        private NgWebDriver ngWebDriver;
        private Stopwatch timeTest = new Stopwatch();

        [OneTimeSetUp]
        public void BeforeTests()
        {
            switch (browser)
            {
                case "Mozilla":
                    var firefoxProfile = new FirefoxProfile
                    {
                        AcceptUntrustedCertificates = true,
                        EnableNativeEvents = true
                    };
                    webDriver = new FirefoxDriver(firefoxProfile);
                    break;

                case "Chrome":
                    ChromeOptions cOptions = new ChromeOptions();
                    //disable top message "Chrome is being controlled by automated test software"
                    cOptions.AddArguments("disable-infobars");
                    webDriver = new ChromeDriver(cOptions);
                    break;

                default:
                    Log.Error("The browser was not specified in the app.config.");
                    break;

            }
            ngWebDriver = new NgWebDriver(webDriver);
            //1200 мобильная весия сайта, без картинки. Картинка мешает скролу формы.
            //ngWebDriver.Manage().Window.Size = new Size(1200, 1040);
            ngWebDriver.Manage().Window.Maximize();

            ngWebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            ngWebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }


        [SetUp]
        public void BeforeEachTest()
        {
            ngWebDriver.Manage().Cookies.DeleteAllCookies();
            //Logging the execution of the test
            timeTest.Reset();
            timeTest.Start();
            Log.Info("Start test {0}.", TestContext.CurrentContext.Test.FullName);

        }


        [TearDown]
        public void AfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed && webDriver != null)
            {
                Log.Info("Test {0} failed.", TestContext.CurrentContext.Test.FullName);
                //Take snapshot
                ScreenShots.SaveScreenshotAllPage(webDriver, TestContext.CurrentContext.Test.Name.Replace("\"", "") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "."));
                //webDriver.SaveScreenshot(TestContext.CurrentContext.Test.Name.Replace("\"", "") + "_" +
                //                            DateTime.Now.ToLongTimeString().Replace(":", ".") + "_Browser.jpg");
            }

            //Logging the test execution
            timeTest.Stop();
            Log.Info("Stop test {0}. Test status: {1}. Test time: {2} ms.", TestContext.CurrentContext.Test.FullName, TestContext.CurrentContext.Result.Outcome.Status, timeTest.Elapsed);
            ngWebDriver.Manage().Cookies.DeleteAllCookies();
        }

        [OneTimeTearDown]
        public void AfterTests()
        {
            if (webDriver != null)
            {
                webDriver.Close();
                webDriver.Quit();
            }
        }

    }
}
