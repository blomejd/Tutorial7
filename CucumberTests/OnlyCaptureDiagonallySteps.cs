using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tutorial7;

namespace CucumberTests
{
    [Binding]
    public class OnlyCaptureDiagonallySteps
    {
        PawnMovementSteps moveSteps;
        public OnlyCaptureDiagonallySteps(PawnMovementSteps p)
        {
            moveSteps = p;
        }
        [Given(@"A black pawn is not at (.)(.)")]
        public void GivenABlackPawnIsNotAtB(char x, int y)
        {
            Pawn p = moveSteps.board.GetPieceAt(x, y);
            if (p != null)
            {
                Assert.AreEqual("black", p.color);
            }
        }
    }
}
