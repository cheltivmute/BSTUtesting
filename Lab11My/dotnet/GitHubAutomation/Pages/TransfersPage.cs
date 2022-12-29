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
    public class TransfersPage
    {
        private IWebDriver _driver;

        private IWebElement _departureCityButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/div/div[1]/div[2]/div/div/div[1]/div/span/span[2]/span/input"));
        private IWebElement _departureCityListButton => _driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/div/div[1]/span/div/div/div[2]/p[1]"));

        private IWebElement _returnCityButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/div/div[1]/div[2]/div/div/div[2]/div/span/span[2]/span/input"));
        private IWebElement _returnCityListButton => _driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/div/div/div[1]/span/div/div/div[2]/p[1]"));

        private IWebElement _findHotelssButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/div/div[1]/div[3]/div/button[1]"));

        public TransfersPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void FindCar(string nameCountry)
        {
            Thread.Sleep(6000);
            _departureCityButton.Click();
            Thread.Sleep(1000);
            _departureCityListButton.Click();
            Thread.Sleep(1000);
            _returnCityButton.SendKeys(nameCountry);
            Thread.Sleep(1000);
            _returnCityListButton.Click();
            Thread.Sleep(3000);
            _findHotelssButton.Click();
            Thread.Sleep(2000);
        }
    }
}
