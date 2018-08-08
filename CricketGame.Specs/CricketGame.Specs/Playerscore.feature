Feature: Playerscore
	In order to enjoy a game of cricket
	As a player
	I want to be told my score

@mytag
Scenario: Player score is zero,when the game starts.
	Given Player has started the game of cricket.
	
	Then the player score should be 0.
Scenario: Player should be able to score runs.
	Given Player has started the game of cricket.
	When  Player scores 4 runs.
	
	Then the player score should be 4.

	Scenario: Player should be able to score runs multiple times.
	Given Player has started the game of cricket.
	And  Player scores 4 runs.
	When  Player scores 3 runs.
	
	Then the player score should be 7.

	Scenario: Player should not be able to score runs after getting out
Given Player has started the game of cricket.
And  Player scores 4 runs.
And Player gets out
When Player scored 3 runs.
Then the player score should be 4.



