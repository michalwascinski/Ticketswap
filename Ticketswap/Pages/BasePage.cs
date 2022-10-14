using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ticketswap.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;
        protected WebDriverWait Wait;

        public BasePage(IWebDriver driver)
        {

            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
        }
        internal void ReloadPage()
        {
            Driver.Navigate().Refresh();
        }
    }
}
