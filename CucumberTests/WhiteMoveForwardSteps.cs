using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tutorial7;

namespace CucumberTests
{
    [Binding]
    public class WhiteMoveForwardSteps
    {
        [Then(@"the white pawn will not move")]
        public void ThenTheWhitePawnWillNotMove()
        {
            ChessBoard b = new ChessBoard();
            Pawn p = new Pawn("white");
            Tuple<char, int> init = new Tuple<char, int>('b', 2);
            b.placePiece(p, init);
            b.movePiece(init, new Tuple<char, int>('b', 5));
            Assert.IsFalse(p.hasMoved());
            b.movePiece(init, new Tuple<char, int>('a', 2));
            Assert.IsFalse(p.hasMoved());
            b.movePiece(init, new Tuple<char, int>('a', 4));
            Assert.IsFalse(p.hasMoved());
            b.movePiece(init, new Tuple<char, int>('b', 1));
            Assert.IsFalse(p.hasMoved());
            b.movePiece(init, new Tuple<char, int>('c', 2));
            Assert.IsFalse(p.hasMoved());
            b.movePiece(init, new Tuple<char, int>('c', 4));
            Assert.IsFalse(p.hasMoved());

        }
    }
}
