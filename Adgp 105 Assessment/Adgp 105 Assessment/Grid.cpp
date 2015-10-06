//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Grid.cpp
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Grid cpp file. It will contain all the Grid Class function definitions and variable definitions.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Include Grid header file to be able to use its class functions
#include "Grid.h"
//Include Cell header file to be able to use its class functions
#include "Cell.h"
//Include Player header file to be able to use its class functions
#include "Player.h"
//Include fstream to access the file streams 
#include <fstream>
//Includes String So We Can Use That Data Type In The Class
#include <string>

//Constructor
Grid::Grid()
{
	//Is not initialized
}

//Destructor
Grid::~Grid()
{
	//Is not initialized
}

<<<<<<< HEAD
///Generate Random Grid Size And Initialize
//void Grid::GenerateGridToFile()
//{
//	//Creates instance of cell
//	Cell cCell;
//
//	////sets random generator and seeds it with time
//	//mt19937 randomGen(time(0));
//
//	////distributes random numbers that are between the numbers set in parenthesis
//	//uniform_int_distribution<int> GridSize(3, 10);
//	//sets variable to the random number generated from the range and generator
//	int Size = 16;// GridSize(randomGen);
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
//
//		}
//		//Gives the Grid index its values 
//		Grid[i] = cCell.StoreCells(y, x);
//
//	}
//	
//	
//	string s;
//	ofstream File;
//
//	File.open("Wumpus Map.txt", ios_base::out);
//
//	if (File.fail())
//	{
//
//		cout << "File Could Not Be Opened!\n";
//
//	}
//	else
//	{
//		////Loop through array 
//		for (int i = 0; i < Size; i++)
//		{//Print out array
//			if (i % temp2 == temp2 - 1)
//			{//Print out a newline 
//				File << endl;
//			}
//
//			File << Grid[i].GetPositionY() << "," << Grid[i].GetPositionX() << " ";
//		
//		}
//
//		File.close();
//		
//
//
//	}
//
//	delete[] Grid;
//
//}

//Generate Grid From File And Initialize
void Grid::GenerateGridFromFile()
{
	Cell Wumpus;
	Cell Gold;
	Cell Pit;
=======
//Generate Grid Size,Initialize and Store in A File
void Grid::GenerateGridToFile()
{
	//Creates instance of cell
	Cell cCell;

	//sets up a variable called temp and sets its value to 4
	int Temp = 4;
	//Sets variable to temp time temp variables
	int Size = Temp * Temp;
	//sets up a pointer
	Cell *Grid;
	//sets pointer to new allocated array of memory set to the size variables value
	Grid = new Cell[Size];
	//Sets the square root of the size variables value to the temp2 variable
	int temp2 = sqrt(Size);
	//Set up a new int variable called y and initialized to 0
	int y = 0;
	//Loop through array
	for (int i = 0; i < Size; ++i)
	{
		//Set x variable to i % 2
		int x = i % temp2;
		//Gives the Grid index its values 
		Grid[i] = cCell.StoreCells(y, x);
		//int x = i % temp2;
		if (x == temp2 - 1)
		{//increase y value by 1
			y++;
		}
		
>>>>>>> origin/master

	}
	//create a string variable called s
	string s;
	//create of stream object and called it File
	ofstream File;
	//Open the file object called Wumpus Map.txt
	File.open("Wumpus Map.txt", ios_base::out);
	//Error Checking
	if (File.fail())
	{//If failed to open print this
		cout << "File Could Not Be Opened!\n";
	}
	else
	{
		//Loop through array
		for (int i = 0; i < Size; ++i)
		{
			//Gives the Grid index its values 
			int x = i % temp2;
			//Stores the grid positions into the file
			File << Grid[i].GetPositionY() << "," << Grid[i].GetPositionX() << " ";
			//Set x variable to i % 2
			//int x = i % temp2;
			//if x is equal to temp2 - 1
			if (x == temp2 - 1)
			{//Stores an end line to the file
				File << endl;
			}


		}
		//Closes the file
		File.close();
		


	}
	//delete the allocated array data
	delete[] Grid;

}

//Generate Grid From File
void Grid::GenerateGridFromFile()
{//Create instance of cell object and call it Wumpus so the functions from the respective class can be accessed
	Cell Wumpus;
	//create a string variable and call it s
	string s;
	//create an ifstream object and call it file
	ifstream File;
	//open the file called Wumpus Map.txt and be able to read from it
	File.open("Wumpus Map.txt", ios_base::in);
	//Error checking
	if (File.fail())
	{//If file failed to open then print this
		cout << "File Could Not Be Opened!\n";
	}
	else
	{//while loop - while able to read in data from the file and store it into the s variable
		while (getline(File, s))
		{//Print out the data and an endl;
			cout << s;
			cout << endl;
		}
		

	}
	//print out an end line
	cout << endl;
	//close the file
	File.close();

}

//Prints Player Instructions, Inventory and map
void Grid::PrintGame()
{
<<<<<<< HEAD
	Player player;
	
	system("cls");
	GenerateGridFromFile();

=======
	//create a player object and call it player
	Player player;
	//clear the screen
	system("cls");
	//Print grid to the screen from the file
	GenerateGridFromFile();
	//Print out input options
>>>>>>> origin/master
	cout << "What Would You Like To Do?\n\n";
	cout << "Move Up: w\n";
	cout << "Move Up: a\n";
	cout << "Move Up: s\n";
	cout << "Move Up: d\n";
	cout << "Use Arrow: 1\n\n";
<<<<<<< HEAD
	player.Inventory();

}

=======
	//call player inventory function to print inventory to screen
	player.Inventory();
>>>>>>> origin/master

}
