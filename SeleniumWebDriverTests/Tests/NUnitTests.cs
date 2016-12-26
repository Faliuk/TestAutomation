using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumWebDriverTests
{
    class NUnitTests
    {
        private Steps step = new Steps();

        private const string login = "Testcase@mail.ru";
        private const string password = "testcase";
        private const string passwordnew = "testcase";
        private string picture = Path.GetFullPath(@"SeleniumWebDriverTests\\Data\\Pictures\\av1.png");

        private const string FirstName = "Test";
        private const string LastName = "Test";
        private const string birthdate = "01.01.1990";

        private const string emailFriend = "testtest@mail.ru";


        [SetUp]
        public void Init()
        {
            step.Init();
        }



        [Test]
        public void LogInTest()
        {
            step.LogIn(login, password);     
        }

        

        [Test]
        public void StartCource()
        {
            step.LogIn(login, password);
            step.StartCource();
        }

        [Test]
        public void ChahgeProfilePic()
        {
            step.LogIn(login, password);
            Assert.True(step.ChahgeProfilePic(picture));
            
        }


        [Test]
        public void ProfileTest()
        {
            step.LogIn(login, password);
            step.ProfileUser(FirstName, LastName, birthdate);
        }


        [Test]
        public void DecorTest()
        {
            step.LogIn(login, password);
            step.DecorText();    
        }


        [Test]
        public void ChangePasswordTest()
        {
            step.LogIn(login, password);
            step.ChangePassword(password, passwordnew);
        }

        [Test]
        public void StartStudy()
        {
            step.LogIn(login, password);
            step.StartStudy();
        }

        [Test]
        public void ExitTest()
        {
            step.LogIn(login, password);
            step.LogOut();
        }


        [TearDown]
        public void EndTest()
        {
            step.LogOut();
        }
    }
}
