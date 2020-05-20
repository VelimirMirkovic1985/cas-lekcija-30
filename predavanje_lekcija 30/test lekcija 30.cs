using System;
using NUnit.Framework;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework.Internal;

namespace predavanje_lekcija_30
{
    class test_lekcija_30
    {

        IWebDriver driver;

        WebDriverWait wait;

        private string TestData_Email = ("Drgoljub@gmail.com");
        private string TestData_password = ("MnogomijeDrago1");
        

        
        [Test]
        public void Registration()
        {
            Navigate("http://shop.qa.rs/");

            IWebElement linkRegistrer = driver.FindElement(By.LinkText("Register"));
            if(linkRegistrer.Enabled && linkRegistrer.Displayed)
            {
                linkRegistrer.Click();
            }

            IWebElement inputFirstName = driver.FindElement(By.Name("ime"));
            if(inputFirstName.Displayed && inputFirstName.Enabled)
            {
                inputFirstName.SendKeys("Milomir");
            }

            IWebElement inputLasttName = driver.FindElement(By.Name("prezime"));
            if(inputLasttName.Displayed && inputLasttName.Enabled)
            {
                inputLasttName.SendKeys("Mirovic");
            }

            IWebElement inputE_mail = driver.FindElement(By.Name("email"));
            if (inputE_mail.Displayed && inputE_mail.Enabled)
            {
                inputE_mail.SendKeys("Drgoljub@gmail.com");
            }

            IWebElement UserName = driver.FindElement(By.Name("korisnicko"));
            if(UserName.Displayed && UserName.Enabled)
            {
                UserName.SendKeys("Lepi");
            }

            IWebElement Password = driver.FindElement(By.Name("lozinka"));
            if(Password.Displayed && Password.Enabled)
            {
                Password.SendKeys("MnogomijeDrago1");
            }

            IWebElement ConfirmPassword = driver.FindElement(By.Name("lozinkaOpet"));
            if(ConfirmPassword.Displayed && ConfirmPassword.Enabled)
            {
                ConfirmPassword.SendKeys("MnogomijeDrago1");
            }

            IWebElement buttonRegister = driver.FindElement(By.Name("register"));
            if(buttonRegister.Displayed && buttonRegister.Enabled)
            {
                buttonRegister.Click();
            }
        }
        
        [Test]
        public void SignIn()
        {
            Navigate("http://shop.qa.rs/");

            IWebElement LinkSignIn = driver.FindElement(By.LinkText("Sign in"));
            if(LinkSignIn.Enabled && LinkSignIn.Displayed)
            {
                LinkSignIn.Click();
            }

            IWebElement KorisnickoIme = driver.FindElement(By.Name("username"));
            if(KorisnickoIme.Displayed && KorisnickoIme.Enabled)
            {
                KorisnickoIme.SendKeys("Lepi");
            }

            IWebElement Lozinka = driver.FindElement(By.Name("password"));
            if(Lozinka.Displayed && Lozinka.Enabled)
            {
                Lozinka.SendKeys("MnogomijeDrago1");
            }

            IWebElement buttonUlogujSe = driver.FindElement(By.Name("login"));
            if(buttonUlogujSe.Displayed && buttonUlogujSe.Enabled)
            {
                buttonUlogujSe.Click();
            }

            IWebElement ViewShoppingCart = driver.FindElement(By.XPath("//a[@href='/cart']//li"));
            if(ViewShoppingCart.Displayed && ViewShoppingCart.Enabled)
            {
                ViewShoppingCart.Click();
            }
  
        
        }

        private void Navigate(string url)
        {
            driver.Navigate().GoToUrl("http://shop.qa.rs/");
        }

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            driver.Manage().Window.Maximize();
       
        }


        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }  
    }
}
