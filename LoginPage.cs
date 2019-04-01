using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumTest
{
    class LoginPage
    {


        By UserName = By.Name("username");
        By Password = By.Name("password");
        By Server = By.Name("tradingServer");
        By LogIn = By.XPath("//button[@type='submit']");





        public void Fn_ValidLogin(string userna,string pass,string serv){
            try {
                GenericUtils gu=new GenericUtils();
                IWebElement server = GenericUtils.driver.FindElement(Server);
                gu.SelectByVisibleText(server, serv);
                IWebElement username=GenericUtils.driver.FindElement(UserName);
                gu.Sendkeys(username, userna);
                IWebElement password = GenericUtils.driver.FindElement(Password);
                gu.Sendkeys(password, pass);
                IWebElement login = GenericUtils.driver.FindElement(LogIn);
                gu.Click(login);
            }catch (Exception e){
                throw e;
            }
        }








    }
}
