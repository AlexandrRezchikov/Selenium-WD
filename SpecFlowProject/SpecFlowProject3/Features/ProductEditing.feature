Feature: Product editing
	As a user 
	I want to add a new product

    Scenario: Product Editing
	Given I Open "http://localhost:5000/" url
	And I type "user" login and "user" password and click on submit button
	And I Click on All Products
	And I Click on Create New 
	And I Enter values into fields
	When I click on submit Button
	Then The Create/edit form has closed