Feature: FullEnrollmentNumberValidator
	Validating enrollment numbers, checking their check-digits

Scenario Outline: Well formated enrollment numbers
	Given the CheckDigitCalculator returns <decimalCheckDigit> for the input <enrollmentNumber>
	And the HexadecimalConverter returns <checkDigit> for the input <decimalCheckDigit>
	When I input <fullEnrollmentNumber> into the FullEnrollmentNumberValidator
	Then the result should be <result>

	Examples:
		| enrollmentNumber | decimalCheckDigit | checkDigit | fullEnrollmentNumber | result |
		| 0000             | 0                 | 0          | 0000-0               | true   |
		| 001              | 2                 | 2          | 001-2                | true   |
		| 0010             | 3                 | 3          | 0010-1               | false  |
		| 100              | 4                 | 4          | 100-4                | true   |
		| 1000             | 5                 | 5          | 1000-A               | false  |
		| 0954             | 11                | B          | 0954-b               | true   |
		| 954              | 11                | B          | 954-B                | true   |
		| 1334             | 2                 | 2          | 1334-2               | true   |
		| 1392             | 0                 | 0          | 1392-E               | false  |
		| 1486             | 9                 | 9          | 1486 - 4             | false  |
		| 1548             | 5                 | 5          | 1548- 5              | true   |
		| 1717             | 2                 | 2          | 1717-2               | true   |
		| 2 881            | 4                 | 4          | 2 881-B              | false  |
		| 293 1            | 9                 | 9          | 293 1-9              | true   |
		| 89 7  2          | 5                 | 5          | 89 7  2-2            | false  |
		| 9105             | 11                | B          | 9105-B               | true   |

Scenario: The CheckDigitCalculator throws a FormatException
	Given the CheckDigitCalculator throws a FormatException
	When I call the Validate Method
	Then the result should be false

Scenario: The HexadecimalConverter throws an ArgumentOutOfRangeException
	Given the HexadecimalConverter throws an ArgumentOutOfRangeException
	When I call the Validate Method
	Then the result should be false