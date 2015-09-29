//////////////////////////////////////////////////////////////////////////////////////
//File: Main.cpp
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Main file. It will run the program from inside the main function.
//////////////////////////////////////////////////////////////////////////////////////


//Includes The input/output stream to interact with the user and get input as well
//as output to the console window.
#include<iostream>


//Include Grid header file to be able to use its class functions
#include "Grid.h"


//Using namespce std Globally So std Does Not Have To Be Used Each And Every Time When It Is Needed.
using namespace std;

//Main Function Where The Program Is Started And Ended
int main()
{


	Grid Grid;

	Grid.GenerateRandomGrid();










	system("PAUSE");
	return 0;

}