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
	m_blife = true;
}

//Destructor
Cell::~Cell()
{
}

Cell Cell::StoreCells(int a_iY, int a_iX)
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

void Cell::SetPosition(int a_iX, int a_iY)
{
	m_iX = a_iX;
	m_iY = a_iY;

}

bool Cell::GetLife()
{
	return m_blife;
}
void Cell::SetLife(bool l)
{
	m_blife = l;

}

void Cell::Pits(int a_ix, int a_iy)
{
	

	Cell Pit;

	Pit.SetPosition(1, 0);

	if ((a_ix == 1 && a_iy == 0) &&
		(Pit.GetPositionX() == 1 && Pit.GetPositionY() == 0))
	    {
		    system("cls");
			cout << "You Fell Into A Pit!\n";
			system("PAUSE");
			exit(1);
        }

	Pit.SetPosition(3, 1);
	if ((a_ix == 3 && a_iy == 1) &&
		(Pit.GetPositionX() == 3 && Pit.GetPositionY() == 1))
	{
		system("cls");
		cout << "You Fell Into A Pit!\n";
		system("PAUSE");
		exit(1);
	}

	Pit.SetPosition(0, 3);
	if ((a_ix == 0 && a_iy == 3) &&
		(Pit.GetPositionX() == 0 && Pit.GetPositionY() == 3))
	{
		system("cls");

		cout << "You Fell Into A Pit!\n";
		system("PAUSE");
		exit(1);
	}
	
}

void Cell::Wumpus(Player &a_rfplayer, int a_ix, int a_iy)
{
	Cell Wumpus;
	Wumpus.SetPosition(2, 2);
	
	Wumpus.SetLife(a_rfplayer.Attack());

	if ((a_ix == 2 && a_iy == 2) &&
		(Wumpus.GetPositionX() == 2 && Wumpus.GetPositionY() == 2) && (Wumpus.GetLife() == true))
	{
		system("cls");
		cout << "You Were Killed By The Wumpus!\n";
		system("PAUSE");
		exit(1);
	}
    if ((a_ix == 2 && a_iy == 2) &&
		(Wumpus.GetPositionX() == 2 && Wumpus.GetPositionY() == 2) && (Wumpus.GetLife() == false))
	{
		cout << "You See The Remains Of The Dead Wumpus!\n";
	}

}
 
void Cell::Gold(Player &a_rfplayer, int a_ix, int a_iy)
{
	Cell Gold;
	
	Gold.SetPosition(3, 3);

	if ((a_ix == 3 && a_iy == 3) &&
		(Gold.GetPositionX() == 3 && Gold.GetPositionY() == 3))
	{
		a_rfplayer.FoundGold(a_ix, a_iy);
	}


}