Feature: SpecFlowFeature1
	As a user

Scenario: Login user
	Given I open "http://localhost:5000/" url
	When I type in string name "user"
	And I type in string password "user"
	And clik to button submit
	Then I check the user input and the "Logout" button
