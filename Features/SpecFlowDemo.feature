Feature: SpecFlowDemo
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen


Scenario: Create a new employee with mandatary details
	#Given I have opend my application
	#Then Ishould see employee detais page
	When Ifill all the mandatory detail in form
	| Name    | Age | Phone         | Email             |
	| kartrik | 28  | 80631089758   | kartrik@gmail.com |
	| jon     | 45  | 8063108323338 | jhon@gmail.com    |
	| sam     | 33  | 8063108332432 | samk@gmail.com    |

	#And I click the save button
	#Then Ishoul see all the details saved in my application and DB