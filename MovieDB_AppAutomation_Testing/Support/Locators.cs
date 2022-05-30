using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System.Collections.ObjectModel;

namespace MovieDB_AppAutomation_Testing.Support
{
    public class Locators
    {
        private readonly AndroidDriver<AppiumWebElement> _driver;
        public Locators(AndroidDriver<AppiumWebElement> driver)
        {
            _driver = driver;
        }

        public IWebElement SearchBar => _driver.FindElementById("com.insiderser.android.movies:id/search_bar_text");

        public ReadOnlyCollection<AppiumWebElement> SearchResult => _driver.FindElementsById("com.insiderser.android.movies:id/body");
        
        public IWebElement ShowDetails => _driver.FindElementById("com.insiderser.android.movies:id/show_details");
        
        public IWebElement DetailsOverview => _driver.FindElementById("com.insiderser.android.movies:id/overview");

        public IWebElement FavoritesStar => _driver.FindElementById("com.insiderser.android.movies:id/favourite_star");

        public IWebElement BackScreenArrow => _driver.FindElementByXPath("//android.widget.ImageButton[@content-desc=\"Navigate up\"]");

        public IWebElement ThreeDotMenu => _driver.FindElementById("com.insiderser.android.movies:id/left_action");

        public ReadOnlyCollection<AppiumWebElement> MenuFav => _driver.FindElementsByClassName("android.widget.CheckedTextView");
        
        public ReadOnlyCollection<AppiumWebElement> FavMovies => _driver.FindElementsById("com.insiderser.android.movies:id/image");
        
        public IWebElement DetailPage => _driver.FindElementById("com.insiderser.android.movies:id/title");
    }
}
