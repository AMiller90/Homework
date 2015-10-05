/////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Cell.h
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Cell header file. It will contain the Cell Class function prototypes and variables.
////////////////////////////////////////////////////////////////////////////////////////////////////////

//Preprocessor Directives - If Not Defined Then Define 
#ifndef _CELL_H_
#define _CELL_H_

#include "Player.h"

using namespace std;

class Cell
{
public:


	Cell();
	~Cell();

	Cell StoreCells(int a_iX, int a_iY);
	int GetPositionX();
	int GetPositionY();
	bool GetLife();
	void SetLife(bool l);
	void Pits(Player player, int x, int y);
	void SetPosition(int a_iX, int a_iY);
	void Wumpus(Player player, int x, int y);
	void Gold(Player player, int x, int y);
	

private:
	bool life;
	int m_iX;
	int m_iY;

};

//Ends The Inclusion Of This Class
#endif _CELL_H_