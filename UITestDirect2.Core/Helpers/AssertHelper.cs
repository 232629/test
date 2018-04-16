using System;
using System.Drawing;
using NUnit.Framework;
using OpenQA.Selenium;
using UITestDirect2.Core.Infrastructure;

namespace UITestDirect2.Core.Helpers
{
    public static class AssertHelper
    {
        static public void AssertScreenShot(IWebDriver webDriver, string expScr, double tolerance)
        {
            tolerance = (tolerance < 0) ? 0 : tolerance;
            tolerance = (tolerance > 100) ? 100 : tolerance;
            
            try
            {
                var actualScr = ScreenShots.GetScreenshotAllPage(webDriver, 500);

                //actualScr.Save("C:\\Users\\e.kovalenko\\FxPro.Direct\\UITestDirect2\\Resources\\ExpectedScreenShots\\en\\_1.jpg");

                var difImg = Math.Round(ImageCompare.PercentDifferenceImages(new Bitmap(expScr), actualScr), 4);
                Assert.IsTrue(difImg <= tolerance, "Difference Images = " + difImg + "%. Tolerance = " + tolerance + "%");
            }
            catch (ArgumentException e)
            {
                Log.Warn("There aren't screenshots for the current language.");
            }
        }
    }
}
