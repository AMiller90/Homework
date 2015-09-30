///////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Grid.h
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Grid header file. It will contain all the Grid Class function prototypes and variables.
//////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Preprocessor Directives - If Not Defined Then Define 
#ifndef _GRID_H_
#define _GRID_H_

#include<iostream>
using namespace std;

class Grid
{
public:

	Grid();
	~Grid();

    //void GenerateGrid();
	void GenerateGridFromFile();
	void PrintGame();

};

//Ends The Inclusion Of This Class
#endif _PLAYER_H_