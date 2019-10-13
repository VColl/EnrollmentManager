Feature: HexadecimalConverter
	Checking the convertion of an integer from decimal representation to hexadecimal representation

Scenario Outline: Converting the range 0-15
	When I input the value <decimal>
	Then the result should be "<hexadecimal>"

	Examples:
		| decimal | hexadecimal |
		| 00      | 0           |
		| 01      | 1           |
		| 02      | 2           |
		| 03      | 3           |
		| 04      | 4           |
		| 05      | 5           |
		| 06      | 6           |
		| 07      | 7           |
		| 08      | 8           |
		| 09      | 9           |
		| 10      | A           |
		| 11      | B           |
		| 12      | C           |
		| 13      | D           |
		| 14      | E           |
		| 15      | F           |

Scenario Outline: Try to convert a value outside the range 0-15 trhows exception
	When I input the value <decimal>
	Then An ArgumentOutOfRangeException should be thrown

	Examples: 
	| decimal |
	| -1      |
	| -23     |
	| 16      |
	| 17      |
	| 100     |
	| 4214    |