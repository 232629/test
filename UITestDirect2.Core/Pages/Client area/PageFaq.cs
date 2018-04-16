using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageFaq : PageCommon
    {
        public PageFaq(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/faq";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\faq.jpg"; }
        }

        public NgWebElement LblVideo1
        {
            get { return FindElements(By.CssSelector("div.card"))[0]; }
        }

        public NgWebElement AreaCloseVideo1
        {
            get { return FindElement(By.CssSelector("body.modal-open")); }
        }
       
        public NgWebElement BtnCloseVideo1
        {
            get { return FindElement(By.Id("video-modal-0")).FindElement(By.CssSelector("button.close")); }
        }     


        public NgWebElement LblVideo2
        {
            get { return FindElements(By.CssSelector("div.card"))[1]; }
        }

        public NgWebElement BtnCloseVideo2
        {
            get { return FindElement(By.Id("video-modal-1")).FindElement(By.CssSelector("button.close")); }
        }

        public NgWebElement LblVideo3
        {
            get { return FindElements(By.CssSelector("div.card"))[2]; }
        }

        public NgWebElement BtnCloseVideo3
        {
            get { return FindElement(By.Id("video-modal-2")).FindElement(By.CssSelector("button.close")); }
        }

        public NgWebElement LblVideo4
        {
            get { return FindElements(By.CssSelector("div.card"))[3]; }
        }

        public NgWebElement BtnCloseVideo4
        {
            get { return FindElement(By.Id("video-modal-3")).FindElement(By.CssSelector("button.close")); }
        }


    }
}
