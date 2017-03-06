using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;


namespace WAG_fast
{

    [TestFixture()]
    public class TestBase
    {
      protected  IWebDriver firefox;
    //  WebDriverWait wait;

        [SetUp]
      public void StartBrowser()
        {
            firefox = WebDriverFactory.GetDriver(DesiredCapabilities.Firefox());
            firefox.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            firefox.Manage().Window.Maximize();
            //firefox.Navigate().GoToUrl(BaseUrl);
        }


        // methods for all tests
        public void GoToProductPage(string ProductUrl)
        {
            firefox.Navigate().GoToUrl(ProductUrl);
        }


        public void FindPrice()
        {
            Assert.IsTrue(firefox.FindElement(By.ClassName("vip__price-main")).Text.Substring(0,1)!="0");
        }


    }
}
