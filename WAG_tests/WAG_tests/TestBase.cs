﻿using System;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Diagnostics;


namespace WAG_fast
{

    [TestFixture()]
    public class TestBase
    {
      public static IWebDriver firefox;
    //  WebDriverWait wait;

        [SetUp]
      public void StartBrowser()
        {
           // ChromeOptions option = new ChromeOptions();
           // option.AddArguments("disable-infobars");
           // option.AddArguments("start-maximized");

            firefox = WebDriverFactory.GetDriver(DesiredCapabilities.Firefox());
           // firefox = WebDriverFactory.GetDriver(DesiredCapabilities.Chrome());
           // firefox = new ChromeDriver(option);
            
            firefox.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            firefox.Manage().Window.Maximize();
           // firefox.Navigate().GoToUrl(BaseUrl);
        }

        // methods for all tests
        public void GoToProductPage(string ProductUrl)
        {
            firefox.Navigate().GoToUrl(ProductUrl);
        }


        public void FindPrice()
        {

            try
            {
                firefox.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                if (firefox.FindElement(By.ClassName("vip__price-box-price")).Text.Substring(0, 1) == "0")
                {
                    Screenshot.Snap();
                    Trace.WriteLine("Check out why the test failed. See screenshot", "StateS");
                    Trace.WriteLine(firefox.FindElement(By.ClassName("vip__price-box-price")).Text);
                }

                Assert.IsTrue(firefox.FindElement(By.ClassName("vip__price-box-price")).Text.Substring(0, 1) != "0");
            }
            catch (NoSuchElementException)
            {

                Screenshot.Snap();
                Trace.WriteLine("No price element", "StateS");
                Assert.Fail();
            }
            

        }


    }
}
