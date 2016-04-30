using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tutorial7;

namespace CucumberTests
{
    [Binding]
    public class CaptureInPassingBlackSteps
    {
        PawnMovementSteps moveSteps;
        PawnCaptureSteps captureSteps;

        public CaptureInPassingBlackSteps(PawnMovementSteps pm, PawnCaptureSteps pc)
        {
            moveSteps = pm;
            captureSteps = pc;
        }
        [Then(@"the black pawn is placed in (.)(.)")]
        public void ThenTheBlackPawnIsPlacedIn(char x, int y)
        {
            Assert.AreEqual(new Tuple<char, int>(x, y), moveSteps.board.getLocation(captureSteps.blackPawn));
        }
        
        [Then(@"the white pawn is captured")]
        public void ThenTheWhitePawnIsCaptured()
        {
            Assert.IsTrue(moveSteps.whitePawn.isCaptured());
        }
    }
}
