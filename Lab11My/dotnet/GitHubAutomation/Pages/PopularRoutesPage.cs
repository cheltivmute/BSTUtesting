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
    public class PopularRoutesPage
    {
        private IWebDriver _driver;

        //Test13 
        private IWebElement _findRouteButton => _driver.FindElement(By.XPath("/html/body/div[1]/section/section/div/div[2]/div/form/input"));

        public PopularRoutesPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void FindPopRoutes(string nameCountry)
        {
            Thread.Sleep(1000);
            _findRouteButton.SendKeys(nameCountry);
            Thread.Sleep(2000);
        }
    }
}
