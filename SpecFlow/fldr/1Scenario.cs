using System;
using TechTalk.SpecFlow;


namespace SpecFlow.fldr
{
    [Binding]
    public class Scenario1
    {
        HomePage HP1 = new HomePage();
        string itemname = "MacBook";
        [Given(@"I have navigated to the citrus homepage")]
        public void GivenIHaveNavigatedToTheCitrusHomepage()
        {
            string URL = "https://www.citrus.ua/";
            HP1.Navigate(URL);
        }

        [When(@"I entered itemname in the search field")]
        [When(@"I press search")]
        public void WhenIEnteredItemnameInTheSearchField()
        {
            HP1.Search(itemname);
        }

        [Then(@"all search results contain itemname in title")]
        public void ThenAllSearchResultsContainItemnameInTitle()
        {
            HP1.ValidateResults(itemname);
        }
    }
}

