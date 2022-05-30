using MovieDB_AppAutomation_Testing.Support;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace MovieDB_AppAutomation_Testing.StepDefinitions
{
    [Binding]
    public class MovieFavoritesScreenStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AppiumWebElement> _driver;
        private readonly Locators _locators;
        public MovieFavoritesScreenStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>();
            _locators = new Locators(_driver);
        }
        [When(@"I open the details page of a movie like ""([^""]*)"" and mark the movie as favorite")]
        public void WhenIOpenTheDetailsPageOfAMovieLikeAndMarkTheMovieAsFavorite(string movieName)
        {
            var search_bar = _locators.SearchBar;
            search_bar.Click();
            search_bar.SendKeys(movieName);
            var searchresults = _locators.SearchResult;
            searchresults[0].Click();
            _locators.FavoritesStar.Click();
            _locators.BackScreenArrow.Click();
        }

        [When(@"I navigate to favorites screen via menu")]
        public void WhenINavigateToFavoritesScreenViaMenu()
        {
            _locators.ThreeDotMenu.Click();
            var menuItems = _locators.menuFav;
            menuItems[3].Click();
        }

        [Then(@"I should see the movie ""([^""]*)"" listed on the Favorites screen")]
        public void ThenIShouldSeeTheMovieListedOnTheFavoritesScreen(string movieName)
        {
            var listFavMovies =_locators.favMovies;
            listFavMovies[0].Click();
            Assert.True(_locators.detailPage.Text == movieName);
            //Clean: remove the favourite movie to make the testcase reuseable
            _locators.FavoritesStar.Click();
        }
    }
}
