using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame.test
{
    [TestClass]
    class MultiPlayerCricketTest
    {
        [TestMethod]

        public void PlayerScore_NewGame_ShouldbeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore == 0);
        }
    }
}
