/////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Cell.h
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Cell header file. It will contain the Cell Class function prototypes and variables.
////////////////////////////////////////////////////////////////////////////////////////////////////////

//Preprocessor Directives - If Not Defined Then Define 
#ifndef _CELL_H_
#define _CELL_H_

class Cell
{
public:

	Cell();
	~Cell();

	int InitCell(int a_iX, int a_iY);
	/*int GetPositionX(int a_iX);
	int GetPositionY(int a_iY);*/

private:

	int m_iX;
	int m_iY;

};

//Ends The Inclusion Of This Class
#endif _CELL_H_