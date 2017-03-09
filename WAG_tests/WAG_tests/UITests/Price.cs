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
            GoToProductPage("https://www.whiteaway.no/hvitevarer/oppvaskmaskin/innbyggings-oppvaskmaskin/product/siemens-sn478s16ts/");
            FindPrice();
        }

        [Test()]
        public void PriceCheckSkousenNo()
        {
            GoToProductPage("https://www.skousen.no/hvitevarer/oppvaskmaskin/innbyggings-oppvaskmaskin/product/siemens-sn478s16ts/");
            FindPrice();
        }

        [Test()]
        public void PriceCheckSkousenDk()
        {
            GoToProductPage("https://www.skousen.dk/hvidevarer/vaskemaskine/frontbetjent-vaskemaskine/product/lg-f1496tda3-testvinder-2014/");
            FindPrice();
        }


        [Test()]
        public void PriceCheckEnemoSe()
        {
            GoToProductPage("https://www.enemo.se/vitvaror/tvattmaskiner/frontmatad-tvattmaskin/siemens-wm14w447dn/");
            FindPrice();
        }


        [Test()]
        public void PriceCheckTrettiSe()
        {
            GoToProductPage("https://www.tretti.se/vitvaror/tvattmaskin/frontmatad-tvattmaskin/product/bosch-wat286i8sn-i-dos/");
            FindPrice();
        }


        [Test()]
        public void PriceCheckTrettiNo()
        {
            GoToProductPage("https://www.tretti.no/hvitevarer/torketrommel/kondens-torketrommel/product/siemens-wt47w568dn/");
            FindPrice();
        }


        [Test()]
        public void PriceCheckTrettiFi()
        {
            GoToProductPage("https://www.tretti.fi/pienkoneet/polynimuri/polynimuri/product/electrolux-zusgreen58-ultra-silencer-zen-recycled/");
            FindPrice();
        }


    }
}