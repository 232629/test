using OpenQA.Selenium;
using Protractor;

namespace UITestDirect2.Core.Pages.Client_area
{
    public abstract class PageCommon : PageBase
    {
        public PageCommon(NgWebDriver driver, string lng)
            : base(driver, lng)
        { }

        #region Client Area Header
        public NgWebElement BtnMenuProfile
        {
            get { return FindElement(By.Id("dropdownMenuButtonProfile")); }
        }

            public NgWebElement LnkMenuMyProfile
            {
                get { return FindElement(By.CssSelector("div.dropdown.show>div.dropdown-menu")).FindElement(By.LinkText("My profile")); }
            }
            public NgWebElement LnkMenuLogout
            {
                get { return FindElement(By.CssSelector("div.dropdown.show>div.dropdown-menu")).FindElement(By.LinkText("Logout")); }
            }

        public NgWebElement BtnMenuSettings
        {
            get { return FindElement(By.Id("dropdownMenuButtonSettings")); }
        }

        public NgWebElement BtnNotification
        {
            get { return FindElement(By.Id("dropdownMenuButtonProfile")); }
        }

        public NgWebElement LblFxProDirect
        {
            get { return FindElement(By.CssSelector("a.navbar-brand")); }
        }

        public NgWebElement LnkAccounts
        {
            get { return FindElement(By.Id("nav_menu_item_accounts")); }
        }

        public NgWebElement LnkWallet
        {
            get { return FindElement(By.Id("nav_menu_item_manage_funds")); }
        }

        public NgWebElement LnkHistory
        {
            get { return FindElement(By.Id("nav_menu_item_history")); }
        }


        public NgWebElement LnkFaq
        {
            get { return FindElement(By.Id("nav_menu_item_faq")); }
        }

        public NgWebElement BtnQuickDeposit
        {
            get { return FindElement(By.Id("quick-deposit")); }
        }
        #endregion

        #region Footer
        public NgWebElement LnkLiveChat
        {
            get { return FindElement(By.LinkText("Live chat")); }
        }

        public NgWebElement LnkGetCall
        {
            get { return FindElement(By.LinkText("Get a Call")); }
        }
        #endregion
    }
}
