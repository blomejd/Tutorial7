Feature: PawnMovement
	As a player,
	I want to be able to move my pawn one space forward,
	or two spaces forward when the pawn has not moved.

@movement @happypath
Scenario: One space forward
	Given that I have an empty chessboard
	And I have a white pawn at a2
	When I try to move the white pawn from a2 to a3
	Then the white pawn is placed in a3