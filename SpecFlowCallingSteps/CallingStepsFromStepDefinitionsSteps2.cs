using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowCallingSteps
{
    [Binding]
    public class CallingStepsFromStepDefinitionSteps2 : Steps
    {
        [Given(@"the user Linda exists again")]
        public void GivenTheUserLindaExistsAgain()
        {
            // ...
        }

        [Given(@"I log in as Linda again")]
        public void GivenILogInAsLindaAgain()
        {
            // ...
        }

        [Given(@"Linda is logged in again")]
        public void GivenLindaIsLoggedInAgain()
        {
            Given(string.Format("the user Linda exists again"));
            Given(string.Format("I log in as Linda again"));
        }
    }
}
