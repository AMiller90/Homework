//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Cell.cpp
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Cell cpp file. It will contain all the Cell Class function definitions and variable definitions.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#include "Cell.h"
//Constructor
Cell::Cell()
{

}

//Destructor
Cell::~Cell()
{
}

Cell Cell::InitCell(int a_iX, int a_iY)
{
	Cell cCell;

	cCell.m_iX = a_iX;
	cCell.m_iY = a_iY;

	return cCell;

}

//int Cell::GetPositionX(int a_iX)
//{
//	m_iX = a_iX;
//	return m_iX;
//}
//
//int Cell::GetPositionY(int a_iY)
//{
//	m_iY = a_iY;
//	return m_iY;
//}
