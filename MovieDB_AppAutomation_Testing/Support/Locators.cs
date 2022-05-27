using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
