using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Website
{
    public class Class1
    {
        public IWebDriver driver;

        [Test, Order(1)]
        public void Build()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/Ideliver/Downloads/Built1.html");
            driver.Manage().Window.Maximize();
        }

        [Test, Order(2)]
        public void Run()
        {
            driver.FindElement(By.Name("firstname")).SendKeys("iDeliver");
            driver.FindElement(By.Name("lastname")).SendKeys("iDeliver");
            driver.FindElement(By.XPath("//input[@value='Submit']")).Click();
            driver.Close();
            driver.Quit();
        }


    }
}
