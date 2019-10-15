Feature: ActionsPresenter
	Verifying the behavior of the components responsible
	for execute the actions

Scenario Outline: Showing error for empty file path
	Given The <filePath> is empty
	When I press the <buttonName> button
	Then an error message should be shown

	Examples:
		| filePath         | buttonName |
		| input file path  | Generate   |
		| input file path  | Verify     |
		| output file path | Generate   |
		| output file path | Verify     |
