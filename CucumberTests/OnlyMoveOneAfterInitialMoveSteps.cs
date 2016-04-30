using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tutorial7;

namespace CucumberTests
{
    [Binding]
    public class OnlyMoveOneAfterInitialMoveSteps
    {
        [Given(@"I move the white pawn from (.)(.) to (.)(.)")]
        public void GivenIMoveTheWhitePawnFromAToA(char x1, int y1, char x2, int y2)
        {
            ChessBoard b = new ChessBoard();
            Pawn p = new Pawn("white");
            Tuple<char, int> init = new Tuple<char, int>('a', 2);
            Tuple<char, int> next = new Tuple<char, int>('a', 4);
            Tuple<char, int> last = new Tuple<char, int>('a', 6);

            b.placePiece(p, init);
            b.movePiece(init, next);
            b.movePiece(next, last);

            Assert.AreEqual(next, b.getLocation(p));
        }
    }
}
