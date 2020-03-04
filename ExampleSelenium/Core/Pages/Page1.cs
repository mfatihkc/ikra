using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Core.Pages
{
    public class Page1
    {
        private readonly IWebDriver webDriver;
        private IWebElement searchElement;
        private IWebElement btnSearchElement;
        private IWebElement btnLucky;

        public Page1(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            
        }
        public  void Search(string q)
        {
            btnLucky = webDriver.FindWaitIsVisible(By.XPath("//*[@id=\"tsf\"]/div[2]/div[1]/div[3]/center/input[2]"));
            btnLucky.ClickOnIt(webDriver);

            searchElement = webDriver.FindWaitIsVisible(By.Id("searchinput"));
            searchElement.ClickOnIt(webDriver);
            searchElement.SendKeys(q);;
            searchElement.SendKeys(Keys.Enter);


        }
    }
}
