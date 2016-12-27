using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace SeleniumWebDriverTests.Pages
{
    class StudyPage
    {
        private IWebDriver driver;
        private const string BASE_URL = "https://htmlacademy.ru";

        [FindsBy(How = How.XPath, Using = "//a[@class='button button--green button--large button--wide button--split-effect']")]
        private IWebElement startStudy;

        [FindsBy(How = How.XPath, Using = "//span[@class='btn ha-task-description-close']")]
        private IWebElement perform;

        [FindsBy(How = How.XPath, Using = "//span[@class='btn']")]
        private IWebElement check;

        [FindsBy(How = How.ClassName, Using = "label ha-goal-label label-important")]
        private IWebElement redColor;

        public StudyPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void StartStudy()
        {
            startStudy.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            perform.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            check.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        public bool IsStartStudy()
        {
            return redColor.Text.Equals("Цель 1");
        }
    }
}
