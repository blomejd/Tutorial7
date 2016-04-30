using System;
using TechTalk.SpecFlow;
using Tutorial7;

namespace CucumberTests
{
    [Binding]
    public class CaptureInPassingSteps
    {
        PawnMovementSteps moveSteps;
        public CaptureInPassingSteps(PawnMovementSteps p)
        {
            moveSteps = p;
        }

        [Given(@"I move the black pawn from (.)(.) to (.)(.)")]
        public void GivenIMoveTheBlackPawnFromTo(char x1, int y1, char x2, int y2)
        {
            moveSteps.board.movePiece(new Tuple<char, int>(x1, y1), new Tuple<char, int>(x2, y2));
        }
    }
}
