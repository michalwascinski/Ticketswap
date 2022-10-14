using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Ticketswap.Pages;

namespace Ticketswap.Tests
{
    public class TicketTests<TWebDriver> : BaseTests<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        protected LandingPage LandingPage;
        protected EventPage EventPage;

        string startURL = "https://www.ticketswap.com/";
        [Test]
        public void BuyTicket()
        {
            LandingPage = new LandingPage(Driver);
            EventPage = new EventPage(Driver);

            LandingPage.Navigate(Driver, startURL);
            EventPage.PutTicketIntoBasket();

        }
    }
}
