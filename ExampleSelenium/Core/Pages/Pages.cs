using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Core.Pages
{
    
    public class Pages
    {
        private readonly IWebDriver webDriver;

        public Pages(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public Page1 Page1 => new Page1(webDriver);
        public Page2 Page2 => new Page2(webDriver);
        public Page3 Page3 => new Page3(webDriver);
        public string CurrentGetUrl => webDriver.Url;
    }
}
