using AutomationFramework4.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework4.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
       

        string GetUsername();


        string GetPassword();

        string GetUrlone();
        string GetUrltwo();

        string GetUrlthree();
        string GetUrlfour();

        int GetPageLoadTimeOut();
        int GetElementLoadTimeOut();



    }
}
