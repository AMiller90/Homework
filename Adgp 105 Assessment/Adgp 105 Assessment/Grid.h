///////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Grid.h
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Grid header file. It will contain all the Grid Class function prototypes and variables.
//////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Preprocessor Directives - If Not Defined Then Define 
#ifndef _GRID_H_
#define _GRID_H_

<<<<<<< HEAD
=======
#include "Cell.h"
>>>>>>> f0369dcf4cf3701c9073e90fe4172c0e11a3d924
#include<iostream>
using namespace std;

class Grid
{
public:

	Grid();
	~Grid();

	void GenerateRandomGrid();
	void GenerateGridFromFile();

};

//Ends The Inclusion Of This Class
#endif _PLAYER_H_