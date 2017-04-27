using System;
using OpenQA.Selenium;
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

            if (firefox.FindElement(By.ClassName("vip__price-main")).Text.Substring(0, 1) == "7")
            {
                Screenshot.Snap();
                Trace.WriteLine("Check out why the test failed. See screenshot", "StateS");
            }

            Assert.IsTrue(firefox.FindElement(By.ClassName("vip__price-main")).Text.Substring(0, 1) != "7");

        }


    }
}
