using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CricketGame;

namespace CricketGame.test
{
    [TestClass]
    public class CricketGamteTest
    {
        [TestMethod]
        public void PlayerScore_NewGame_ShouldbeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore==0);
        }

        [TestMethod]

        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(3);
            Assert.IsTrue(game.PlayerScore==3);
        }
        
        [TestMethod]

        public void Score_ValidRuns_ShouldnotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(7);
            Assert.IsTrue(game.PlayerScore == 7);
        }

        [TestMethod]
        public void Score_GotOut()
        {
            var game = new Cricket();
            game.Score(4);
            game.IsPlaying = false;
            game.Score(3);

            Assert.IsTrue(game.PlayerScore==4);
        }

        
        
    }
}
