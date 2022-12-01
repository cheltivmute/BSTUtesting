using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest.PageObject
{
    public class TicketPageObject
    {
        private IWebDriver _webDriver;

        public TicketPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
