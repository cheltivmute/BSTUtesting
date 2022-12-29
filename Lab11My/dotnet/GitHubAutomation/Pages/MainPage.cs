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
    public class MainPage
    {
        private IWebDriver _driver;

        private const string BASE_URL = "https://www.anywayanyday.com/";

        //Test1
        private IWebElement _departureСityButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[1]/label[1]/input"));

        private IWebElement _arrivalСityButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[2]/label[1]/input"));

        private IWebElement _departureDateButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[3]"));
        private IWebElement _departureDateNextListButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[3]/div/div/div[1]/div"));
        private IWebElement _departureDateListButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[3]/div/div/div[2]/div[2]/div/div[3]/div[2]/div[5]"));

        private IWebElement _returnDateButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[4]"));
        private IWebElement _returnDateNextListButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[4]/div/div/div[1]/div"));
        private IWebElement _returnDateListButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[4]/div/div/div[2]/div[2]/div/div[3]/div[2]/div[7]"));
    
        private IWebElement _findTicketsButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[3]/a"));

        //Test2
        private IWebElement _hotelsButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[1]/div/ul/li[2]"));

        //Test3
        private IWebElement _railwaysButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[1]/div/ul/li[3]"));

        //Test4-5
        private IWebElement _popQuestionsButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/a[4]"));

        ////Test6
        //private IWebElement _transferButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[1]/div/ul/li[4]/a"));

        //Test8 
        private IWebElement _hardTicketButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[2]/div/span"));
        private IWebElement _secondCity => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[2]/div[2]/label[1]/input"));
        private IWebElement _returnDateButton2 => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[2]/div[3]/label"));
        private IWebElement _returnDateListButton2 => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[2]/div[3]/div/div/div[2]/div[2]/div/div[3]/div[2]/div[7]/div"));
        private IWebElement _findTicketsButton2 => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[4]/a"));

        ////Test9 
        //private IWebElement _helpWindow => _driver.FindElement(By.XPath("/html/body/div[2]"));

        //Test11
        private IWebElement _bonusButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/a[3]"));

        //Test12 
        private IWebElement _closCoockieButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/span"));
        private IWebElement _popRouteButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/footer/div/div[3]/a[1]"));

        



        public MainPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
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
            _returnDateButton.Click();
            Thread.Sleep(1000);
            _returnDateListButton.Click();
            Thread.Sleep(1000);
            _findTicketsButton.Click();
            Thread.Sleep(2000);
        }

        public void OpenHotels()
        {
            Thread.Sleep(2000);
            _hotelsButton.Click();
        }

        public void OpenRailways()
        {
            Thread.Sleep(2000);
            _railwaysButton.Click();
        }

        public void OpenPopularQuestions()
        {
            Thread.Sleep(2000);
            _popQuestionsButton.Click();
        }

        //public void OpenTransfers()
        //{
        //    Thread.Sleep(2000);
        //    _transferButton.Click();
        //}

        //Test8
        public void FindHardTickets(string departureCityName, string arriveCityName, string secondCity)
        {
            Thread.Sleep(2000);
            _departureСityButton.SendKeys(departureCityName);
            _arrivalСityButton.SendKeys(arriveCityName);
            _departureDateButton.Click();
            Thread.Sleep(1000);
            _departureDateNextListButton.Click();
            _departureDateListButton.Click();
            _returnDateButton.Click();
            Thread.Sleep(1000);
            _returnDateListButton.Click();
            Thread.Sleep(1000);
            _hardTicketButton.Click();
            Thread.Sleep(1000);
            _secondCity.SendKeys(secondCity);
            _returnDateButton2.Click();
            Thread.Sleep(1000);
            _returnDateListButton2.Click();
            Thread.Sleep(1000);
            _findTicketsButton2.Click();
            Thread.Sleep(2000);
        }

        //public void OpenHelp()
        //{
        //    Thread.Sleep(2000);
        //    _helpWindow.Click();
        //}

        //Test11
        public void OpenBonus()
        {
            Thread.Sleep(2000);
            _bonusButton.Click();
            Thread.Sleep(2000);
        }

        //Test12
        public void OpenPopRoute()
        {
            Thread.Sleep(2000);
            _closCoockieButton.Click();
            Thread.Sleep(1000);
            _popRouteButton.Click();
            Thread.Sleep(2000);
        }
    }
}
