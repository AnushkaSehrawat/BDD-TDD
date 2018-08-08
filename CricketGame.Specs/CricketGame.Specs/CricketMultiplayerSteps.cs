using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    
    public class CricketMultiplayerSteps
    {
        Cricket _Player1;
        Cricket _Player2;
        [When(@"the cricket game has started\.")]
        [Given(@"the cricket game has started\.")]
        public void WhenTheCricketGameHasStarted_()
        {
            //ScenarioContext.Current.Pending();
            _Player1 = new Cricket();
            _Player2 = new Cricket();
        }
        
        
        [Then(@"PlayerOne and PlayerTwo score should be (.*)\.")]
        public void ThenPlayerOneAndPlayerTwoScoreShouldBe_(int score)
        {
            //ScenarioContext.Current.Pending();
            _Player1.PlayerScore.Should().Be(score);

        }
        [When(@"PlayerOne scores (.*) runs and PlayerTwo scores (.*) runs\.")]
        public void WhenPlayerOneScoresRunsAndPlayerTwoScoresRuns_(int runs1, int runs2)
        {
            //ScenarioContext.Current.Pending();
            _Player1.Score(runs1);
            _Player2.Score1(runs2);
        }
        [Then(@"PlayerOne score should be (.*) and PlayerTwo score should be (.*)\.")]
        public void ThenPlayerOneScoreShouldBeAndPlayerTwoScoreShouldBe_(int score1, int score2)
        {
            //ScenarioContext.Current.Pending();
            _Player1.PlayerScore.Should().Be(score1);
            _Player2.PlayerScore1.Should().Be(score2);
            
        }

        [Given(@"PlayerOne has scored (.*) runs\.")]
        public void GivenPlayerOneHasScoredRuns_(int runs)
        {
            //ScenarioContext.Current.Pending();
            _Player1.Score(runs);
        }
        [When(@"PlayerOne scores (.*) runs\.")]
        public void WhenPlayerOneScoresRuns_(int runs)
        {
            //ScenarioContext.Current.Pending();
            _Player1.Score(runs);
        }

        [Then(@"PlayerOne score should be (.*)\.")]
        public void ThenPlayerOneScoreShouldBe_(int score1)
        {
            //ScenarioContext.Current.Pending();
            _Player1.PlayerScore.Should().Be(score1);
        }

        [Given(@"PlayerTwo has scored (.*) runs\.")]
        public void GivenPlayerTwoHasScoredRuns_(int runs1)
        {
            //ScenarioContext.Current.Pending();
            _Player2.Score1(runs1);
        }

        [When(@"PlayerTwo scores (.*) runs\.")]
        public void WhenPlayerTwoScoresRuns_(int runs1)
        {
            //ScenarioContext.Current.Pending();
            _Player2.Score1(runs1);
        }

        [Then(@"PlayerTwo score should be (.*)\.")]
        public void ThenPlayerTwoScoreShouldBe_(int score2)
        {
            //ScenarioContext.Current.Pending();
            _Player2.PlayerScore1.Should().Be(score2);
        }
        [Given(@"PlayerOne gets out\.")]
        public void GivenPlayerOneGetsOut_()
        {
            //ScenarioContext.Current.Pending();
            _Player1.IsPlaying = false;
        }


        [When(@"PlayerOne scored (.*) runs\.")]
        public void WhenPlayerOneScoredRuns_(int runs)
        {
            //ScenarioContext.Current.Pending();
            _Player1.PlayerScore = _Player1.PlayerScore;
        }

        [Given(@"PlayerTwo gets out\.")]
        public void GivenPlayerTwoGetsOut_()
        {
            //ScenarioContext.Current.Pending();
            _Player2.IsPlaying2 = false;
        }

        [When(@"PlayerTwo scored (.*) runs\.")]
        public void WhenPlayerTwoScoredRuns_(int runs2)
        {
            //ScenarioContext.Current.Pending();
            _Player2.PlayerScore1 = _Player2.PlayerScore1;
        }

        [When(@"PlayerOne has scored (.*) runs and PlayerTwo has scored (.*) runs\.")]
        public void WhenPlayerOneHasScoredRunsAndPlayerTwoHasScoredRuns_(int score1, int score2)
        {
            _Player1.Score(score1);
            _Player2.Score1(score2);
            //ScenarioContext.Current.Pending();
            if (_Player1.PlayerScore > _Player2.PlayerScore1)
            {
                _Player1.winner = true;
            }
            else if(_Player2.PlayerScore1>_Player1.PlayerScore)
            {
                _Player2.winner = true;
            }
            else
            {
                _Player1.winner=false;
                _Player2.winner = false;

            }

        }
        [Then(@"PlayerOne won\.")]
        public void ThenPlayerOneWon_()
        {
            //ScenarioContext.Current.Pending();
            _Player1.winner.Should().Be(true);
          
        }

        [Then(@"PlayerTwo won\.")]
        public void ThenPlayerTwoWon_()
        {
            //ScenarioContext.Current.Pending();
            _Player2.winner.Should().Be(true);
        }

        [Then(@"No one won\.")]
        public void ThenNoOneWon_()
        {
            //ScenarioContext.Current.Pending();
            _Player1.winner.Should().Be(false);
            _Player2.winner.Should().Be(false);
        }




























    }
}
