//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Cell.cpp
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Cell cpp file. It will contain all the Cell Class function definitions and variable definitions.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#include "Cell.h"
#include "Player.h"

//Constructor
Cell::Cell()
{
	m_iX = 0;
	m_iY = 0;
}

//Destructor
Cell::~Cell()
{
}

Cell Cell::InitCell(int a_iY, int a_iX)
{
	Cell cCell;

	cCell.m_iX = a_iX;
	cCell.m_iY = a_iY;

	return cCell;

}

int Cell::GetPositionX()
{
	return m_iX;
}

int Cell::GetPositionY()
{
	return m_iY;
}
