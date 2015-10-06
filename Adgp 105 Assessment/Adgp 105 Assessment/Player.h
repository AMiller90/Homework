////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Player.h
//Author: Andrew Miller
//Date Created: 09/27/2015
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

//Includes std Globally So std Does Not Have To Be Used Each And Every Time When It Is Needed.
//using namespace std takes care of that
using namespace std;

<<<<<<< HEAD

=======
//Sets Up Player Class
>>>>>>> origin/master
class Player
{
//Variables Or Functions That Can Be Accessed In Any Class Go Here Under Public And Before Private
public:
<<<<<<< HEAD
	
=======
	//Class Constructor
>>>>>>> origin/master
	Player();
	//Class Deconstructor
    ~Player();

	//All Function Prototypes That Are Used In This Class
	//The Definitions Will Be In The .cpp File

	//Function Used To Get The Private Variable m_iX Of This Class So They Can Be Used Outside The Class If Need Be.
	int GetPositionX();
	//Function Used To Get The Private Variable m_iY Of This Class So They Can Be Used Outside The Class If Need Be.
	int GetPositionY();
	//Function Used To Set The Player Position To 2 integer Variables if Wanting To Set Them To Something Different
	void SetPosition(int a_iX, int a_iY);
	//This Function Takes User Input To Move The Player In The Cave And Use The Inventory Items
	void Move();
<<<<<<< HEAD
	bool Attack();
=======
	//This Function Allows The Player To Use The Arrow From The Inventory To Attack and returns a boolean value
	bool Attack();
	//Prompts User To Play Game Or Quit 
>>>>>>> origin/master
	void StartAdventure();
	//This Function Sets Up The Players Inventory
	void Inventory();
<<<<<<< HEAD
	void FoundGold(int &x, int &y);
=======
	//This Function Allows The Player To Automatically Get The Gold Once Inside The Room That Has The Gold And Put 
	//It Into The Inventory
	void FoundGold(int &a_rfX, int &a_rfY);
	//This Function Is Used To Check If The Player Made It Back To The Entrance With The Gold. If So, Player Wins.
	bool Victory();
>>>>>>> origin/master

//Variables and Functions Only Accessible By This Class Go Here Under Private
private:
	//Private Member Variables
	int m_iX;
	int m_iY;

};

//Ends The Inclusion Of This Class
#endif _PLAYER_H_