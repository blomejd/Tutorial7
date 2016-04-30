using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tutorial7;

namespace CucumberTests
{
    [Binding]
    public class BlackMovesForwardSteps
    {
        PawnMovementSteps moveSteps;
        public BlackMovesForwardSteps(PawnMovementSteps p)
        {
            moveSteps = p;
        }
        Pawn p;
        [When(@"I try to move the black pawn from (.)(.) to (.)(.)")]
        public void WhenITryToMoveTheBlackPawnFromTo(char x1, int y1, char x2, int y2)
        {
            Tuple<char, int> init = new Tuple<char, int>(x1, y1);
            p = new Pawn("black");
            moveSteps.board.movePiece(init, new Tuple<char, int>(x2, y2));
        }
        
        [Then(@"the black pawn will not move")]
        public void ThenTheBlackPawnWillNotMove()
        {
            Assert.IsFalse(p.hasMoved());
        }
    }
}
