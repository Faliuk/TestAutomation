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
    class SettingsPage
    {
        private IWebDriver driver;
        private const string BASE_URL = "https://htmlacademy.ru";

        [FindsBy(How = How.XPath, Using = "//span[@class='main-nav__username']")]
        private IWebElement profile;

        [FindsBy(How = How.XPath, Using = "//a[@class='secondary-nav__item-link' and @href='/profile/settings']")]
        private IWebElement settings;

        [FindsBy(How = How.XPath, Using = "//label[@class='file__label button button--transparent button--wide']")]
        private IWebElement fileSelect;

        [FindsBy(How = How.XPath, Using = "//div[@class='form__group']/button[@class='button button--wide']")]
        private IWebElement SaveButtinPicture;

        [FindsBy(How = How.XPath, Using = "//a[@class='secondary-nav__sub-item-link' and @href='/profile/settings/access']")]
        private IWebElement accesPassword;

        [FindsBy(How = How.Id, Using = "change-password-password")]
        private IWebElement passwordChange;

        [FindsBy(How = How.Id, Using = "new_password")]
        private IWebElement passwordNew;

        [FindsBy(How = How.Id, Using = "new_password_2")]
        private IWebElement passwordNew2;

        [FindsBy(How = How.XPath, Using = "//button[@class='button button--wide']")]
        private IWebElement changeButton;

        public SettingsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Thread.Sleep(TimeSpan.FromSeconds(5));
            profile.Click();
            settings.Click();
        }

        public void UploadPicture(string picturePath)
        {
            fileSelect.SendKeys(picturePath);
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        public void ConfirmPicture()
        {
            SaveButtinPicture.Click();
        }


        public void ChangePassword(string password, string newpassword)
        {
            accesPassword.Click();
            passwordChange.SendKeys(password);
            passwordNew.SendKeys(newpassword);
            passwordNew2.SendKeys(newpassword);
            changeButton.Click();
        }


    }
}
