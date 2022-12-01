using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest.PageObject
{
    public class QuestionsPageObject
    {
        private IWebDriver _webDriver;

        private readonly By needQuestion = By.XPath("/html/body/div[1]/section/section/div[1]/div[4]/ul/li[5]/a");

        public QuestionsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public NeededQuestion ClickNeedQuestion()
        {
            Thread.Sleep(2000);
            _webDriver.FindElement(needQuestion).Click();
            return new NeededQuestion(_webDriver);
        }
    }
}
