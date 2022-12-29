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
    public class FeedbackPage
    {
        private IWebDriver _driver;

        private IWebElement _sendMessageButton => _driver.FindElement(By.CssSelector("body > div.x-cmsFeedback.x-cmsFeedback-userForm.x-cmsFeedback-notAuthorized > div > div.x-cmsFeedback_block.x-cmsFeedback_block-main > div > nav > a.x-cmsFeedback_tab.x-cmsFeedback_tab-feedbackTab"));
        private IWebElement _emailButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/form/div[1]/input"));
        private IWebElement _nameButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/form/div[2]/input"));
        private IWebElement _headerMessButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div[3]/form/div[1]/input"));
        private IWebElement _messageTextButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div[3]/form/div[2]/textarea"));
        private IWebElement _sendButton => _driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div[3]/form/div[3]/input"));

        public FeedbackPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void SendHelp(string email, string name, string header, string mess)
        {
            //Thread.Sleep(3000);
            //_sendMessageButton.Click();
            Thread.Sleep(3000);
            _emailButton.SendKeys(email);
            _nameButton.SendKeys(name);
            _headerMessButton.SendKeys(header);
            _messageTextButton.SendKeys(mess);
            Thread.Sleep(1000);
            //_sendButton.Click();
            //Thread.Sleep(1000);
        }
    }
}
