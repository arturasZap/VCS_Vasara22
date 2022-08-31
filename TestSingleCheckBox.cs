using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace ClassWork
{
    internal class TestSingleCheckBox
    {
        private static ChromeDriver driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://demo.anhtester.com/basic-checkbox-demo.html\r\n";
        }

        [SetUp]
        public static void SetUpp()
        {
            IReadOnlyCollection<IWebElement> checkBoxes = driver.FindElements(By.ClassName("cb1-element"));
            foreach (IWebElement checkBox in checkBoxes)
            {
                if (checkBox.Selected)
                {
                    checkBox.Click();
                }
            }
        }

        [Test]
        public static void TestSingleCheckBoxx()
        {
            IWebElement singleCheckBox = driver.FindElement(By.Id("isAgeSelected"));
            singleCheckBox.Click();

            IWebElement singleCheckBoxResult = driver.FindElement(By.Id("txtAge"));
            Assert.AreEqual("Success - Check box is checked", singleCheckBoxResult.Text, "Message is wrong!");
        }

        [Test]
        public static void TestUncheckAllButtonText()

        {
            _ = driver.FindElement(By.ClassName("cb1-element"));
        }

        [Test]
        public static void TestUncheckAllButtonTextt()
        {
            IReadOnlyCollection<IWebElement> checkBoxes = driver.FindElements(By.ClassName("cb1-element"));
            foreach (IWebElement checkBox in checkBoxes)
            {
                checkBox.Click();
            }

            IWebElement button = driver.FindElement(By.Id("check1"));
            Assert.AreEqual("Uncheck All", button.GetAttribute("value").ToString(), "Value is incorrect");
        }

        public static void TestUnselectAllButton()
        {
            // pasižymim visus
            IReadOnlyCollection<IWebElement> checkBoxes = driver.FindElements(By.ClassName("cb1-element"));
            foreach (IWebElement checkBox in checkBoxes)
            {
                checkBox.Click();
            }

            IWebElement button = driver.FindElement(By.Id("check1"));
            button.Click();

            // click on button Unselect All
            Assert.AreEqual("Check All", button.GetAttribute("value").ToString(), "Value is incorrect");
            foreach (IWebElement checkBox in checkBoxes)
            {
                Assert.IsTrue(!checkBox.Selected, "CheckBox Selected.");
            }
            // assert checkbox
        }


        [OneTimeTearDown]
        public static void Exit()
        {
            driver.Close();
        }

    }
}
