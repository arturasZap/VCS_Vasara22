using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassWork
{
    internal class DemoQaTextBox
    {
        [Test]
        public static void TestFullNameAndEmailAddress()
        {

            string name = "Friday";

            IWebDriver driver = new ChromeDriver
            {
                Url = "https://demoqa.com/text-box"
            };

            IWebElement fullNameInputField = driver.FindElement(By.Id("userName"));
            fullNameInputField.SendKeys(name);

            IWebElement emailAddress = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            emailAddress.SendKeys("arturasza@gmail.com");

            IWebElement submitButton = driver.FindElement(By.CssSelector("#submit"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("name"));
            Assert.AreEqual($"Name:{name}", result.Text, "Name is wrong!");

            IWebElement emailResult = driver.FindElement(By.Id("email"));
            Assert.IsTrue(emailResult.Text.Equals("Email:arturaszap@gmail.com"), "Email is wrong!");

            driver.Close();
        }

    }
}
