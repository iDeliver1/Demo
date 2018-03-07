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
            driver.Navigate().GoToUrl(@"E:\Sourabh_CSharp\repo\GitHub_LeanFT\Built1.html");
            driver.Manage().Window.Maximize();
                try
                {
                    driver.FindElement(By.XPath("//xhtml:h1[contains(text(),'File not found')]"));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
        }

        [Test, Order(2)]
        public void Run()
        {
            string[] Value = { "John", "West" };
            int i=0;

            IList<IWebElement> lst = driver.FindElements(By.XPath("//input[@type='text']"));
                foreach(IWebElement element in lst)
                {
                    try
                    {
                        if (element.Displayed)
                        {
                            element.SendKeys(Value[i]);
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                i++;
                }
            driver.FindElement(By.XPath("//input[@value='Submit']")).Click();
            driver.Close();
            driver.Quit();
        }
    }
}
