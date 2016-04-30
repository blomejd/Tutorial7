Feature: CaptureInPassingBlack
	As a player,
	I can capture a pawn that has just moved two spaces by capturing into the space it skipped

@mytag
Scenario: Capture white pawn in passing
	Given that I have an empty chessboard
	And I have a black pawn at a4
	And I have a white pawn at b2
	And I move the white pawn from b2 to b4
	When I try to move the black pawn from a4 to b3
	Then the black pawn is placed in b3
	And the white pawn is captured