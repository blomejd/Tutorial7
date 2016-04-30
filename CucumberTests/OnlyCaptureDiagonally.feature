Feature: OnlyCaptureDiagonally
	As a player,
	I can only move a pawn diagonally when a piece is being captured

@capture
Scenario: Only Capture Diagonally
	Given that I have an empty chessboard
	And I have a white pawn at a2
	And A black pawn is not at b3
	When I try to move the white pawn from a2 to b3
	Then the white pawn is placed in a2
