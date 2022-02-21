using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation_test
{
    public class WebBrowser_Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void VerifyingWebPage()
        {
            driver.Navigate().GoToUrl("https://www.healthgrades.com/physician/dr-sandy-test-provider-xyp88j3?referrerSource=autosuggest");

            driver.Quit();

        }

        [Test]
        public void VerifyingReviewTitle()
        {
            driver.Navigate().GoToUrl("https://www.healthgrades.com/physician/dr-sandy-test-provider-xyp88j3?referrerSource=autosuggest");

            var findElements = By.XPath("//h2[@class='title--accented']");
            var element = driver.FindElement(findElements).Text;


            Assert.AreEqual("Dr. Test Provider's Reviews", element);
            driver.Quit();

        }

        [Test]
        public void VerifyingJENKINS()
        {
            driver.Navigate().GoToUrl("https://www.healthgrades.com/physician/dr-sandy-test-provider-xyp88j3?referrerSource=autosuggest");

            var findElements = By.XPath("//h2[@class='title--accented']");
            var element = driver.FindElement(findElements).Text;


            Assert.AreEqual("Dr. Test Provider's Reviews", element);
            driver.Quit();
            //close

        }
    }
}
