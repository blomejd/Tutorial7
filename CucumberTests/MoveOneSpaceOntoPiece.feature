Feature: MoveOneSpaceOntoPiece
	As a player,
	I cannot move a pawn one space forward onto another piece

@mytag
Scenario: Add two numbers
	Given that I have an empty chessboard
	And I have a white pawn at a2
	And I have a black pawn at a3
	When I try to move the white pawn from a2 to a3
	Then the white pawn is placed in a2
	
