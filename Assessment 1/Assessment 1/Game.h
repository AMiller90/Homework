///////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Game.h
//Author: Andrew Miller
//Date Created: 09/08/2015
//Brief: This is the Game Header File. It will contain the Game Class function prototypes And Variables
///////////////////////////////////////////////////////////////////////////////////////////////////////

//Include Header File Of Player Class In Order To Use Its Functions And Variables
#include "Player.h"

//Preprocessor Directives - If Not Defined Then Define 
#ifndef _GAME_H_
#define _GAME_H_

//Sets Up Game Class
class Game
{
	//Variables Or Functions That Can Be Accessed In Any Class Go Here Under Public And Before Private
public:
	//Constructor For The Game Class
	Game();
	//Destructor For The Game Class
	 ~Game();

	 //Functions Are Declared Here And The Definitions Will Be In The .cpp File
	//Prompts User For Input To Get The Game Started 
	 void AdventureStart();

	 //Help Menu To Show Controls, Hints And Objective To The User
	 void HelpMenu();
	
	 //Variables Or Functions Only Accessible By This Class Go Here Under Private
 private:
	
	 
};

//Ends The Incusion Of This Class
#endif _GAME_H_
