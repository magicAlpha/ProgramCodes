using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest
{
    class GenericUtils
    {
        public static IWebDriver driver;



        public static void LounchBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\harishchandra.yadav\\source\\repos\\SeleniumTest\\SeleniumTest\\Lib");
            driver.Navigate().GoToUrl("https://apexwebqa.azurewebsites.net/login");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }




        public void SelectByVisibleText(IWebElement we, string val)
        {
            try { 
            SelectElement selectobj = new SelectElement(we);
            selectobj.SelectByText(val);
            }
            catch (Exception)
            {

            }
        }


        public void Sendkeys(IWebElement we, string val)
        {
            we.Clear();
            we.SendKeys(val);
        }


        public void Click(IWebElement we)
        {
            we.Click();
        }


        public void windowhandles(IWebDriver driver, string title){
            try
            {
                ReadOnlyCollection<string> windows = driver.WindowHandles;
                foreach (string window in windows)
                {
                    var str = driver.SwitchTo().Window(window).Title;
                    if (str.Contains(title))
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }













    }
}
