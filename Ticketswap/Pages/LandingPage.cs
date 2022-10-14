using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ticketswap.Pages
{
    public class LandingPage:BasePage
    {
        public LandingPage(IWebDriver driver) : base(driver) { }

        internal static LandingPage Navigate(IWebDriver Driver, string url)
        {
            Driver.Navigate().GoToUrl(url);
            return new LandingPage(Driver);
        }

    }
}
