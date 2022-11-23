using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Formtesting
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        [SetUp]
        public void Intializedtest()
        {
            driver.Navigate().GoToUrl("https://www.workingtalent.nl/vacatures/it-traineeship-software-testing");

        }

        [Test]
        public void ExecuteTest()
        {
            // Entertext(element,value,type)

            /* IWebElement element = driver.FindElement(By.Name("naam"));
             element.SendKeys("priti");
             IWebElement emailelement = driver.FindElement(By.Name("email"));
             emailelement.SendKeys("pritiv.acem@gmail.com");
              IWebElement phonenumber = driver.FindElement(By.Name("telefoonnummer"));
             phonenumber.SendKeys("0675467482");
            */
            SeleniumSetMethod.EnterText(driver, "Name", "priti", "naam");
            SeleniumSetMethod.EnterText(driver, "Name", "pritiv.acem@gmail.com", "email");
           
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
