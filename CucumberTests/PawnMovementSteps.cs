﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tutorial7;

namespace CucumberTests
{
    [Binding]
    public class PawnMovementSteps
    {
        public Pawn whitePawn;
        public ChessBoard board = null;
        [Given(@"that I have an empty chessboard")]
        public void GivenThatIHaveAnEmptyChessboard()
        {
            board = new ChessBoard();
        }
        
        [Given(@"I have a white pawn at (.)(.)")]
        public void GivenIHaveAWhitePawnAt(char x, int y)
        {
            whitePawn = new Pawn("white");
            board.placePiece(whitePawn, new Tuple<char, int>(x, y));
        }
        
        [When(@"I try to move the white pawn from (.)(.) to (.)(.)")]
        public void WhenITryToMoveTheWhitePawnFromTo(char x1, int y1, char x2, int y2)
        {
            board.movePiece(new Tuple<char, int>(x1, y1), new Tuple<char, int>(x2, y2));
        }
        
        [Then(@"the white pawn is placed in (.)(.)")]
        public void ThenTheWhitePawnIsPlacedIn(char x, int y)
        {
            Assert.AreEqual(new Tuple<char, int>(x, y), board.getLocation(whitePawn));
        }
    }
}
