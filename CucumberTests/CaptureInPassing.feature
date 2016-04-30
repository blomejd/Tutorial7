Feature: CaptureInPassing
	As a player,
	I can capture a pawn that has just moved two spaces by capturing into the space it skipped

@mytag
Scenario: Capture black pawn in passing
	Given that I have an empty chessboard
	And I have a white pawn at a5
	And I have a black pawn at b7
	And I move the black pawn from b7 to b5
	When I try to move the white pawn from a5 to b6
	Then the white pawn is placed in b6
	And the black pawn is captured
