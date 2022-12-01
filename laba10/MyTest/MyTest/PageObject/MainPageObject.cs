using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest.PageObject
{
    public class MainPageObject
    {
        private IWebDriver _webDriver;

        private readonly By quickQuestions = By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/a[4]");
        
        private readonly By departureCity = By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[1]/label[1]/input");
        private readonly By arriveCity = By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[2]/label[1]/input");
        private readonly By departureDate = By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[3]/label/span[3]");
        private readonly By needDepartureDate = By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[3]/div/div/div[2]/div[1]/div/div[3]/div[3]/div[6]/div");
        private readonly By arriveDate = By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[4]/label/span[3]");
        private readonly By needArriveDate = By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[1]/div[4]/div/div/div[2]/div[1]/div/div[3]/div[4]/div[6]/div");
        private readonly By findButton = By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div/div[1]/div[3]/a");

        public MainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public QuestionsPageObject FindQuestion()
        {
            _webDriver.FindElement(quickQuestions).Click();
            return new QuestionsPageObject(_webDriver);
        }

        public TicketPageObject FindTicket(string departureCityName, string arriveCityName)
        {
            _webDriver.FindElement(departureCity).SendKeys(departureCityName);
            Thread.Sleep(1000);
            _webDriver.FindElement(arriveCity).SendKeys(arriveCityName);
            Thread.Sleep(1000);
            _webDriver.FindElement(departureDate).Click();
            Thread.Sleep(1000);
            _webDriver.FindElement(needDepartureDate).Click();
            _webDriver.FindElement(arriveDate).Click();
            Thread.Sleep(1000);
            _webDriver.FindElement(needArriveDate).Click();
            Thread.Sleep(1000);
            _webDriver.FindElement(findButton).Click();
            return new TicketPageObject(_webDriver);
        }
    }
}
