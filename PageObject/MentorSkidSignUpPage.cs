using MentorSkid.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorSkid.PageObject
{
    public class MentorSkidSignUpPage
    {

        public IWebDriver driver;
        public MentorSkidSignUpPage()
        {
            driver = BaseTest.driver;
        }

        private readonly By clickSignUpBtn = By.XPath("//a[normalize-space()='Signup']");
        private readonly By enterFirstName = By.XPath("//input[@placeholder='First name']");
        private readonly By enterLastName = By.XPath("//input[@placeholder='Last name']");
        private readonly By enterEmailAddress = By.XPath("//input[@placeholder='Enter your email address']");
        private readonly By enterPassword = By.XPath("//input[@id='tu-passwordinput']");
        private readonly By mentorRadioBtn = By.XPath("//label[normalize-space()='Mentor']");
        private readonly By termsAndConditionsBox = By.XPath("//label[@for='tu-terms']");
        private readonly By joinNowBtn = By.XPath("//span[normalize-space()='Join now']");
        private readonly By successfulProfilePage = By.XPath("//h4[normalize-space()='My Profile']");


        //write out test methods 
        public void ClickSignUpBtn()
        {
            driver.FindElement(clickSignUpBtn).Click();
        }
        public void EnterFirstName(string p0)
        {
            driver.FindElement(enterFirstName).SendKeys(p0);
        }
        public void EnterLastName(string p0)
        {
            driver.FindElement(enterLastName).SendKeys(p0);
        }
        public void EnterEmailAddress(string p0)
        {
            driver.FindElement(enterEmailAddress).SendKeys(p0);
        }

        public void EnterPassword(string p0)
        {
           driver.FindElement(enterPassword).SendKeys(p0);
        }

        public void MentorRadioBtn()
        {
            driver.FindElement(mentorRadioBtn).Click();
        }

        public void TermsAndConditionsBox()
        {
            driver.FindElement(termsAndConditionsBox).Click();
        }

        public void JoinNowBtn()
        {
            driver.FindElement(joinNowBtn).Click();
        }

        public string SuccessfulProfilePage()
        {
            return driver.FindElement(successfulProfilePage).Text;
        }

    }
}
