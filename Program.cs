using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using OpenQA.Selenium.Appium.iOS;
using NUnit.Framework;
using System.Threading;

namespace browserstack_biometric_ios_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            AppiumOptions caps = new AppiumOptions();


            // Set your BrowserStack access credentials
            caps.AddAdditionalCapability("browserstack.user", Environment.GetEnvironmentVariable("BROWSERSTACK_USERNAME"));
            caps.AddAdditionalCapability("browserstack.key", Environment.GetEnvironmentVariable("BROWSERSTACK_ACCESS_KEY"));

            // Set URL of the application under test
            caps.AddAdditionalCapability("app", "iOS_BiometricLogin");

            // Specify device and os_version
            caps.AddAdditionalCapability("device", "iPhone 11 Pro");
            caps.AddAdditionalCapability("os_version", "13");

            // Specify the platformName
            caps.PlatformName = "iOS";

            // Set other BrowserStack capabilities
            caps.AddAdditionalCapability("project", "First CSharp project");
            caps.AddAdditionalCapability("build", "CSharp iOS");
            caps.AddAdditionalCapability("name", "first_test");

            // Set biometric capabilities
            caps.AddAdditionalCapability("browserstack.enableBiometric", "true");

            // Initialize the remote Webdriver using BrowserStack remote URL
            // and desired capabilities defined above
            IOSDriver<IOSElement> driver = new IOSDriver<IOSElement>(
                new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);

            //IOSElement textOutput = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
            //    SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.AccessibilityId("Text Output"))
            //);

            // Assert.AreEqual(textOutput.Text, "hello@browserstack.com");
            IOSElement LogInButton = (IOSElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Name("Log In"))
            );
            LogInButton.Click();
            Thread.Sleep(3000);
            driver.ExecuteScript("browserstack_executor: {\"action\":\"biometric\", \"arguments\": {\"biometricMatch\":\"pass\"}}");
            driver.Quit();

        }
    }
}
