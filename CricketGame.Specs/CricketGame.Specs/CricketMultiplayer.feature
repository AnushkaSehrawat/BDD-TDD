Feature: CricketMultiplayer
	In order to allow two players to play
	As a player
	I want to be told the maximum score.

@mytag
Scenario: PlayerOne and PlayerTwo score is zero, when the game has started.
	
	
	When the cricket game has started.
	Then PlayerOne and PlayerTwo score should be 0.

Scenario: Only PlayerOne scores runs.

Given the cricket game has started.
When  PlayerOne scores 4 runs and PlayerTwo scores 0 runs.
Then PlayerOne score should be 4 and PlayerTwo score should be 0.

Scenario: Only PlayerTwo scores runs.

Given the cricket game has started.
When PlayerOne scores 0 runs and PlayerTwo scores 4 runs.
Then PlayerOne score should be 0 and PlayerTwo score should be 4.


Scenario: Only PlayerOne is able to score multiple runs.
Given the cricket game has started.
 And  PlayerOne has scored 3 runs.
When PlayerOne scores 4 runs.
Then PlayerOne score should be 7.

Scenario: Only PlayerTwo is able to score multiple runs.
Given the cricket game has started.
 And  PlayerTwo has scored 3 runs.
When PlayerTwo scores 4 runs.
Then PlayerTwo score should be 7.

Scenario: PlayerOne gets out.
Given the cricket game has started.
And  PlayerOne has scored 3 runs.
And PlayerOne gets out.
When PlayerOne scored 4 runs.
Then PlayerOne score should be 3.

Scenario: PlayerTwo gets out.
Given the cricket game has started.
And  PlayerTwo has scored 3 runs.
And PlayerTwo gets out.
When PlayerTwo scored 4 runs.
Then PlayerTwo score should be 3.


Scenario: PlayerOne won.
Given the cricket game has started.
 
When PlayerOne has scored 4 runs and PlayerTwo has scored 3 runs. 
 
Then PlayerOne won.

Scenario: PlayerTwo won.
Given the cricket game has started.
 
When PlayerOne has scored 4 runs and PlayerTwo has scored 5 runs. 
 
Then PlayerTwo won.


Scenario: Tie.
Given the cricket game has started.
 
When PlayerOne has scored 4 runs and PlayerTwo has scored 4 runs. 
 
Then No one won.




 



