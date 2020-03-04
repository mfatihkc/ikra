using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Pages;

namespace Main
{
    public class Base
    {
        public  Pages Pages { get; set; }
        public  Browser Browser { get; set; }

        public Base(BrowserType browserType)
        {
            Browser = new Browser(browserType);
            Pages = new Pages(Browser.Driver);
        }
    }
}
