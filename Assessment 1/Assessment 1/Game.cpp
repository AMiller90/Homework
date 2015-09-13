 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Game.cpp
//Author: Andrew Miller
//Date Created: 09/08/2015
//Brief: This is the Game.cpp File. It will contain all the Game Class function definitions and variable definitions.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//Include Header File Of Classe In Order To Use It
#include "Game.h"


//Constructor Definition
Game::Game()
{
	

}

//Constructor Definition
Game::~Game()
{
}



//Prompts User For Input To Get The Game Started 
void Game::AdventureStart()
{
	//Creates Instance Of Player 
	Player player;
	//Gets The Player Position For X And Y By Calling These Functions 
	//From The Player Class
	player.GetPositionX();
	player.GetPositionY();

	//Input Variable
	char cInput;

	//Introduction
	cout << "Welcome To The Wumpus Adventure Game!\n";
	cout << endl;
	cout << "Would you like to enter the cave? Enter Y or N:\n";
	cin >> cInput;
	
	//Check If Input Was a Y or y
	if (cInput == 'Y' || cInput == 'y')
	{
		//If Input is Y or y then do all this
		system("cls");

		cout << "You have entered the cave!\n";
		cout << endl;

		
		cout << endl;
		cout << "What would you like to do?\n";

		//Displays The Controls And Current Player Position To The Screen
		cout << "Controls:\n";
		cout << "Move Up: w" << endl;
		cout << "Move Down: s" << endl;
		cout << "Move Left: a" << endl;
		cout << "Move Right: d" << endl;
		cout << "Help Menu: h" << endl;
		cout << endl;
		cout << "Inventory:\n";
		player.Inventory();
		cout << endl;
		cout << "Current position: " << player.GetPositionX() << "," << player.GetPositionY();
		cout << endl;

	}

	//Checks This If Input was not equal to Y or y
	else if (cInput != 'Y' || cInput != 'y')
	{
		//Clears The Screen
		system("cls");
		cout << "You Quit!\n";
		system("PAUSE");
		//Quits The Game
		exit(1);
	}
}

//Help Menu To Show Controls, Hints And Objective To The User
void Game::HelpMenu()
{
	system("cls");
	char cInput;

	//Briefing Of The Cave And Contents
	cout << "There are a total of 16 rooms in this cave you have entered.\n";
	cout << "A Room May Contain The Wumpus, A Pit, Or The Pile Of Gold.\n\n";
	
	//Objective Of The Game
	cout << "Objective: \n";
	cout << "Find the pile of gold stashed in one of the\n"; 
	cout << "rooms and return to the entrance with the gold.\n";
	cout << "Don't Worry! Whenever You Step Into The Room That\n";
	cout << "Has The Gold It Will Automatically Be Picked Up.\n\n";

	//Dangers In The Cave
	cout << "Dangers: \n";

	cout << "Wumpus - Creature Inside One Of The Rooms That Will Kill You\n";
	cout << "If You Enter The Room With It.\n";
	cout << "Pits - If You Step Into A Room With A Pit It's Game Over!\n\n";

	//Items Player Can Use
	cout << "Items: \n";

	cout << "Arrow - Use To Attack The Wumpus..You Only Get One!\n";

	cout << "Remote - Use To Scan The Adjacent Rooms For Hints.\n";
	cout << "When The Remote Is Used You Will See Breeze, Glitter, or Smell On The Screen.\n";
	cout << "Breeze: Means A Pit\n";
	cout << "Smell: Means The Wumpus\n";
	cout << "Glitter: Means The Gold Pile\n\n";

	//Hints For Gameplay
	cout << "Hints: \n";
	cout << "Once You Reach The Gold You Can Return To The Entrance Using\n";
	cout << "The Same Path You Used Getting To The Gold.\n\n";

	cout << "When Using The Remote, It Does Not Tell You Which Adjacent Room Or Rooms\n";
	cout << "Have The Specific Danger Or The Gold. So Choose Wisely What Direction To Go!\n";

	cout << "Be Sure To Use Your Arrow To Kill The Wumpus And Not Waste It.\n";
	cout << "As Long As Your In A Room Adjacent To The Wumpus And Have An Arrow To Use\n";
	cout << "You Can Destroy It.\n\n";

	cout << "That's All For Hints..Good Luck!\n\n";
	cout << "Enter Any Key Then Enter To Quit Looking At Hints:\n";
	//Gets Input To Quit Looking At Hints Screen
	cin >> cInput;

}