Go Fish Card Game - Initially Created by Syed Z Abbas
Debugged and Edited by Christine Cullen Spring 2018

Excercise Solution for Head First C#

The Card Game has 3 players and the player with four matching numbers wins the game

The Players can pass cards between them and the game continues until a winner emerges.

This game contained multiple errors which did not allow it to built/function correctly.

The errors I found on debugging & changes I made to the game included:

1) unmatching variable names d/t capitalization (winnerLIst vs winnerList)
2) missing parameters when calling in the deal function
3) add players to the list of players using foreach (prior to this no players could be added to the listbox)
4) correct function of game play using for loop
5) game for revisions: clean up text alerts to make more user friendly and improve appearance.  Replaced generic titles with titles specific to the game, added pictures.