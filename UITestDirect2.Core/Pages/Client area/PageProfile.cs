using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public class PageProfile : PageCommon
    {
        public PageProfile(NgWebDriver driver, string lng = "en")
            : base(driver, lng)
        { }

        public override string ExpectedUrl
        {
            get
            {
                return BaseUrl + "/" + Language + "/profile";
            }
        }

        public override string ExpectedTitle
        {
            get { return "FxPro"; }
        }

        public override string ScreenShot
        {
            get { return FolderExpectedScreenShots + "\\" + Language + "\\Profile.jpg"; }
        }

        #region Personal details

        public NgWebElement LnkEditPersonalDetails
        {
            get { return FindElement(By.Id("profile_menu_item_details")); }
        }

        public NgWebElement LnkChangeResidentalAddress
        {
            get { return FindElement(By.Id("profile_menu_item_change_address")); }
        }

        #endregion

        #region Log in details & security

        public NgWebElement LnkChangePassword
        {
            get { return FindElement(By.Id("profile_menu_item_change_password")); }
        }

        #endregion

        #region Profile verification

        public NgWebElement LnkUploadDocuments
        {
            get { return FindElement(By.Id("profile_menu_item_upload_documents")); }
        }

        public NgWebElement LnkManageBankDetails
        {
            get { return FindElement(By.Id("profile_menu_item_manage_bank_details")); }
        }
        #endregion

        #region Downloads

        public NgWebElement LnkLegalDocumentation
        {
            get { return FindElement(By.Id("profile_menu_legal_documentation")); }
        }

        #endregion
    }
}
