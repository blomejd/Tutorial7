Feature: BlackMovesForward
	As a player,
	I cannot move a black pawn backward

@movement @forward
Scenario: BlackForward
	Given that I have an empty chessboard
	And I have a black pawn at a7
	When I try to move the black pawn from a7 to a8
	Then the black pawn will not move
