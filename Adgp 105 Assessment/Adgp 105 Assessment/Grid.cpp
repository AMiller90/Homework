//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Grid.cpp
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Grid cpp file. It will contain all the Grid Class function definitions and variable definitions.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


#include "Grid.h"
#include <random>
#include <time.h>
#include <math.h>

//Constructor
Grid::Grid()
{

}

//Detructor
Grid::~Grid()
{

}

//Generate Random Grid Size And Initialize
void Grid::GenerateRandomGrid()
{
	//Creates instance of cell
	Cell cCell;
	//sets random generator and seeds it with time
	mt19937 randomGen(time(0));
	
	//distributes random numbers that are between the numbers set in parenthesis
	uniform_int_distribution<int> GridSize(3, 10);
	//sets variable to the random number generated from the range and generator
	int Temp = GridSize(randomGen);
	//Sets variable to temp time temp variables
	int Size = Temp * Temp;
	//sets up a pointer
	int *Grid;
	//sets pointer to new allocated array of memory set to the size variables value
	Grid = new int[Size];
	//Sets the square root of the size variables value to the temp2 variable
	int temp2 = sqrt(Size);
	//Loop through array
	for (int i = 0; i < Size; ++i)
	{//Set x variable to i % 2
		int x = i % temp2;
		//Gives the Grid index its values 
		Grid[i] = cCell.InitCell(x, i);
	}

	//Loop through array 
	for (int i = 0; i < Size; i++)
	{//Print out array
		cout << Grid[i];
		//if i % temp2 is equal to the squareroot of size -1 
		if (i % temp2 == sqrt(Size) - 1)
		{//Print out a newline 
			cout << endl;
		}
			
		
	}

}