Feature: WhiteMoveForward
	As a player,
	I cannot move my pawn backward

@movement @forward
Scenario: WhiteForward
	Given that I have an empty chessboard
	And I have a white pawn at a2
	When I try to move the white pawn from a2 to b2
	Then the white pawn will not move
