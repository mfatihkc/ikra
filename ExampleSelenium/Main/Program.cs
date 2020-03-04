using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Pages;
using OpenQA.Selenium;
using Core.Pages;
namespace Main
{
    class Program
    {

        static void Main(string[] args)
        {
            Base b=new Base(BrowserType.Chrome);
            b.Pages.Page1.Search("Deneme1");
            
            b.Browser.NewTabGoto("https://www.google.com/");
            b.Pages.Page2.Search("Deneme2");


            b.Browser.NewTabGoto("https://www.google.com/");
            b.Pages.Page3.Search("Deneme3");
        }

       
    }
}
