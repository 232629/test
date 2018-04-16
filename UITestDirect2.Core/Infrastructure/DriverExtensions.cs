using System;
using System.Diagnostics;
using OpenQA.Selenium;

namespace UITestDirect2.Core.Infrastructure
{
    public static class DriverExtensions
    {
        private const string jqueryReady =
                "var result = true; try { result = (typeof jQuery != 'undefined') ? jQuery.active == 0 : true } catch (e) {}; return result;"
            ;

        public static bool WaitForAjaxScripts(this IWebDriver driver, int timeout = 10000)
        {
            var timer = Stopwatch.StartNew();

            while (true)
            {
                try
                {
                    if ((bool) ((IJavaScriptExecutor) driver).ExecuteScript(jqueryReady))
                        return true;
                }
                catch (Exception ex)
                {
                    Log.Warn("JQuery is not ready.", ex);
                    return false;
                }
                if (timer.ElapsedMilliseconds > timeout)
                {
                    return false;
                }
                System.Threading.Thread.Sleep(100);
            }
        }


    }
}
