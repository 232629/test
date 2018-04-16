using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageUploadDocuments : PageCommon
    {
        public PageUploadDocuments(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/profile/documents";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\ProfileDocuments.jpg"; }
        }

        public NgWebElement BtnIdCardOrPassport
        {
            get { return WaitDisplayElements(FindElement(By.Id("label-id-card"))); }
        }

        public NgWebElement BtnIdCardBack
        {
            get { return WaitDisplayElements(FindElement(By.Id("label-id-card-back"))); }
        }

        public NgWebElement BtnProofOfResidence
        {
            get { return WaitDisplayElements(FindElement(By.Id("label-residence-proof"))); }
        }

        public NgWebElement LnkBack
        {
            get { return FindElement(By.LinkText("")); }
        }

    }
}
