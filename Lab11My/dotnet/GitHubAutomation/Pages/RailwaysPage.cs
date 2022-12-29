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
    public class RailwaysPage
    {
        private IWebDriver _driver;

        private IWebElement _departureСityButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[1]/label[1]/input"));

        private IWebElement _arrivalСityButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[2]/label[1]/input"));

        private IWebElement _departureDateButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[3]"));
        private IWebElement _departureDateNextListButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[3]/div/div/div[1]/div"));
        private IWebElement _departureDateListButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[3]/div/div/div[2]/div[2]/div/div[3]/div[2]/div[5]/div/div[1]"));

        private IWebElement _findTicketsButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[2]/a"));

        public RailwaysPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void FindTickets(string departureCityName, string arriveCityName)
        {
            Thread.Sleep(2000);
            _departureСityButton.SendKeys(departureCityName);
            _arrivalСityButton.SendKeys(arriveCityName);
            _departureDateButton.Click();
            Thread.Sleep(1000);
            _departureDateNextListButton.Click();
            _departureDateListButton.Click();
            Thread.Sleep(1000);
            _findTicketsButton.Click();
            Thread.Sleep(2000);
        }
    }
}
