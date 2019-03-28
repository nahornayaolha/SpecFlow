Feature: SpecFlowFeature1
	

	Background: 
	Given I have navigated to the citrus homepage

	@T1
Scenario: Searching by MacBook
	When I entered itemname in the search field
	And I press search
	Then all search results contain itemname in title

	@T2
Scenario: Searching LG
	When I choosed catalog-element in sidebar
	And I choosed itemname in the menu
	Then all search results contain itemname in title
	And itemname is displayed

