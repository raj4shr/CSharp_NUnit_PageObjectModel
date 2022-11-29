Feature: Create a new employee

As a user, I should be able to create, edit and delete employee 


Scenario: Create a new employee
	Given I logged into turnup portal successfully
	When I navigate to the employees page
	When I have created a new employee record
	Then A new employee should be created sucessfully

Scenario: Edit an employee
	Given I logged into turnup portal successfully
	When I navigate to the employees page
	When I have edited a employee record
	Then Employee record should be edited successfully

Scenario: Delete an employee
	Given I logged into turnup portal successfully
	When I navigate to the employees page
	And I have deleted an employee record
	Then Employee record should be deleted successfully

Scenario: Drag and drop
	Given I logged into turnup portal successfully
	When I navigate to the employees page
	And I have dragged and dropped a column tab
	Then the employee page should be sorted successfully