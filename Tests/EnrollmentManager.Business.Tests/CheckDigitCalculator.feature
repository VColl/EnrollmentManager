Feature: CheckDigitCalculator
	Checking the check digit calculataion of enrollments, in its decimal representation

Scenario Outline: Enrollment number between 0000 and 9999
	When I input the enrollment <enrollmentNumber>
	Then the check digit should be <checkDigit>

	Examples:
		| enrollmentNumber | checkDigit |
		| 0000             | 0          |
		| 0001             | 2          |
		| 0010             | 3          |
		| 0100             | 4          |
		| 1000             | 5          |
		| 0954             | 11         |
		| 954              | 11         |
		| 1334             | 2          |
		| 1392             | 0          |
		| 1486             | 9          |
		| 1548             | 5          |
		|  1717            | 2          |
		| 2 881            | 4          |
		| 293 1            | 9          |
		| 89 7  2          | 5          |
		| 9105             | 11         |

Scenario Outline: Invalid Format
	When I input the enrollment {enrollmentNumber}
	Then A FormatException should be thrown

	Examples:
		| enrollmentNumber |
		| 42315            |
		| 43k5             |
		| -245             |
		| -5325            |
		| 42-3             |
		| 4.872            |
		| 6.23             |
		| 4,62             |
		| 1/45             |
		| .                |
		| -                |
		|                  |
