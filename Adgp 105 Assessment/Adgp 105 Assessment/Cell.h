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

//Includes std Globally So std Does Not Have To Be Used Each And Every Time When It Is Needed.
//using namespace std takes care of that
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

	//All Function Prototypes That Are Used In This Class
	//This Declares These Functions-The Definitions Will Be In The .cpp File
	Cell StoreCells(int a_iX, int a_iY);
	int GetPositionX();
	int GetPositionY();
	bool GetLife();
	void SetLife(bool a_l);
	void Pits(int a_x, int a_y);
	void SetPosition(int a_iX, int a_iY);
	void Wumpus(Player &a_rfplayer, int a_x, int a_y);
	void Gold(Player &a_rfplayer, int a_x, int a_y);

//Variables and Functions Only Accessible By This Class Go Here Under Private
private:
	//Private Member Variables
	bool m_blife;
	int m_iX;
	int m_iY;

};

//Ends The Inclusion Of This Class
#endif _CELL_H_