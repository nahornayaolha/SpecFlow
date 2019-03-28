using SpecFlow.fldr;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class Scenario2
     {
        HomePage HP1 = new HomePage();
        string itemname = "MacBook";
        [Given(@"I have navigated to the citrus homepage")]
        public void GivenIHaveNavigatedToTheCitrusHomepage()
        {
            string URL = "https://www.citrus.ua/";
            HP1.Navigate(URL);
        }
        [When(@"I choosed catalog-element in sidebar")]
        [When(@"I choosed itemname in the menu")]
        public void WhenIChoosedItemnameInTheMenu()
        {
            HP1.LGFilter(itemname);
        }
        
        [Then(@"itemname is displayed")]
        public void ThenItemnameIsDisplayed()
        {
            HP1.ValidateResults(itemname);
        }
    }
}
