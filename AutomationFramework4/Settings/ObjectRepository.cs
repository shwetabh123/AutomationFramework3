using AutomationFramework4.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework4.Settings
{
    public class ObjectRepository
    {


        public static IConfig Config { get; set; }

        public  IWebDriver Driver { get; set; }




    }
}
