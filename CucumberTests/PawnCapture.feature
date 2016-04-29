Feature: PawnCapture
	As a player, I want my pawns to capture pieces

@pawn @happypath
Scenario: Capture a black pawn
	Given that I have an empty chessboard
	And I have a white pawn at d4
	And I have a black pawn at e5
	When I try to move the white pawn from d4 to e5
	Then the white pawn is placed in e5
	And the black pawn is captured