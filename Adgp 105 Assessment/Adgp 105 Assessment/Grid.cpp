//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Grid.cpp
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Grid cpp file. It will contain all the Grid Class function definitions and variable definitions.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


#include "Grid.h"
#include "Cell.h"
#include "Player.h"
#include <random>
#include <time.h>
#include <fstream>
#include <string>

//Constructor
Grid::Grid()
{

}

//Detructor
Grid::~Grid()
{

}

////Generate Random Grid Size And Initialize
//void Grid::GenerateGrid()
//{
//	//Creates instance of cell
//	Cell cCell;
//
//	//sets random generator and seeds it with time
//	mt19937 randomGen(time(0));
//	
//	//distributes random numbers that are between the numbers set in parenthesis
//	uniform_int_distribution<int> GridSize(3, 10);
//	//sets variable to the random number generated from the range and generator
//	int Size = 9;// GridSize(randomGen);
//	//Sets variable to temp time temp variables
//	//int Size = Temp * Temp;
//	//sets up a pointer
//	Cell *Grid;
//	//sets pointer to new allocated array of memory set to the size variables value
//	Grid = new Cell[Size];
//	//Sets the square root of the size variables value to the temp2 variable
//	int temp2 = sqrt(Size);
//
//	int y = 0;
//	//Loop through array
//	for (int i = 0; i < Size; ++i)
//	{//Set x variable to i % 2
//		int x = i % temp2;
//		if (i % temp2 == temp2 - 1)
//		{//Print out a newline 
//			y++;
//		}
//		//Gives the Grid index its values 
//		Grid[i] = cCell.InitCell(y, x);
//
//	}
//
//	////Loop through array 
//	for (int i = 0; i < Size; i++)
//	{//Print out array
//		if (i % temp2 == temp2 - 1)
//		{//Print out a newline 
//			cout << endl;
//		}
//
//		/*cout << Grid[i].GetPositionY() << "," << Grid[i].GetPositionX() << " ";*/
//
//		
//	}
//}

//Generate Grid From File And Initialize
void Grid::GenerateGridFromFile()
{

	string s;
	ifstream File;

	File.open("Wumpus Map.txt", ios_base::in);

	if (File.fail())
	{

		cout << "File Could Not Be Opened!\n";

	}
	else
	{

		while (getline(File, s))
		{
			cout << s;
			cout << endl;
		}
		

	}
	cout << endl;

	File.close();
}

void Grid::PrintGame()
{
	Player pPlayer;
	GenerateGridFromFile();
	//system("cls");
	cout << "What Would You Like To Do?\n\n";
	cout << "Move Up: w\n";
	cout << "Move Up: a\n";
	cout << "Move Up: s\n";
	cout << "Move Up: d\n";
	cout << "Use Arrow: 1\n\n";
	pPlayer.Inventory();
	
}


