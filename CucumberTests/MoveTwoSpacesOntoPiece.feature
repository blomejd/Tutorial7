Feature: MoveTwoSpacesOntoPiece
	As a player,
	I cannot move a pawn two spaces forward onto another piece

@mytag
Scenario: Move two spaces onto piece
	Given that I have an empty chessboard
	And I have a white pawn at a2
	And I have a black pawn at a4
	When I try to move the white pawn from a2 to a4
	Then the white pawn is placed in a2