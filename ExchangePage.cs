using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using Xunit;

namespace SeleniumTest{




    class ExchangePage{

        
        By OrderEntityTab = By.XPath("//div[text()='Order Entry']");
        By AdvancedOrder = By.XPath("//div[text()='« Advanced Orders']");
       




       

        public void SelectOrderEntityAndNavigateToAdvancedOrder() {
            try{
                GenericUtils.driver.FindElement(OrderEntityTab).Click();
                GenericUtils.driver.FindElement(AdvancedOrder).Click();
            }catch (Exception e){
                throw e;
            }
        }


       






    }



}
