//////////////////////////////////////////////////////////////////////////////////////
//File: Main.cpp
//Author: Andrew Miller
//Date Created: 09/03/2015
//Brief: This is the main file. It will run the program from inside the main function.
//////////////////////////////////////////////////////////////////////////////////////

//Include Header Files Of Classes In Order To Use Them
#include "Player.h"
#include "Game.h"

//Includes The input/output stream to interact with the user and get input as well
//as output to the console window.
#include<iostream>

//Includes std Globally So std Does Not Have To Be Used Each And Every Time When It Is Needed.
//using namespace std takes care of that
using namespace std;


//Function that will used to run the game and end it
int main()
{
	//Create Instances Of Player And Game To Be Able To Use Them For Calling Functions
	Player Player;
	Game game;

	//Gathers Input For Starting The Game From User
	game.AdventureStart();
	
	//Sets Up A boolean Variable And Sets It To False
	bool bIsDone = false;

	//Using A While Loop To Initiate The Game Loop - It will keep running while bIsDone is equal to false
	while (bIsDone == false)
	{

		//Uses Player Input To Move And Execute Commands
		Player.Actions();
		//When Player Finds The Gold It Gets Added To The Inventory Using This Function
		Player.FoundGold();
		//This Function Is Used To Check If The Player Made It Back To The Entrance With The Gold. If So, The Function Returns True
		// Then The Variable bIsDone Gets Set To True Which Is The Return Value Of The Function And It Causes The Program To Break Out
		//The While Loop. Causing The Program To End
		bIsDone = Player.Victory();
		
	}
	

	system("PAUSE");
	return 0;
}