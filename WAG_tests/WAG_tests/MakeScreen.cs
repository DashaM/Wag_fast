using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;


namespace WAG_fast
{

    public class MakeScreen
    {
      protected  IWebDriver firefox;
    //  WebDriverWait wait;







         public static void Snap()
        {
           // Trace.WriteLine("Create screenshot.", "StateS");
            CreateFileDirectory(Config.PathToLogs);
            ((ITakesScreenshot)StateS.Driver).GetScreenshot().SaveAsFile(CreateScreenshotFileName, ImageFormat.Png);
        }
 
        public static void CreateFileDirectory()
        {
            bool dirExists = Directory.Exists(Config.PathToLogs);
            if (!dirExists)
                Directory.CreateDirectory(Config.PathToLogs);
        }
 
        public static string CreateScreenshotFileName
        {
            get
            {
                var timeStamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                var filename = TestContext.CurrentContext.Test.FullName;
                filename = filename + "-" + timeStamp;
                filename = Config.PathToLogs + filename + ".png";
                return filename;
            }
        }






    }
}
