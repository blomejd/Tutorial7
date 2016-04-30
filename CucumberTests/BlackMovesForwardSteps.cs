using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tutorial7;

namespace CucumberTests
{
    [Binding]
    public class BlackMovesForwardSteps
    {
        ChessBoard board;
        Pawn p;
        [When(@"I try to move the black pawn from (.)(.) to (.)(.)")]
        public void WhenITryToMoveTheBlackPawnFromTo(char x1, int y1, char x2, int y2)
        {
            Tuple<char, int> init = new Tuple<char, int>('a', 7);
            board = new ChessBoard();
            p = new Pawn("black");
            board.placePiece(p, init);
            board.movePiece(init, new Tuple<char, int>('a', 8));
        }
        
        [Then(@"the black pawn will not move")]
        public void ThenTheBlackPawnWillNotMove()
        {
            Assert.IsFalse(p.hasMoved());
        }
    }
}
