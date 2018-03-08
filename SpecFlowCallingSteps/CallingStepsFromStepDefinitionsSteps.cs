using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowCallingSteps
{
    [Binding]
    public class CallingStepsFromStepDefinitionSteps : Steps
    {
        [Given(@"the user (.*) exists")]
        public void GivenTheUserExists(string name)
        {
            // ...
        }

        [Given(@"I log in as (.*)")]
        public void GivenILogInAs(string name)
        {
            // ...
        }

        [Given(@"(.*) is logged in")]
        public void GivenIsLoggedIn(string name)
        {
            Given(string.Format("the user {0} exists", name));
            Given(string.Format("I log in as {0}", name));
        }
    }
}
