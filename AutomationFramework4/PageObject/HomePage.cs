using AutomationFramework4.Utility;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationFramework4.PageObject
{

    [TestFixture]
    public class HomePage :BasePage
    {
      


    
        private By Markets = By.XPath("(//a[@href='/markets'])[1]");

        private By News = By.XPath("(//a[@href='/news'])[1]");

        private By Industry = By.XPath("(//a[@href='/industry'])[1]");

        private By Jobs = By.XPath(" //a[@href='/jobs']");


      


        public void clickonMarkets()
        {


            // ObjectRepository.Driver.FindElement(HomePageLoginButton).Click();
            click(Markets);

        }


        public void clickonNews()
        {


            // ObjectRepository.Driver.FindElement(HomePageLoginButton).Click();
            click(News);

        }


        public void clickonIndustry()
        {


            // ObjectRepository.Driver.FindElement(HomePageLoginButton).Click();
            click(Industry);

        }
        public void clickonJobs()
        {


            // ObjectRepository.Driver.FindElement(HomePageLoginButton).Click();
            click(Jobs);

        }



    }
}
