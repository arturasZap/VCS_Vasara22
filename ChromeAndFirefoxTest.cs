using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace ClassWork
{
    internal class ChromeAndFirefoxTest
    {

        [TestCase()]
        public static void ChromeTest()

        {
            _ = new FirefoxDriver();
            ChromeDriver driver = new ChromeDriver();
            {
                driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            };
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            Assert.IsAssignableFrom<ChromeDriver>(driver);

            driver.Close();

        }
        [Test]
        public static void FirefoxTest()

        {
            FirefoxDriver driverFirefox = new FirefoxDriver();
            {
                driverFirefox.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            };
            driverFirefox.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driverFirefox.Manage().Window.Maximize();
            Assert.IsAssignableFrom<FirefoxDriver>(driverFirefox);

            driverFirefox.Close();

        }

    }
}
