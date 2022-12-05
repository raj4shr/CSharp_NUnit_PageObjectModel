Feature: Create a new time and material

As a user, I should be able to create, edit and delete time and material 


Background: 
	Given I logged into turnup portal TAM successfully
	When I navigate to the time and material page



Scenario: Create a new time and material
	When I have created a new time and material record
	Then A new time and material should be created sucessfully

Scenario: Edit time and material
	When I have edited a time and material record
	Then time and material record should be edited successfully

Scenario: Delete time and material
	When I have deleted an time and material record
	Then Time and material record should be deleted successfully

Scenario: Drag and drop
	When I have dragged and dropped a column tab in time and material page
	Then The time and material page should be sorted successfully