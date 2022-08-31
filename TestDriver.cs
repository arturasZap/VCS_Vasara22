using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace ClassWork
{
    internal class TestDriver
    {
        [Test]
        public static void TestChromeDriver()
        {
            IWebDriver driver = new ChromeDriver
            {
                Url = "https://login.yahoo.com/"
            };
            Thread.Sleep(2000);
            driver.Close();

        }
    }
}
