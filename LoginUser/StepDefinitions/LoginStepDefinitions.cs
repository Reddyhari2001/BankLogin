using BankLogin;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;


namespace LoginUser.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private string userName;
        private string password;
        private string loginResult;
        private readonly ScenarioContext scenarioContext;
        private readonly LoginPerson loginperson;
        public LoginStepDefinitions(ScenarioContext sc)
        {
            this.scenarioContext = sc;  
            loginperson = new BankLogin.LoginPerson();
        }
        [Given(@"a user with valid username ""([^""]*)"" and password ""([^""]*)""")]
        public void GivenAUserWithValidUsernameAndPassword(string p0, string p1)
        {
            //throw new PendingStepException();
            userName = p0;
            password = p1;
        }

        [When(@"the Login method is called")]
        public void WhenTheLoginMethodIsCalled()
        {
            loginResult = loginperson.Login(userName, password);
            //throw new PendingStepException();
        }

        [Then(@"the result should Login Success")]
        public void ThenTheResultShouldLoginSuccess()
        {
            Assert.AreEqual("Login Success", loginResult);
            //throw new PendingStepException();
        }

        [Given(@"a user with invalid username ""([^""]*)"" and invalid password ""([^""]*)""")]
        public void GivenAUserWithInvalidUsernameAndInvalidPassword(string p0, string invalid)
        {
            userName = p0;
            userName = invalid;
            //throw new PendingStepException();
        }

        [Then(@"the result should Login Failed")]
        public void ThenTheResultShouldLoginFailed()
        {
            Assert.AreEqual("Login Failed", loginResult);
            //throw new PendingStepException();
        }
    }
}
