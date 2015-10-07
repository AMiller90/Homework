///////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Grid.h
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Grid header file. It will contain all the Grid Class function prototypes and variables.
//////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Preprocessor Directives - If Not Defined Then Define 
#ifndef _GRID_H_
#define _GRID_H_

//Includes The input/output stream to interact with the user and get input as well
//as output to the console window.
#include<iostream>

//Includes std Globally So std Does Not Have To Be Used Each And Every Time When It Is Needed.
//using namespace std takes care of that
using namespace std;

//Sets up Grid class
class Grid
{
//Variables Or Functions That Can Be Accessed In Any Class Go Here Under Public And Before Private
public:
	//Class Constructor
	Grid();
	//Class Deconstructor
	~Grid();

	//All Function Prototypes That Are Used In This Class
	//This Declares These Functions-The Definitions Will Be In The .cpp File 

	//Generate Grid Size, Initialize and Store in A File
    void GenerateGridToFile();
	//Generate Grid From File
	void GenerateGridFromFile();
	//Prints Player Instructions, Inventory and map
	void PrintGame();

};

//Ends The Inclusion Of This Class
#endif _GRID_H_