Feature: InitialMoveTwo
	As a player,
	I want to be able to more my pawn two spaces forward
	When the pawn has not moved.

@movement @happypath
Scenario: Two spaces forward
	Given that I have an empty chessboard
	And I have a white pawn at a2
	And I have not moved the pawn
	When I try to move the white pawn from a2 to a4
	Then the white pawn is placed in a4
