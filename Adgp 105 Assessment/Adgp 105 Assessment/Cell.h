/////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Cell.h
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Cell header file. It will contain the Cell Class function prototypes and variables.
////////////////////////////////////////////////////////////////////////////////////////////////////////

//Include Header File Of Player Class In Order To Use Its Functions And Variables
#include "Player.h"

//Preprocessor Directives - If Not Defined Then Define 
#ifndef _CELL_H_
#define _CELL_H_

<<<<<<< HEAD
#include "Player.h"

=======
//Includes std Globally So std Does Not Have To Be Used Each And Every Time When It Is Needed.
//using namespace std takes care of that
>>>>>>> origin/master
using namespace std;

//Sets up the cell class
class Cell
{
//Variables Or Functions That Can Be Accessed In Any Class Go Here Under Public And Before Private
public:

	//Class Constructor
	Cell();
	//Class Decopnstructor
	~Cell();

<<<<<<< HEAD
	Cell StoreCells(int a_iX, int a_iY);
=======
	//All Function Prototypes That Are Used In This Class
	//This Declares These Functions-The Definitions Will Be In The .cpp File

	//Function that is used to store the positions for cells and returns the object data
	Cell StoreCells(int a_iX, int a_iY);
	//Function Used To Get The Private Variable m_iX Of This Class So They Can Be Used Outside The Class If Need Be.
>>>>>>> origin/master
	int GetPositionX();
	//Function Used To Get The Private Variable m_iY Of This Class So They Can Be Used Outside The Class If Need Be.
	int GetPositionY();
<<<<<<< HEAD
	bool GetLife();
	void SetLife(bool l);
	void Pits(Player player, int x, int y);
	void SetPosition(int a_iX, int a_iY);
	void Wumpus(Player player, int x, int y);
	void Gold(Player player, int x, int y);
	
=======
	//Function Used To Get The Private Variable m_blife Of This Class So They Can Be Used Outside The Class If Need Be.
	bool GetLife();
	//Function Used To Set The Cell Life To a boolean Variable if Wanting To Set It To Something Different
	void SetLife(bool a_l);
	//Function Used To Implement Pit Positions
	void Pits(int a_x, int a_y);
	//Function Used To Set The Cell Position To 2 integer Variables if Wanting To Set Them To Something Different
	void SetPosition(int a_iX, int a_iY);
	//Function Used To Implement Wumpus Position And check its life
	void Wumpus(Player &a_rfplayer, int a_x, int a_y);
	//Function used to Implement Gold Position And check the player position and the gold position
	void Gold(Player &a_rfplayer, int a_x, int a_y);
>>>>>>> origin/master

//Variables and Functions Only Accessible By This Class Go Here Under Private
private:
<<<<<<< HEAD
	bool life;
=======
	//Private Member Variables
	//bool variable for storing the life of the wumpus
	bool m_bLife;
	//int variable used to store the cells x position
>>>>>>> origin/master
	int m_iX;
	//int variable used to store the cells y position
	int m_iY;

};

//Ends The Inclusion Of This Class
#endif _CELL_H_