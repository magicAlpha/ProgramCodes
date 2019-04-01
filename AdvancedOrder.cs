using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumTest
{
    class AdvancedOrder
    {
        By BuyTab = By.XPath("//div[text()='Buy']");
        By SellTab = By.XPath("//div[text()='Sell']");
        By Instrument = By.Name("instrument");
        By OrderType = By.Name("orderType");
        By Ordersize = By.Name("quantity");
        By LimitPrice = By.Name("limitPrice");
        By DisplayQuntity = By.Name("displayQuantity");
        By PlaceByOrder = By.XPath("//button[text()='Place Buy Order']");




        public void SelectBuyOrSellTab(string buyorsell)
        {
            try
            {
                if (buyorsell.Equals("Buy"))
                {
                    GenericUtils.driver.FindElement(BuyTab).Click();
                }
                else if(buyorsell.Equals("Sell"))
                {
                    GenericUtils.driver.FindElement(SellTab).Click();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public void PlaceBuyOrderWithReserveOrderType(string instruments, string ordertype, string ordersize, string limitprice, string displayquantity)
        {
            try
            {
                GenericUtils gu = new GenericUtils();
                IWebElement instrumet = GenericUtils.driver.FindElement(Instrument);
                gu.SelectByVisibleText(instrumet, instruments);
                IWebElement ordertyp = GenericUtils.driver.FindElement(OrderType);
                gu.SelectByVisibleText(ordertyp, ordertype);
                IWebElement ordersiz = GenericUtils.driver.FindElement(Ordersize);
                gu.Sendkeys(ordersiz, ordersize);
                IWebElement limitpric = GenericUtils.driver.FindElement(LimitPrice);
                gu.Sendkeys(limitpric, limitprice);
                IWebElement displayquntity = GenericUtils.driver.FindElement(DisplayQuntity);
                gu.Sendkeys(displayquntity, displayquantity);
                IWebElement placebuyorder = GenericUtils.driver.FindElement(PlaceByOrder);
                gu.Click(placebuyorder);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void PlaceBuyOrderWithImmediateOrCancelType(string instruments, string ordertype, string ordersize, string limitprice)
        {
            try
            {
                GenericUtils gu = new GenericUtils();
                IWebElement instrumet = GenericUtils.driver.FindElement(Instrument);
                gu.SelectByVisibleText(instrumet, instruments);
                IWebElement ordertyp = GenericUtils.driver.FindElement(OrderType);
                gu.SelectByVisibleText(ordertyp, ordertype);
                IWebElement ordersiz = GenericUtils.driver.FindElement(Ordersize);
                gu.Sendkeys(ordersiz, ordersize);
                IWebElement limitpric = GenericUtils.driver.FindElement(LimitPrice);
                gu.Sendkeys(limitpric, limitprice);
                IWebElement placebuyorder = GenericUtils.driver.FindElement(PlaceByOrder);
                gu.Click(placebuyorder);
            }
            catch (Exception e)
            {
                throw e;
            }
        }













    }
}
