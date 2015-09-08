/////////////////////////////////////////////////////////////////////////////////////////
//File: Main.cpp
//Author: Andrew Miller
//Date Created: 09/03/2015
//Brief: This is the main file. It will run the program from the inside the main function
/////////////////////////////////////////////////////////////////////////////////////////


#include "Player.h"
#include<iostream>


using namespace std;



int main()
{
	Player Player;
	

	Player.AdventureStart();

	bool bIsDone = false;

	while (bIsDone == false)
	{

		
		Player.Actions(Player);
		Player.FoundGold(Player);
		Player.Victory(Player);
	}
	


	system("PAUSE");
	return 0;
}