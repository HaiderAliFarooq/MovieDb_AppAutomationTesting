using MovieDB_AppAutomation_Testing.Drivers;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace MovieDB_AppAutomation_Testing.Support
{
    [Binding]
    public class SupportHelper
    {
        private readonly ScenarioContext _scenarioContext;
        public SupportHelper(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void Initialize()
        {
            var driver = AppiumDriver.Init();
            _scenarioContext.Set(driver);
        }

        [AfterScenario]
        public void CleanUp()
        {
            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().Quit();
        }
    }
}
