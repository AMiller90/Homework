/////////////////////////////////////////////////////////////////////////////////////////
//File: Game.cpp
//Author: Andrew Miller
//Date Created: 09/08/2015
//Brief: This is the Game.cpp File. It will Contain All Functions Of The Level
/////////////////////////////////////////////////////////////////////////////////////////




#include "Game.h"



Game::Game()
{
	

}


Game::~Game()
{
}




void Game::AdventureStart()
{
	Player player;
	player.GetPositionX();
	player.GetPositionY();

	char cInput;


	cout << "Welcome To The Wumpus Adventure Game!\n";
	cout << endl;
	cout << "Would you like to enter the cave? Enter Y or N:\n";
	cin >> cInput;

	if (cInput == 'Y' || cInput == 'y')
	{
		system("cls");

		cout << "You have entered the cave!\n";
		cout << endl;

		
		cout << endl;
		cout << "What would you like to do?\n";

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

	else if (cInput != 'Y' || cInput != 'y')
	{
		system("cls");
		cout << "You Quit!\n";
		system("PAUSE");
		exit(1);
	}
}

void Game::HelpMenu()
{

	cout << "There are a total of 16 rooms in this cave you have entered.\n";
	cout << "The key to victory is getting the pile of gold stashed in one of the\n"; 
	cout << "rooms and return to the entrance with the gold.\n";
	cout << "Becareful though, there are pits in some rooms and it is game over\n";
	cout << "if you fall into one.\n";
	cout << "Also, there is a Wumpus lurking about and should you encouter it,\n";
	cout << "you have one chance of survival, your trusty arrow.\n";
	cout << "You had better make the shot count because you only get one!\n";
	cout << endl;
	cout << "You Can Move The Robot Using Input With The w, s, a, and d keys on the keyboard.\n";
	cout << "You Can Use Your Arrow By Pushing 1 On The Keyboard.\n";
	cout << "Once You Walk Into The Room With The Gold Stash It Will Automatically\n";
	cout << "Be Added To Your Inventory.\n";
	cout << "You Can Check What Adjacent Rooms May Contain By Using The Remote\n";
	cout << "By Pressing 2. The Remote Will Notify You OF Either A Glitter, Smell or Breeze\n";
	cout << "Glitter: Means Gold, Smell: Means Wumpus, and Breeze: Means Pit\n";
	cout << "Choose Wisely Where To Move Though Becasue You Wont Know Specifically Which Room\n";
	cout << "Contains The Gold, Breeze Or Wumpus Until You Actually Move Inside The Room\n";

}