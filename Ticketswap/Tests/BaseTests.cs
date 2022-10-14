using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Ticketswap.Tests
{
    [TestFixture(typeof(ChromeDriver))]
    public class BaseTests<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        protected IWebDriver Driver;
        public static string _pathToBuildFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        [SetUp]
        public void SetUp()
        {

            //try
            //{
            Driver = new TWebDriver();
            Driver.Manage()
                .Window
                .Maximize();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex);
            //    TearDown();
            //}
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Close();
            Driver.Quit();
        }

    }
}
