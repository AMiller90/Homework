//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Grid.cpp
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Grid cpp file. It will contain all the Grid Class function definitions and variable definitions.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


#include "Grid.h"
#include <random>
#include <time.h>

Grid::Grid()
{
}


Grid::~Grid()
{
}


void Grid::GenerateRandomGrid()
{
	//sets random generator and seeds it with time
	mt19937 randomGen(time(0));
	
	//distributes random numbers that are between the numbers set in parenthesis
	uniform_int_distribution<int> GridSize(4, 10);
	//sets variable to the random number generated from the range and generator
	int Rows = GridSize(randomGen);
	int Columns = GridSize(randomGen);

}