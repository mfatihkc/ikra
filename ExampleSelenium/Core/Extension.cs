using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core
{
    public static class Extension
    {

        public static void ClickOnIt(this IWebElement element, IWebDriver webDriver, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }


        public static IWebElement FindWaitIsVisible(this IWebDriver driver, By by, int timeoutInSeconds = 10)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
                return wait.Until(d => d.FindElement(by));
            }
            catch { return null; }
        }


        public static ReadOnlyCollection<IWebElement> FindListWaitIsVisible(this IWebDriver driver, By by, int timeoutInSeconds = 5)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(d => d.FindElements(by));
            }
            catch { return null; }

        }


    }
}
