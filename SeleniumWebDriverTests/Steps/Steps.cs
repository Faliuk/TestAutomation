using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
namespace SeleniumWebDriverTests
{
    public class Steps
    {
        IWebDriver driver;
        IWebElement loggedUsername;

        public void Init()
        {
            driver = DDriver.GetInstance();
        }


        public void LogIn(string login, string password)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.OpenButtonClick();
            mainPage.Open(login, password);
        }


        public void StartCource()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.StartCource();
        }



        public void LogOut()
        {
            try
            {
                Pages.MainPage mainPage = new Pages.MainPage(driver);
                mainPage.OpenPage();
                mainPage.LogOut();             
            }
            catch
            {

            }
        }   

        public bool ChahgeProfilePic(string picture)
        {
            try
            {
                Pages.SettingsPage settingsPage = new Pages.SettingsPage(driver);
                settingsPage.OpenPage();              
                settingsPage.UploadPicture(picture);
                settingsPage.ConfirmPicture();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void ProfileUser(string FirstName, string LastName, string birthdate)
        {
            Pages.ProfilePage profilesPage = new Pages.ProfilePage(driver);
            profilesPage.OpenPage();
            profilesPage.OpenSetting();
            profilesPage.WriteProfilePage(FirstName, LastName, birthdate);
        }

        public void DecorText()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.StartDecor();
        }

        public void ChangePassword(string password, string newpassword)
        {
            Pages.SettingsPage settingPage = new Pages.SettingsPage(driver);
            settingPage.OpenPage();
            settingPage.ChangePassword(password, newpassword);
        }

        public void StartStudy()
        {
            Pages.StudyPage studyPage = new Pages.StudyPage(driver);
            studyPage.OpenPage();
            studyPage.StartStudy();
        }
    }
}
