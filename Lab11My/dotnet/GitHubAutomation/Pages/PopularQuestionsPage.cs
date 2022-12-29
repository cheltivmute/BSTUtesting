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
    public class PopularQuestionsPage
    {
        private IWebDriver _driver;

        //Test4
        private IWebElement _question => _driver.FindElement(By.XPath("/html/body/div[1]/section/section/div[1]/div[4]/ul/li[5]"));

        //Test4
        private IWebElement _searchButton => _driver.FindElement(By.XPath("/html/body/div[1]/section/section/div[1]/div[2]/div[1]/input"));
        private IWebElement _searchQuestion => _driver.FindElement(By.XPath("/html/body/div[1]/section/section/div[1]/div[3]/div/ul/li[1]/a"));

        public PopularQuestionsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void FindAnswers()
        {
            Thread.Sleep(2000);
            _question.Click();
            Thread.Sleep(2000);
        }

        public void SearchAnswer(string answer)
        {
            Thread.Sleep(2000);
            _searchButton.SendKeys(answer);
            Thread.Sleep(1000);
            _searchQuestion.Click();
            Thread.Sleep(2000);
        }
    }
}
