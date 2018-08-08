using System;
using TechTalk.SpecFlow;

using FluentAssertions;

namespace CricketGame.Specs
{
    [Binding]
    public class PlayerscoreSteps
    {
        Cricket _game;
        [Given(@"Player has started the game of cricket\.")]
        [When(@"Player has started the game of cricket\.")]
        public void GivenPlayerHasStartedTheGameOfCricket_()
        {
            //ScenarioContext.Current.Pending();
            _game = new Cricket();
        }
        
        [Then(@"the player score should be (.*)\.")]
        public void ThenThePlayerScoreShouldBe_(int score)
        {
            // ScenarioContext.Current.Pending();
            _game.PlayerScore.Should().Be(score); // Assertion

        }
        [When(@"Player scores (.*) runs\.")]
        public void WhenPlayerScoresRuns_(int runs)
        {
            //ScenarioContext.Current.Pending();
            _game.Score(runs);
        }
        [Given(@"Player scores (.*) runs\.")]
        public void GivenPlayerScoresRuns_(int runs)
        {
            //ScenarioContext.Current.Pending();
            _game.Score(runs);
        }
   

        [When(@"Player scored (.*) runs\.")]
     
        public void WhenPlayerScoredRuns_(int runs)
        {
            //ScenarioContext.Current.Pending();
            _game.PlayerScore = _game.PlayerScore;

        }
        [Given(@"Player gets out")]
        public void GivenPlayerGetsOut()
        {
            //ScenarioContext.Current.Pending();
            _game.IsPlaying = false;
        }

        [Given(@"TwoPlayer has started the game of cricket\.")]
        public void GivenTwoPlayerHasStartedTheGameOfCricket_()
        {
            //ScenarioContext.Current.Pending();
            _game = new Cricket();
        }

        [Then(@"the TwoPlayer score should be (.*)\.")]
        public void ThenTheTwoPlayerScoreShouldBe_(int score)
        {
            //ScenarioContext.Current.Pending();
            _game.Score(score);
        }
       








    }
}
