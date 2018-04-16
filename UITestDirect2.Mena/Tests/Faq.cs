using System.Threading;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using UITestDirect2.Core.Helpers;
using UITestDirect2.Core.Pages.Client_area;

namespace UITestDirect2
{
    [TestFixture]
    public partial class UITestDirect2Mena
    {
        [Test]
        //[Ignore("need fix")]
        [TestCase("en")]
        public void Faq(string lng)
        {
            #region Test Data 

            string login = "875584@testing.test";
            string pas = "Password1";

            Actions action = new Actions(ngWebDriver);
            Actions action1 = new Actions(ngWebDriver.WrappedDriver);


            #endregion

            //Create user with account currency = 'currency'
            LoginHelper.Login(ngWebDriver, lng, login, pas);

            PageTradingAccountsReal pageTradingAccountsReal = new PageTradingAccountsReal(ngWebDriver, lng);
            pageTradingAccountsReal.WaitLoadPage(pageTradingAccountsReal);
            pageTradingAccountsReal.LnkFaq.Click();

            PageFaq pageFaq = new PageFaq(ngWebDriver, lng);
            pageFaq.WaitLoadPage(pageFaq);

            pageFaq.WaitDisplayElements(pageFaq.LblVideo1);
            Assert.AreEqual("How to upload documents?", pageFaq.LblVideo1.Text);
            pageFaq.LblVideo1.Click();
            pageFaq.WaitDisplayElements(pageFaq.BtnCloseVideo1);
            Thread.Sleep(1000);
            pageFaq.BtnCloseVideo1.Click();


            pageFaq.WaitDisplayElements(pageFaq.LblVideo2);
            Assert.AreEqual("How to deposit by credit card?", pageFaq.LblVideo2.Text);
            pageFaq.LblVideo2.Click();
            pageFaq.WaitDisplayElements(pageFaq.BtnCloseVideo2);
            Thread.Sleep(1000);
            pageFaq.BtnCloseVideo2.Click();


            pageFaq.WaitDisplayElements(pageFaq.LblVideo3);
            Assert.AreEqual("How to deposit by Bank Wire?", pageFaq.LblVideo3.Text);
            pageFaq.LblVideo3.Click();
            pageFaq.WaitDisplayElements(pageFaq.BtnCloseVideo3);
            Thread.Sleep(1000);
            pageFaq.BtnCloseVideo3.Click();


            pageFaq.WaitDisplayElements(pageFaq.LblVideo4);
            Assert.AreEqual("How to create more accounts?", pageFaq.LblVideo4.Text);
            pageFaq.LblVideo4.Click();
            pageFaq.WaitDisplayElements(pageFaq.BtnCloseVideo4);
            Thread.Sleep(1000);
            pageFaq.BtnCloseVideo4.Click();

        }
    }
}
