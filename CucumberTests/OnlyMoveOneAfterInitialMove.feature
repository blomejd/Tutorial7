Feature: OnlyMoveOneAfterInitialMove
	As a player,
	Once I have moved a pawn, it can only move one space at a time

@movement
Scenario: OneSpacePerMoveAfterInitial
	Given that I have an empty chessboard
	And I have a white pawn at a2
	And I move the white pawn from a2 to a4
	When I try to move the white pawn from a4 to a6
	Then the white pawn is placed in a4
