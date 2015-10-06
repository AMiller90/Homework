//////////////////////////////////////////////////////////////////////////////////////
//File: Main.cpp
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Main file. It will run the program from inside the main function.
//////////////////////////////////////////////////////////////////////////////////////

//Include Grid header file to be able to use its class functions
#include "Grid.h"
//Include Player header file to be able to use its class functions
#include "Player.h"


//Includes The input/output stream to interact with the user and get input as well
//as output to the console window.
#include<iostream>

//Using namespce std Globally So std Does Not Have To Be Used Each And Every Time When It Is Needed.
using namespace std;

//Main Function Where The Program Is Started And Ended
int main()
{
	//Sets Up A boolean Variable And Sets It To True
	bool bIsDone = true;
	//Create Instances Of Player And Grid To Be Able To Use Them For Calling Functions
	Player pPlayer;
	Grid gGrid;
	
	//Generate Grid Size, initialize And Store In A File
	gGrid.GenerateGridToFile();
	//Prompts User To Play Game Or Quit
	pPlayer.StartAdventure();
	//Prints Player Instructions, Inventory and map
	gGrid.PrintGame();
	//Print Players Position - prints x position using GetPositionX function and prints y position using GetPositionY function
	cout << "Current Position: " << pPlayer.GetPositionX() << ',' << pPlayer.GetPositionY();

	//Using A While Loop To Initiate The Game Loop - It will keep running while bIsDone is equal to true
	while (bIsDone == true)
	{
		//Gets user input to move player 
		pPlayer.Move();
		//This Function Is Used To Check If The Player Made It Back To The Entrance With The Gold. If So, The Function Returns False
		//Then The Variable bIsDone Gets Set To False Which Is The Return Value Of The Function And It Causes The Program To Break Out
		//The While Loop. Causing The Program To End.
		bIsDone = pPlayer.Victory();
	}
	//Pauses Program and waits for input
	system("PAUSE");
	//Returns from the main function
	return 0;

}