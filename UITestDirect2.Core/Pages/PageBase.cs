using System;
using System.Collections.ObjectModel;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using Protractor;
using UITestDirect2.Core.CustomElements;
using UITestDirect2.Core.Infrastructure;

namespace UITestDirect2.Core.Pages
{
    public abstract class PageBase
    {
        private readonly NgWebDriver ngWebDriver;
        private static readonly string browser = ConfigurationManager.AppSettings["browser"];
        private static readonly string baseUrl = ConfigurationManager.AppSettings["serverAddress"];
        private static readonly string folderExpectedScreenShots = ConfigurationManager.AppSettings["folderExpectedScreenShots"];
        private string language;
        protected PageBase(NgWebDriver driver, string lng = "en")
        {
            ngWebDriver = driver;
            language = lng;
        }

        public bool WaitForAjaxScripts(int timeout = 10000)
        {
            return ngWebDriver.WaitForAjaxScripts(timeout);
        }

        protected string Browser
        {
            get { return browser; }
        }

        public string BaseUrl
        {
            get { return baseUrl; }
        }

        protected string Language
        {
            get { return language; }
        }

        protected string FolderExpectedScreenShots
        {
            get { return folderExpectedScreenShots; }
        }

        protected internal NgWebDriver NgWebDriver
        {
            get { return ngWebDriver; }
        }

        public abstract string ExpectedUrl { get; }

        public abstract string ExpectedTitle { get; }

        public abstract string ScreenShot { get; }

        /// <summary>
        /// Redirect can be used few times between pages
        /// </summary>
        /// <param name="count">Count of redirect</param>
        public void WaitLoadPage(int count = 1)
        {
            for(int i = 0; i < count; i ++)
                NgWebDriver.WaitForAngular();   
        }

        /// <summary>
        /// Wait when angular page was loaded
        /// </summary>
        /// <param name="page">Wait this page</param>
        /// <param name="timeoutBtwErrors">ms</param>
        /// <param name="countErrors">Count of errors</param>

        public void WaitLoadPage(PageBase page, int timeoutBtwErrors = 500, int countErrors = 5)
        {
            for (int i = 1; i <= countErrors; i++)
            {
                try
                {
                    NgWebDriver.WaitForAngular();
                    Assert.AreEqual(page.ExpectedUrl, ngWebDriver.Url);
                }
                catch (Exception)
                {
                    if (i == countErrors)
                        throw;
                    System.Threading.Thread.Sleep(timeoutBtwErrors);
                }
            }
        }

        protected NgWebElement FindElement(By by)
        {
            return ngWebDriver.FindElement(by);
        }

        protected ReadOnlyCollection<NgWebElement> FindElements(By by)
        {
            return ngWebDriver.FindElements(by);
        }

        public NgWebElement WaitDisplayElements(NgWebElement element, int timeout = 5000)
        {
            var waitTime = 100;
            DateTime tend = DateTime.Now.AddMilliseconds(timeout);
            do
            {
                System.Threading.Thread.Sleep(waitTime);
                if (element.Displayed)
                    return element;
            } while (DateTime.Now <= tend);

            Assert.Fail("Element {0} was not shown during time {1} ms.", element, timeout);
            return null;
        }

        public NgWebElement WaitHideElements(NgWebElement element, int timeout = 5000)
        {
            var waitTime = 100;
            DateTime tend = DateTime.Now.AddMilliseconds(timeout);
            do
            {
                System.Threading.Thread.Sleep(waitTime);
                if (!element.Displayed)
                    return element;
            } while (DateTime.Now <= tend);

            Assert.Fail("Element {0} was not hidden during time {1} ms.", element, timeout);
            return null;
        }

        /// <summary>
        /// it isn't finished
        /// </summary>
        /// <param name="element"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        /// <param name="timeout"></param>
        public void WaitAttributeElements(NgWebElement element, string attributeName, string attributeValue,  int timeout = 5000)
        {
            var waitTime = 100;
            DateTime tend = DateTime.Now.AddMilliseconds(timeout);
            do
            {
                System.Threading.Thread.Sleep(waitTime);
                if (element.GetAttribute(attributeName) == attributeValue)
                    return;

            } while (DateTime.Now <= tend);

            Assert.Fail("Element {0} was not hidden during time {1} ms.", element, timeout);
        }




        public void GoToPage(string url)
        {
            ngWebDriver.Navigate().GoToUrl(url);
        }

        public bool IsElementPresent(By locator)
        {
            try
            {
               ngWebDriver.FindElement(locator);
               return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


    

    }
}
