using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Text;

namespace project4
{
    
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();

            using(var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.project4.com");
                var searchBox = driver.FindElementById("header");
                Assert.IsNotNull(searchBox);
                //Console.Read();

            }
        }
    }
}


