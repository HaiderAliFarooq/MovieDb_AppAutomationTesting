using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace MovieDB_AppAutomation_Testing.Drivers
{
    public class AppiumDriver
    {
        public static AndroidDriver<AppiumWebElement> Init()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "21fcdc9cc70c7ece");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, @"C:\Users\ThinkPad\source\repos\MovieDB_AppAutomation_Testing\MovieDB_AppAutomation_Testing\ApkFiles\movies.apk");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "uiautomator2");

            return new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), driverOptions, TimeSpan.FromMinutes(10));
        }
    }
}
