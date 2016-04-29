using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tutorial7;

namespace CucumberTests
{
    [Binding]
    public class InitialMoveTwoSteps
    {
        PawnMovementSteps moveSteps;
        Pawn p = new Pawn("white");
        public InitialMoveTwoSteps(PawnMovementSteps p)
        {
            moveSteps = p;
        }
        [Given(@"I have not moved the pawn")]
        public void GivenIHaveNotMovedThePawn()
        {
            moveSteps.board.placePiece(p, new Tuple<char, int>('b', 2));
            Assert.IsFalse(p.hasMoved());
            moveSteps.board.movePiece(new Tuple<char, int>('b', 2), new Tuple<char, int>('b', 4));
            Assert.IsTrue(p.hasMoved());
        }
    }
}
