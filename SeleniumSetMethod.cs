using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Formtesting
{
    class SeleniumSetMethod
    {
        // Enter text
        public static void EnterText(IWebDriver driver,string element, string value, string elementType)
        {
            if(elementType == "Name")
            driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
        }
        // Click into a button,checkbox,option etc
        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).Click();

        }
        // Selecting Dropdown contrl
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Name")
               new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementType == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
        }
    }
}
