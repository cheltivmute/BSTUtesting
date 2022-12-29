using GitHubAutomation.Steps;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;

namespace GitHubAutomation
{


    [TestFixture]
    public class SmokeTests
    {

        private Steps.Steps steps = new Steps.Steps();
        private const string deparutedepartureCityName = "Минск";
        private const string arriveCityName = "Москва";
        private const string nameCountry = "Швейцария";
        private const string answerText = "Перевозка животных";
        private const string secondCity = "Челябинск";
        private const string email = "shasha161280@gmail.com";
        private const string name = "Егор";
        private const string header = "Пожелание";
        private const string mess = "Всего хорошего!";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void OneCanFindAirTickets()
        {
            steps.FindAirTickets(deparutedepartureCityName, arriveCityName);
        }

        [Test]
        public void OneCanFindHotels()
        {
            steps.OpenHotelsPage();
            steps.FindFreeHotels(nameCountry);
        }

        [Test]
        public void OneCanFindRailwaysTickets()
        {
            steps.OpenRailwaysPage();
            steps.FindRailwaysTickets(deparutedepartureCityName, arriveCityName);
        }

        [Test]
        public void OneCanFindAnswersOnPopularQuestions()
        {
            steps.OpenPopularQuestionsPage();
            steps.FindAnswersPopQ();
        }

        [Test]
        public void OneCanSearchAnswerOnQuestions()
        {
            steps.OpenPopularQuestionsPage();
            steps.SearchAnswerQ(answerText);
        }

        ////Test6
        //[Test]
        //public void OneCanSearchTransfers()
        //{
        //    steps.OpenTransfersPage();
        //    steps.SearchTransfers(deparutedepartureCityName);
        //}

        //Test8
        [Test]
        public void OneCanFindHardAirTickets()
        {
            steps.FindHardAirTickets(deparutedepartureCityName, arriveCityName, secondCity);
        }

        ////Test9
        //[Test]
        //public void SendFeedBack()
        //{
        //    steps.OpenHelpPage();
        //    steps.SendFeed(email, name, header, mess);
        //}

        //Test11
        [Test]
        public void OneCanFindBonus()
        {
            steps.OpenBonusPage();
        }

        //Test12
        [Test]
        public void OneCanFindPopRoute()
        {
            steps.OpenPopRoutePage();
        }

        //Test13
        [Test]
        public void OneCanSearchPopRoute()
        {
            steps.OpenPopRoutePage();
            steps.SearchPopRoute(deparutedepartureCityName);
        }
    }
}
