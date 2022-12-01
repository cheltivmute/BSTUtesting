using MyTest.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using static OpenQA.Selenium.PrintOptions;

namespace MyTest
{
    public class Tests
    {
        private IWebDriver _webDriver;
        
        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl("https://www.anywayanyday.com/");
        }

        [Test]
        public void FindQuestions()
        {
            var mainPage = new MainPageObject(_webDriver);
            mainPage
                .FindQuestion()
                .ClickNeedQuestion();

            Thread.Sleep(3000);
        }

        [Test]
        public void SearchQuestion()
        {
            var mainPage = new MainPageObject(_webDriver);
            mainPage.FindTicket(InputFields.nameDepartureCity, InputFields.nameArriveCity);

            Thread.Sleep(10000);
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}