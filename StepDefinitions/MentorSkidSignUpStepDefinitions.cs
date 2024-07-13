using MentorSkid.Hooks;
using MentorSkid.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkid.StepDefinitions
{
    [Binding]
    public class MentorSkidSignUpStepDefinitions
    {
        MentorSkidSignUpPage mentorSkidSignUpPage = new MentorSkidSignUpPage();
        public IWebDriver driver = BaseTest.driver;


        [Given(@"I am a user on MentorSkid website")]
        public void GivenIAmAUserOnMentorSkidWebsite()
        {
            driver.Navigate().GoToUrl(@"https://mentorskid.com");
        }

        [When(@"I click on signup button")]
        public void WhenIClickOnSignupButton()
        {
            mentorSkidSignUpPage.ClickSignUpBtn();
        }

        [When(@"I enter a valid first name ""([^""]*)""")]
        public void WhenIEnterAValidFirstName(string p0)
        {
            mentorSkidSignUpPage.EnterFirstName(p0);
        }

        [When(@"I enter a valid last name ""([^""]*)""")]
        public void WhenIEnterAValidLastName(string p0)
        {
            mentorSkidSignUpPage.EnterLastName(p0);
        }

        [When(@"I enter a valid email address ""([^""]*)""")]
        public void WhenIEnterAValidEmailAddress(string p0)
        {
            mentorSkidSignUpPage.EnterEmailAddress(p0);
        }

        [When(@"I enter a valid password ""([^""]*)""")]
        public void WhenIEnterAValidPassword(string p0)
        {
            mentorSkidSignUpPage.EnterPassword(p0);
        }


        [When(@"I click on the radio button")]
        public void WhenIClickOnTheRadioButton()
        {
            mentorSkidSignUpPage.MentorRadioBtn();
        }

        [When(@"I click on the checkbox for Terms and conditions")]
        public void WhenIClickOnTheCheckboxForTermsAndConditions()
        {
            mentorSkidSignUpPage.TermsAndConditionsBox();
        }

        [When(@"I click on the join now button")]
        public void WhenIClickOnTheJoinNowButton()
        {
            mentorSkidSignUpPage.JoinNowBtn();
        }


        [Then(@"A successful message is displayed")]
        public void ThenASuccessfulMessageIsDisplayed()
        {
            mentorSkidSignUpPage.SuccessfulProfilePage().Contains("My Profile");
        }
    }

}

