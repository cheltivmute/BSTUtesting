using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace GitHubAutomation.Pages
{
    public class HotelsPage
    {
        private IWebDriver _driver;

        private IWebElement _countryButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[1]/label[1]/input"));

        private IWebElement _departureDateButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[2]/label[1]"));
        private IWebElement _departureDateNextListButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[2]/div/div/div[1]/div"));
        private IWebElement _departureDateListButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[2]/div/div/div[2]/div[2]/div/div[3]/div[2]/div[5]"));

        private IWebElement _returnDateButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[2]/label[2]"));
        private IWebElement _returnDateListButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[2]/div/div/div[2]/div[2]/div/div[3]/div[2]/div[7]"));

        private IWebElement _findHotelssButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[2]/a"));

        public HotelsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void FindHotels(string nameCountry)
        {
            Thread.Sleep(2000);
            _countryButton.SendKeys(nameCountry);
            _departureDateButton.Click();
            Thread.Sleep(1000);
            _departureDateNextListButton.Click();
            _departureDateListButton.Click();
            Thread.Sleep(1000);
            _returnDateListButton.Click();
            Thread.Sleep(1000);
            _findHotelssButton.Click();
            Thread.Sleep(2000);
        }
    }
}
