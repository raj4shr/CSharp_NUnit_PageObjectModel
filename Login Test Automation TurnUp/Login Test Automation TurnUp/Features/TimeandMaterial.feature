Feature: Create new Time and Material

As a user, I should be able to create, edit and delete time and material info


Scenario: Create time and material record with valid details
	Given I logged into turn up portal successfully
	When I navigate to the time and material page
	And I create a new time and material record
	Then A new time and material record should be created
