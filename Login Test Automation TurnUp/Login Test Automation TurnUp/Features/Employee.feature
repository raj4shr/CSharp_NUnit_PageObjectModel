Feature: Create a new employee

As a user, I should be able to create, edit and delete employee 

Background: 
	Given I logged into turnup portal successfully
	When I navigate to the employees page


Scenario: Create a new employee
	When I have created a new employee record
	Then A new employee should be created sucessfully

Scenario Outline: Edit an employee
	When I have edited a employee record '<userName>' with respective '<row>'
	Then Employee record '<userName>' should be edited successfully withrespect to the relavent '<row>'

	Examples: 
	|   userName		| row |
	|   This_is_updated |  1  |
	|   This_is_updated |  2  |
	|   This is updated |  3  |


Scenario: Delete an employee
	When I have deleted an employee record
	Then Employee record should be deleted successfully

Scenario: Drag and drop
this is a drag and drop operation perfomed by the user by dragging and dropping any column header into the drop element

	When I have dragged and dropped a column tab
	Then the employee page should be sorted successfully