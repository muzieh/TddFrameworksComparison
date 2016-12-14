Feature: CalculateAddition
	In order speed up calculation 
	As a user
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I press add
	And I have entered 70 into the calculator
	When I press equals
	Then the result should be 120 on the screen

Scenario: Add positive and negative numbers
	Given I have entered 50 into the calculator
	And I press add 
	And I have entered -20 into the calculator
	When I press equals
	Then result 30 on the screen

Scenario Outline: Add more numbers
	Given I have entered <ValueA> into the calculator
	And I press add 
	And I have entered <ValueB> into the calculator
	When I press equals
	Then the result should be <Result> on the screen

Examples: 
| ValueA | ValueB | Result  |
| 10     | 20     | 30      |
| 1      | 4      | 5       |
| -8     | 8      | 0       |
