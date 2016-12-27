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
    class ProfilePage
    {
        private IWebDriver driver;
        private const string BASE_URL = "https://htmlacademy.ru";

        [FindsBy(How = How.XPath, Using = "//span[@class='main-nav__username']")]
        private IWebElement profile;

        [FindsBy(How = How.XPath, Using = "//a[@class='secondary-nav__item-link' and @href='/profile/settings']")]
        private IWebElement setings;

        [FindsBy(How = How.Id, Using = "firstname")]
        private IWebElement FirstNameTexbox;

        [FindsBy(How = How.Id, Using = "lastname")]
        private IWebElement LastNameTexbox;

        //[FindsBy(How = How.XPath, Using = "//input[@value='m']")]
        //private IWebElement gender;

        [FindsBy(How = How.Id, Using = "birthdate")]
        private IWebElement birthdateTexbox;

        [FindsBy(How = How.XPath, Using = "//div[@class='form__group form__group--controls']/button[@class='button button--wide']")]
        private IWebElement saveProfile;

        [FindsBy(How = How.ClassName, Using = "alert  alert--green")]
        private IWebElement Change;



        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void OpenSetting()
        {
            profile.Click();
            setings.Click();
        }
        
        public void WriteProfilePage(string FirstName, string LastName, string birthdate)
        {
            FirstNameTexbox.SendKeys(FirstName);
            LastNameTexbox.SendKeys(LastName);            
            birthdateTexbox.SendKeys(birthdate);
            saveProfile.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        public bool isProfileChange()
        {
            
            return Change.Text.Equals("Данные обновлены");
        }
        
    }
}
