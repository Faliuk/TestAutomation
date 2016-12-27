using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace SeleniumWebDriverTests.Pages
{
    class MainPage
    {
        private IWebDriver driver;

        private const string BASE_URL = "https://htmlacademy.ru";

        [FindsBy(How = How.XPath, Using = "//li[@itemprop='name']/a[@href='/login?redirect_url=/']")]
        private IWebElement open_button;

        [FindsBy(How = How.Id, Using = "login-email")]
        private IWebElement loginTextbox;

        [FindsBy(How = How.Id, Using = "login-password")]
        private IWebElement passwordTextbox;

        [FindsBy(How = How.XPath, Using = "//input[@class='button button--full-width' and @data-submit-text='Вхожу…' ]")]
        private IWebElement buttonSubmit;

        [FindsBy(How = How.XPath, Using = "//a[@class='main-nav__link' and @href='/program']")]
        private IWebElement buttonCourse;

        [FindsBy(How = How.XPath, Using = "//a[@class='button button--green button--split-effect']")]
        private IWebElement buttonStart;

        [FindsBy(How = How.XPath, Using = "//a[@class='main-nav__link' and @href='/logout?redirect_url=/profile/id342239']")]
        private IWebElement logoutButton;

        [FindsBy(How = How.XPath, Using = "//a[@class='curriculum__to-course-link' and @href='/courses/43']")]
        private IWebElement textDecor;

        [FindsBy(How = How.XPath, Using = "//a[@href='/continue/course/43']")]
        private IWebElement buttonPlay;

        [FindsBy(How = How.LinkText, Using = "Test Test")]
        private IWebElement Account;

        [FindsBy(How = How.LinkText, Using = "Как уже говорилось")]
        private IWebElement Cource;

        [FindsBy(How = How.LinkText, Using = "Оформление текста, часть 1")]
        private IWebElement Decor;

        [FindsBy(How = How.ClassName, Using = "//a[@class='main-nav__link' and @href='/login?redirect_url=/']")]
        private IWebElement logOut;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenButtonClick()
        {
            open_button.Click();
        }

        public void Open(string login, string password)
        {
            loginTextbox.SendKeys(login);
            passwordTextbox.SendKeys(password);
            buttonSubmit.Click();
        }

        public bool isAccountButtonExists()
        {
            return Account.Text.Equals("Test Test");
        }

        public void StartCource()
        {
            buttonCourse.Click();
            buttonStart.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        public bool isStartCource()
        {
            return Cource.Text.Equals("Как уже говорилось");
        }


        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        public void OpenPostEditor()
        {
            open_button.Click();
        }

        public void Login(string username, string password)
        {
            
            loginTextbox.SendKeys(username);
            passwordTextbox.SendKeys(password);
            buttonSubmit.Click();
        }

        public void LogOut()
        {
            logoutButton.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public bool IsLogOut()
        {
            return logOut.Text.Equals("Войти");
        }


        public void StartDecor()
        {
            buttonCourse.Click();
            textDecor.Click();
            buttonPlay.Click();
        }

        public bool IsStartDecor()
        {
            return Decor.Text.Equals("Оформление текста, часть 1");
        }


    }
}
