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

        [FindsBy(How = How.XPath, Using = "//p[@class='start-home__btn-wrapper']/a[@class='button button--green button--large button--wide button--split-effect' and @href='/continue']")]
        private IWebElement startStudy;

        [FindsBy(How = How.XPath, Using = "//span[@class='btn ha-task-description-close']")]
        private IWebElement perform;

        [FindsBy(How = How.Id, Using = "server-check")]
        private IWebElement check;


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
            check.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }
}
