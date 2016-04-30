Feature: MoveThroughPieces
	As a player,
	I cannot move my pawn forward 2 spaces through a piece

@movement @through
Scenario: MoveThroughPiece
	Given that I have an empty chessboard
	And I have a white pawn at a2
	And I have a black pawn at a3
	When I try to move the white pawn from a2 to a4
	Then the white pawn is placed in a2
	
