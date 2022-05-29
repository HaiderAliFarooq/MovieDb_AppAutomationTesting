using MovieDB_AppAutomation_Testing.Support;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;


namespace MovieDB_AppAutomation_Testing.StepDefinitions
{
    [Binding]
    public class MovieViewDetailsStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AppiumWebElement> _driver;
        private readonly Locators _locators;
        public MovieViewDetailsStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>();
            _locators = new Locators(_driver);
        }

        [Given(@"I am on the main movies list screen")]
        public void GivenIAmOnTheMainMoviesListScreen()
        {
            var search_bar = _locators.SearchBar;
            Assert.True(search_bar.Displayed);
        }

        [When(@"I search for a movie whose name starts with ""([^""]*)""")]
        public void WhenISearchForAMovieWhoseNameStartsWith(string movieName)
        {
            var search_bar = _locators.SearchBar;
            search_bar.Click();
            search_bar.SendKeys(movieName);
        }

        [When(@"I select the second option from the result list of movies in search box")]
        public void WhenISelectTheSecondOptionFromTheResultListOfMoviesInSearchBox()
        {
            var searchresults = _locators.SearchResult;
            searchresults[1].Click();
        }

        [When(@"I tap the Show details link")]
        public void WhenITapTheShowDetailsLink()
        {
            var showDetails = _locators.ShowDetails;
            showDetails.Click();
        }

        [Then(@"I should see the overview of the movie on details page")]
        public void ThenIShouldSeeTheOverviewOfTheMovieOnDetailsPage()
        {
            var overview = _locators.DetailsOverview;
            Assert.True(overview.Text is not null);
        }
    }
}
