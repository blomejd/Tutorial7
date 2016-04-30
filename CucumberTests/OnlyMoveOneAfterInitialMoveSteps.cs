using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tutorial7;

namespace CucumberTests
{
    [Binding]
    public class OnlyMoveOneAfterInitialMoveSteps
    {
        PawnMovementSteps moveSteps;
        public OnlyMoveOneAfterInitialMoveSteps(PawnMovementSteps p)
        {
            moveSteps = p;
        }
        [Given(@"I move the white pawn from (.)(.) to (.)(.)")]
        public void GivenIMoveTheWhitePawnFromAToA(char x1, int y1, char x2, int y2)
        {
            
            Tuple<char, int> init = new Tuple<char, int>(x1, y1);
            Tuple<char, int> next = new Tuple<char, int>(x2, y2);
            
            moveSteps.board.movePiece(init, next);
        }
    }
}
