using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;

namespace Core
{

    public enum BrowserType
    {
        Multiple,
        Default,
        Chrome,
        Firefox
        //InternetExplorer,
        //Edge
    }
    public enum BrowserPage
    {
        Page1,
        Page2,
        Page3,
        
    }
    public class Browser
    {
        private string baseUrl = "https://www.google.com/";
        private IWebDriver webDriver;

        public Browser(BrowserType browsertype)
        {
            webDriver = GetBrowserInstance(browsertype);

            Goto(baseUrl);
        }

        private IWebDriver GetBrowserInstance(BrowserType browsertype)
        {
            switch (browsertype)
            {
                case BrowserType.Firefox:
                    return new FirefoxDriver();
                case BrowserType.Chrome:
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("--start-maximized");
                    return new ChromeDriver(options);
                //case BrowserType.InternetExplorer:
                //    return new InternetExplorerDriver();
                //case BrowserType.Edge:
                //    return new EdgeDriver();
                default:
                    return new ChromeDriver();
            }
        }

        public string Title => webDriver.Title;
        public void Forward()
        {
            webDriver.Navigate().Forward();
        }
        public void Back()
        {
            webDriver.Navigate().Back();
        }
        public void Refresh()
        {
            webDriver.Navigate().Refresh();
            Thread.Sleep(4000);
        }
        public IWebDriver Driver => webDriver;

        public string CurrentGetUrl => webDriver.Url;

        public void Goto(string url)
        {
            webDriver.Url = url;
        }
        public void Goto(BrowserPage browserPage)
        {
            string url = baseUrl;
            switch (browserPage)
            {
                case BrowserPage.Page1:
                    url += "";
                    break;
                case BrowserPage.Page2:
                    url += "";
                    break;
                case BrowserPage.Page3:
                    url += "";
                    break;
                default:
                    break;
            }
            webDriver.Url = url;
        }

        public void NewTabGoto(string url)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            js.ExecuteScript("window.open();");
            int last = webDriver.WindowHandles.Count - 1;
            webDriver.SwitchTo().Window(webDriver.WindowHandles[last].ToString());

            Goto(url);
        }
        public void NewTabGoto(BrowserPage browserPage)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            js.ExecuteScript("window.open();");
            int last = webDriver.WindowHandles.Count - 1;
            webDriver.SwitchTo().Window(webDriver.WindowHandles[last].ToString());

            Goto(browserPage);
        }
        public void Close()
        {
            webDriver.Close();
            webDriver.Dispose();
        }


    }
}
