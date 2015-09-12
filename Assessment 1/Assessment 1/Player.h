////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Player.h
//Author: Andrew Miller
//Date Created: 09/03/2015
//Brief: This is the Player header file. It will contain the Player Class function prototypes And Variables.
////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Preprocessor Directives - If Not Defined Then Define 
#ifndef _PLAYER_H_
#define _PLAYER_H_


//Includes The input/output stream to interact with the user and get input as well
//as output to the console window.
#include<iostream>
//Includes String So We Can Use That Data Type In The Class
#include<string>

//Include Header File Of Game Class In Order To Use Its Functions And Variables
#include"Game.h"

//Includes std Globally So std Does Not Have To Be Used Each And Every Time When It Is Needed
//using namespace std takes care of that
using namespace std;


//Sets Up Player Class
class Player 
{

//Variables Or Functions That Can Be Accessed In Any Class Go Here Under Public And Before Private
public:

	
	//Class Constructor
	Player();
	//Class Destructor
	~Player();
	

	
	//All Function Prototypes That Are Used In This Class
	//This Declares These Functions-The Definitions Will Be In The .cpp File 
	void PrintGameData();
	int GetPositionX();
	int GetPositionY();
	void SetPosition(int a_iX, int a_iY);
	void Actions();
	void Inventory();
	void Pits();
	void UseArrow();
	void UseRemote();
	void FoundGold();
	void Victory();
	void AttackWumpus();
	void Wumpus();
	
	

	//Variables Or Functions Only Accessible By This Class Go Here Under Private
private:

	//Private Variables
	int m_iX;
	int m_iY;
	



};


//Ends The Inclusion Of This Class
#endif _PLAYER_H_