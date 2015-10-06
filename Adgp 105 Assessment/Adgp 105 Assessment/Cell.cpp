//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Cell.cpp
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Cell cpp file. It will contain all the Cell Class function definitions and variable definitions.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Include Cell header file to be able to use its class function
#include "Cell.h"
//Include Player header file to be able to use its class functions
#include "Player.h"

//Constructor
Cell::Cell()
{//Initializes cell variable m_iX and m_iY to 0 and member variable m_bLife to true
	m_iX = 0;
	m_iY = 0;
<<<<<<< HEAD
	life = true;
=======
	m_bLife = true;
>>>>>>> origin/master
}

//Destructor
Cell::~Cell()
{
	//Is not initialized
}

<<<<<<< HEAD
Cell Cell::StoreCells(int a_iY, int a_iX)
{
=======
//Function that is used to store the positions for cells and returns the object data
Cell Cell::StoreCells(int a_iY, int a_iX)
{//Creates an instance of Cell object so functions and variables can be called
>>>>>>> origin/master
	Cell cCell;
	//Calls the m_iX variable and sets it to a_iX parameter value
	cCell.m_iX = a_iX;
	//Calls the m_iY variable and sets it to a_iY parameter value
	cCell.m_iY = a_iY;
	//Returns object data
	return cCell;

}

//Function Used To Get The Private Variable m_iX Of This Class So They Can Be Used Outside The Class If Need Be.
int Cell::GetPositionX()
{//return the m_iX value
	return m_iX;
}

//Function Used To Get The Private Variable m_iY Of This Class So They Can Be Used Outside The Class If Need Be.
int Cell::GetPositionY()
{//return the m_iY value
	return m_iY;
}

<<<<<<< HEAD
void Cell::SetPosition(int a_iX, int a_iY)
{
	m_iX = a_iX;
=======
//Function Used To Set The Cell Position To 2 integer Variables if Wanting To Set Them To Something Different
void Cell::SetPosition(int a_iX, int a_iY)
{//Sets the variable m_iX to value passed in from a_iX variable
	m_iX = a_iX;
	//Sets the variable m_iY to value passed in from a_iY variable
>>>>>>> origin/master
	m_iY = a_iY;

}

<<<<<<< HEAD
bool Cell::GetLife()
{
	return life;
}
void Cell::SetLife(bool l)
{
	life = l;

}

void Cell::Pits(Player player, int x, int y)
{
	

	Cell Pit;

	Pit.SetPosition(1, 0);

	if ((x == 1 && y == 0) &&
		(Pit.GetPositionX() == 1 && Pit.GetPositionY() == 0))
	    {
		    system("cls");
			cout << "You Fell Into A Pit!\n";
			system("PAUSE");
			exit(1);
        }

	Pit.SetPosition(3, 1);
	if ((x == 3 && y == 1) &&
		(Pit.GetPositionX() == 3 && Pit.GetPositionY() == 1))
	{
		system("cls");
		cout << "You Fell Into A Pit!\n";
		system("PAUSE");
		exit(1);
	}

	Pit.SetPosition(0, 3);
	if ((x == 0 && y == 3) &&
		(Pit.GetPositionX() == 0 && Pit.GetPositionY() == 3))
	{
		system("cls");

		cout << "You Fell Into A Pit!\n";
		system("PAUSE");
=======
//Function Used To Get The Private Variable m_blife Of This Class So They Can Be Used Outside The Class If Need Be.
bool Cell::GetLife()
{//return the m_bLife value
	return m_bLife;
}

//Function Used To Set The Cell Life To a boolean Variable if Wanting To Set It To Something Different
void Cell::SetLife(bool l)
{//return the m_bLife value
	m_bLife = l;

}

//Function Used To Implement Pit Positions
void Cell::Pits(int a_ix, int a_iy)
{//Create Instance of cell object and calls it Pit so functions can be used from the respective class
	Cell Pit;

	//Sets the Pit Position to Specific Coordinates
	Pit.SetPosition(1, 0);
	//if statement that checks the players current position and the Pits X and Y positions
	if ((a_ix == 1 && a_iy == 0) &&
		(Pit.GetPositionX() == 1 && Pit.GetPositionY() == 0))
	    {//Clears the screen
		    system("cls");
			//Print this to screen
			cout << "You Fell Into A Pit!\n";
			//Pauses Program and waits for input
			system("PAUSE");
			//Exits Program
			exit(1);
        }
	//Sets the Pit Position to Specific Coordinates
	Pit.SetPosition(3, 1);
	//if statement that checks the players current position and the Pits X and Y positions
	if ((a_ix == 3 && a_iy == 1) &&
		(Pit.GetPositionX() == 3 && Pit.GetPositionY() == 1))
	{//Clears the screen
		system("cls");
		//Print this to screen
		cout << "You Fell Into A Pit!\n";
		//Pauses Program and waits for input
		system("PAUSE");
		//Exits Program
		exit(1);
	}
	//Sets the Pit Position to Specific Coordinates
	Pit.SetPosition(0, 3);
	//if statement that checks the players current position and the Pits X and Y positions
	if ((a_ix == 0 && a_iy == 3) &&
		(Pit.GetPositionX() == 0 && Pit.GetPositionY() == 3))
	{//Clears the screen
		system("cls");
		//Print this to screen
		cout << "You Fell Into A Pit!\n";
		//Pauses Program and waits for input
		system("PAUSE");
		//Exits Program
>>>>>>> origin/master
		exit(1);
	}
	
}

<<<<<<< HEAD
void Cell::Wumpus(Player player, int x, int y)
{
	Cell Wumpus;
	Wumpus.SetPosition(2, 2);
	
	Wumpus.SetLife(player.Attack());

	if ((x == 2 && y == 2) &&
		(Wumpus.GetPositionX() == 2 && Wumpus.GetPositionY() == 2) && (Wumpus.GetLife() == true))
	{
		system("cls");
		cout << "You Were Killed By The Wumpus!\n";
		system("PAUSE");
		exit(1);
	}
    if ((x == 2 && y == 2) &&
		(Wumpus.GetPositionX() == 2 && Wumpus.GetPositionY() == 2) && (Wumpus.GetLife() == false))
	{
=======
//Function Used To Implement Wumpus Position And check its life
void Cell::Wumpus(Player &a_rfplayer, int a_ix, int a_iy)
{//Create a cell object called Wumpus so now functions can be used from the respective class
	Cell Wumpus;
	//Sets the Wumpus Position to Specific Coordinates
	Wumpus.SetPosition(2, 2);
	//Set Wumpus Life to the return value of the Attack function
	Wumpus.SetLife(a_rfplayer.Attack());
	//if statement that checks player current position and the wumpus position and if the wumpus is alive
	if ((a_ix == 2 && a_iy == 2) &&
		(Wumpus.GetPositionX() == 2 && Wumpus.GetPositionY() == 2) && (Wumpus.GetLife() == true))
	{//Clear screen
		system("cls");
		//Print this to screen
		cout << "You Were Killed By The Wumpus!\n";
		//Pauses Program and waits for input
		system("PAUSE");
		//Exits Program
		exit(1);
	}
	//if statement that checks player current position and the wumpus position and if the wumpus is dead
    if ((a_ix == 2 && a_iy == 2) &&
		(Wumpus.GetPositionX() == 2 && Wumpus.GetPositionY() == 2) && (Wumpus.GetLife() == false))
	{//Print this to screen
>>>>>>> origin/master
		cout << "You See The Remains Of The Dead Wumpus!\n";
	}

}
<<<<<<< HEAD

void Cell::Gold(Player player, int x, int y)
{
	Cell Gold;
	
	Gold.SetPosition(3, 3);

	if ((x == 3 && y == 3) &&
		(Gold.GetPositionX() == 3 && Gold.GetPositionY() == 3))
	{
		player.FoundGold(x,y);
=======
 
//Function used to Implement Gold Position And check the player position and the gold position
void Cell::Gold(Player &a_rfplayer, int a_ix, int a_iy)
{//Creates a Cell object called Gold so now functions can be used from the respective class
	Cell Gold;
	//Sets the Gold Position to Specific Coordinates
	Gold.SetPosition(3, 3);
	//If statement that checks the players current position and if it is the same as the golds position 
	if ((a_ix == 3 && a_iy == 3) &&
		(Gold.GetPositionX() == 3 && Gold.GetPositionY() == 3))
	{//If statement is true then call this function - Allows The Player To Automatically Get The Gold Once Inside The Room That Has The Gold And Put 
     //It Into The Inventory
		a_rfplayer.FoundGold(a_ix, a_iy);
>>>>>>> origin/master
	}


}