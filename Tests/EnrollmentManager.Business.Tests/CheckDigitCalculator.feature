Feature: CheckDigitCalculator
	Checking the check digit calculataion of enrollments, in its decimal representation

Scenario Outline: Enrollment number between 0000 and 9999
	When I input the enrollment <enrollmentNumber>
	Then the check digit should be <checkDigit>

Examples: 
	| enrollmentNumber | checkDigit |
	| 0000			   | 0          |
	| 0001			   | 2          |
	| 0010			   | 3          |
	| 0100			   | 4          |
	| 1000			   | 5          |
	| 0954			   | 14         |
	| 1334			   | 10         |
	| 1392			   | 10         |
	| 1486			   | 12         |
	| 1548			   | 0          |
	| 1717			   | 12         |
	| 2881			   | 10         |
	| 2931			   | 5          |
	| 8972			   | 6          |
	| 9105			   | 11         |