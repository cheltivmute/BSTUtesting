using GitHubAutomation.Pages;
using OpenQA.Selenium;

namespace GitHubAutomation.Steps
{
    public class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        //Test2
        public void OpenHotelsPage()
        {
            Pages.MainPage main = new Pages.MainPage(driver);
            main.OpenPage();
            main.OpenHotels();
        }

        //Test3
        public void OpenRailwaysPage()
        {
            Pages.MainPage main = new Pages.MainPage(driver);
            main.OpenPage();
            main.OpenRailways();
        }

        //Test4-5
        public void OpenPopularQuestionsPage()
        {
            Pages.MainPage main = new Pages.MainPage(driver);
            main.OpenPage();
            main.OpenPopularQuestions();
        }

        ////Test6
        //public void OpenTransfersPage()
        //{
        //    Pages.MainPage main = new Pages.MainPage(driver);
        //    main.OpenPage();
        //    main.OpenTransfers();
        //}

        ////Test9
        //public void OpenHelpPage()
        //{
        //    Pages.MainPage main = new Pages.MainPage(driver);
        //    main.OpenPage();
        //    main.OpenHelp();
        //}

        //Test11
        public void OpenBonusPage()
        {
            Pages.MainPage main = new Pages.MainPage(driver);
            main.OpenPage();
            main.OpenBonus();
        }

        //Test12
        public void OpenPopRoutePage()
        {
            Pages.MainPage main = new Pages.MainPage(driver);
            main.OpenPage();
            main.OpenPopRoute();
        }



        //Test1
        public void FindAirTickets(string depCity, string arrCity)
        {
            Pages.MainPage main = new Pages.MainPage(driver);
            main.OpenPage();
            main.FindTickets(depCity, arrCity);
        }

        //Test2
        public void FindFreeHotels(string nameCountry)
        {
            Pages.HotelsPage hotelsPage = new Pages.HotelsPage(driver);
            hotelsPage.FindHotels(nameCountry);
        }

        //Test3
        public void FindRailwaysTickets(string depCity, string arrCity)
        {
            Pages.RailwaysPage railwaysPage = new Pages.RailwaysPage(driver);
            railwaysPage.FindTickets(depCity, arrCity);
        }

        //Test4
        public void FindAnswersPopQ()
        {
            Pages.PopularQuestionsPage popularQuestionsPage = new Pages.PopularQuestionsPage(driver);
            popularQuestionsPage.FindAnswers();
        }

        //Test5
        public void SearchAnswerQ(string answerText)
        {
            Pages.PopularQuestionsPage popularQuestionsPage = new Pages.PopularQuestionsPage(driver);
            popularQuestionsPage.SearchAnswer(answerText);
        }

        ////Test6
        //public void SearchTransfers(string nameCountry)
        //{
        //    Pages.TransfersPage transfersPage = new Pages.TransfersPage(driver);
        //    transfersPage.FindCar(nameCountry);
        //}

        //Test8
        public void FindHardAirTickets(string depCity, string arrCity, string secCity)
        {
            Pages.MainPage main = new Pages.MainPage(driver);
            main.OpenPage();
            main.FindHardTickets(depCity, arrCity, secCity);
        }

        ////Test9
        //public void SendFeed(string email, string name, string header, string mess)
        //{
        //    Pages.FeedbackPage feed = new Pages.FeedbackPage(driver);
        //    feed.SendHelp(email, name, header, mess);
        //}

        //Test13
        public void SearchPopRoute(string nameCountry)
        {
            Pages.PopularRoutesPage popularRoutesPage = new Pages.PopularRoutesPage(driver);
            popularRoutesPage.FindPopRoutes(nameCountry);
        }
    }
}
