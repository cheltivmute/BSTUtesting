using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using static OpenQA.Selenium.PrintOptions;

namespace MyTest
{
    public class Tests
    {
        [Test]
        public void FindQuestions()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.anywayanyday.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/a[4]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[1]/section/section/div[1]/div[4]/ul/li[5]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Close();
        }
    }
}