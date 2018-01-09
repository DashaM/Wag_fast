using System;

using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace WAG_fast
{
    [TestFixture()]
    public class Price : TestBase
    {
        [Test()]
        public void PriceCheckWhiteawayCom()
        { 
            GoToProductPage("https://www.whiteaway.com/hvidevarer/vaskemaskine/frontbetjent-vaskemaskine/product/blomberg-bwg486w0/");
            FindPrice();
            //test
        }


        [Test()]
        public void PriceCheckWhiteawaySe()
        {
            GoToProductPage("https://www.whiteaway.se/vitvaror/torktumlare/kondenstumlare-torktumlare/product/bosch-wtw87568sn-wtw875m8sn/");
            FindPrice();
        }

        [Test()]
        public void PriceCheckWhiteawayNo()
        {
            GoToProductPage("https://www.whiteaway.no/hvitevarer/vaskemaskin/frontmatet-vaskemaskin/product/whirlpool-fscr-70411/");
            FindPrice();
        }

        [Test()]
        public void PriceCheckSkousenNo()
        {
           // GoToProductPage("https://www.skousen.no/hvitevarer/vaskemaskin/underkategori-vaskemaskin/product/indesit-ewe71483w/");
            GoToProductPage("https://www.skousen.no/kjokkenutstyr/kjokkenutstyr/kjokkenvekt/product/caso-cs3260-koekkenvaegt/");
            
            FindPrice();
        }

        [Test()]
        public void PriceCheckSkousenDk()
        {
            GoToProductPage("https://www.skousen.dk/hvidevarer/opvaskemaskine/underbygnings-opvaskemaskine/product/siemens-sn457s03ms-inkl-holder-til-vinglas/");
            FindPrice();
        }


        [Test()]
        public void PriceCheckEnemoSe()
        {
            GoToProductPage("https://www.enemo.se/vitvaror/tvattmaskiner/frontmatad-tvattmaskin/product/bosch-waw325i8sn/");
            FindPrice();
        }


        [Test()]
        public void PriceCheckTrettiSe()
        {
            GoToProductPage("https://www.tretti.se/vitvaror/tvattmaskin/toppmatad-tvattmaskin/product/whirlpool-tdlr-60220/");
           // GoToProductPage("https://www.tretti.se/tradgard/kladvaard/angstation/product/philips-perfekt-care-demo/");
            FindPrice();
        }


        [Test()]
        public void PriceCheckTrettiNo()
        {
           // GoToProductPage("https://www.tretti.no/hvitevarer/vaskemaskin/underkategori-vaskemaskin/product/bosch-wat283l8sn/");

            GoToProductPage(
                "https://www.tretti.no/hvitevarer/vaskemaskin/underkategori-vaskemaskin/product/lg-f4j7ty2w/");
            FindPrice();
        }


       /* [Test()]
        public void PriceCheckTrettiFi()
        {
           // GoToProductPage("https://www.tretti.fi/pienkoneet/polynimuri/polynimuri/product/electrolux-zusgreen58-ultra-silencer-zen-recycled/");
           // GoToProductPage("https://www.tretti.fi/kodinkoneet/pyykinpesukone/edesta-taytettava/product/bosch-wat286i7sn/");
            GoToProductPage("https://www.tretti.fi/pienkoneet/keittiokone/sauvasekoitin/product/champion-stavmixer-8-p-chstm20-0/");
            FindPrice();
        }
        */

    }
}