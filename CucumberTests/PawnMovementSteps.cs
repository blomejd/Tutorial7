using System;
using TechTalk.SpecFlow;

namespace CucumberTests
{
    [Binding]
    public class PawnMovementSteps
    {
        ChessBoard board = null;
        [Given(@"that I have an empty chessboard")]
        public void GivenThatIHaveAnEmptyChessboard()
        {
            board = new ChessBoard();
        }

        Pawn p = null;
        [Given(@"I have a white pawn at (.)(.)")]
        public void GivenIHaveAWhitePawnAt(char x, int y)
        {
            p = new Pawn("white");
            board.placePiece(p, new Tuple<char, int>(x, y));
        }
        
        [When(@"I try to move the white pawn from (.)(.) to (.)(.)")]
        public void WhenITryToMoveTheWhitePawnFromTo(char x1, int y1, char x2, int y2)
        {
            board.movePiece(new Tuple<char, int>(x1, y1), new Tuple<char, int>(x2, y2));
        }
        
        [Then(@"the white pawn is placed in (.)(.)")]
        public void ThenTheWhitePawnIsPlacedIn(char x, int y)
        {
            Assert.AreEqual(new Tuple<char, int>(x, y), board.getLocation(p));
        }
    }
}
