Feature: FullEnrollmentNumberGenerator
	Checking the full enrollment number generation assuming that
	the CheckDigitCalculator and the HexadecimalConverter have
	the correct behavior

Scenario Outline: Inputing a valid enrollment number
	Given the CheckDigitCalculator returns <decimalCheckDigit> for the input <enrollmentNumber>
	And the HexadecimalConverter returns <checkDigit> for the input <decimalCheckDigit>
	When I input <enrollmentNumber> into the FullEnrollmentNumberGenerator
	Then the result should be <fullEnrollmentNumber>

	Examples:
		| enrollmentNumber | decimalCheckDigit | checkDigit | fullEnrollmentNumber |
		| 0000             | 0                 | 0          | 0000-0               |
		| 001              | 2                 | 2          | 0001-2               |
		| 0010             | 3                 | 3          | 0010-3               |
		| 100              | 4                 | 4          | 0100-4               |
		| 1000             | 5                 | 5          | 1000-5               |
		| 0954             | 11                | B          | 0954-B               |
		| 954              | 11                | B          | 0954-B               |
		| 1334             | 2                 | 2          | 1334-2               |
		| 1392             | 0                 | 0          | 1392-0               |
		| 1486             | 9                 | 9          | 1486-9               |
		| 1548             | 5                 | 5          | 1548-5               |
		|  1717            | 2                 | 2          | 1717-2               |
		| 2 881            | 4                 | 4          | 2881-4               |
		| 293 1            | 9                 | 9          | 2931-9               |
		| 89 7  2          | 5                 | 5          | 8972-5               |
		| 9105             | 11                | B          | 9105-B               |