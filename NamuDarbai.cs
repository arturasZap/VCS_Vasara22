using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassWork
{
    internal class NamuDarbai
    {
        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("a", "b", "ERR", TestName = "a + b = ERR")]
        public static void case1(string number1, string number2, string expectedResult)
        {

            IWebDriver driver = new ChromeDriver();
            {
                driver.Url = "https://testpages.herokuapp.com/styled/calculator";
            }
            driver.Manage().Window.Maximize();

            IWebElement insert1 = driver.FindElement(By.Id("number1"));

            insert1.SendKeys(number1);

            IWebElement insert2 = driver.FindElement(By.Id("number2"));
            insert2.SendKeys(number2);

            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.CssSelector("#answer"));
            Assert.AreEqual(result.Text, expectedResult);

            driver.Close();

        }

        //------------------------Namu Darbai___________________________________

    }
}
