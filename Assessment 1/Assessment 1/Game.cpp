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
	Player Player;
	char cInput;
	
	m_iX = 0;
	m_iY = 0;
	
	cout << "Welcome To The Wumpus Adventure Game!\n";
	cout << endl;
	cout << "There are a total of 16 rooms in this cave you are about to enter.\n";
	cout << "The key to victory is getting the pile of gold stashed in one of the rooms and\n";
	cout << "return to the entrance with the gold.\n";
	cout << "Becareful though, there are pits in some rooms and it is game over if you fall\n";
	cout << "into one.\n";
	cout << "Also, there is a Wumpus lurking about and should you encouter it,\n";
	cout << "you have one chance of survival, your trusty arrow.\n";
	cout << "You had better make the shot count because you only get one!\n";
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
		cout << endl;
		cout << "Inventory:\n";
		Player.Inventory(Player);
		cout << endl;
		cout << "Current position: " << m_iX << "," << m_iY;
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

