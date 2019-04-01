using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using Xunit;

namespace SeleniumTest
{


    class HomePage
    {









        By Exchange = By.XPath("//span[text()='Exchange']");
        By LogoutBlock = By.XPath("//span[contains(@class,'username-in-display')]");
        By SignOut = By.XPath("//span[text()='Sign Out']");

        public void NavigateToExchagePage()
        {
            try
            {
                GenericUtils.driver.FindElement(Exchange).Click();
                Thread.Sleep(4000);
                string currenturl = GenericUtils.driver.Url;
                Assert.Contains("exchange", currenturl);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void UserLogout(){
            try{
                GenericUtils.driver.FindElement(LogoutBlock).Click();
                GenericUtils.driver.FindElement(SignOut).Click();
                Thread.Sleep(5000);
                string currenturl = GenericUtils.driver.Url;
                Assert.Contains("login", currenturl);
            }
            catch (Exception e){
                throw e;
            }
        }












    }




}
