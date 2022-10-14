using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Threading;

namespace Ticketswap.Pages
{
    public class EventPage:BasePage
    {
        public IWebElement BuyTicket => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains(text(),'Buy ticket')]")));

        public EventPage(IWebDriver driver) : base(driver) { }

        internal void PutTicketIntoBasket()
        {
            int count = 0;
            while (true)
            {
                var random = new Random();
                //15.45
                Thread.Sleep(random.Next(1000,3000));
                ReloadPage();
                count++;
                Console.WriteLine(count);
                if (Driver.FindElements(By.XPath("//h3[contains(text(),'Available')]/following-sibling::a")).Count>0)
                {
                    Driver.FindElement(By.XPath("//h3[contains(text(),'Available')]/following-sibling::a")).Click();
                    BuyTicket.Click();
                    //if (Driver.FindElements(By.XPath("//*[contains(text(),'Your tickets are reserved for 10 minutes.')]")).Count > 0)
                    if (Driver.FindElements(By.XPath("//*[contains(text(),'After the payment is processed')]")).Count > 0)
                    {
                        int alert = 0;
                        while (alert < 20) 
                        {
                            SystemSounds.Asterisk.Play();
                            Thread.Sleep(20000);
                            alert++;
                        }
                        
                    }
                    if (Driver.FindElements(By.XPath("//*[contains(text(),'Your tickets are reserved for 10 minutes.')]")).Count == 0)
                    {
                        continue;
                    }

                }
                else
                {
                    continue;
                }
            }

        }
    }
}
