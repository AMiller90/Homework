//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Player.cpp
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Player cpp file. It will contain all the Player Class function definitions and variable definitions.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Include Player header file to be able to use its class functions
#include "Player.h"
//Include Grid header file to be able to use its class functions
#include "Grid.h"
//Include Cell header file to be able to use its class functions
#include "Cell.h"

//Constructor Definition
Player::Player()
{
	//Initializes Player Position to 0,0
	m_iX = 0;
	m_iY = 0;

}

//Destructor Definition
Player::~Player()
{
	//Is not initialized
}

//Item Struct Created To Give Player An Inventory
struct Items

{//Variable Representing The Names Of The Items
	string sName;
	//Variable To Represent The Quantity Of Each Item In The Inventory
	int iQuantity;

};
//Creates An Array Of 2 Items Using The Item Struct And Its Variables.Then Initializes The Items After The "=" Sign.
Items iItem[2] = {{ "Arrow", 1 }, {"Gold", 0}};

//Function Used To Get The Private Variable m_iX Of This Class So They Can Be Used Outside The Class If Need Be.
int Player::GetPositionX()
{//return the m_iX value
	return m_iX;
}

//Function Used To Get The Private Variable m_iY Of This Class So They Can Be Used Outside The Class If Need Be.
int Player::GetPositionY()
{//return the m_iY value
	return m_iY;
}

//Function Used To Set The Player Position To 2 integer Variables if Wanting To Set Them To Something Different
void Player::SetPosition(int a_iX, int a_iY)
{
	//Sets the variable m_iX to value passed in from a_iX variable
	m_iX = a_iX;
	//Sets the variable m_iY to value passed in from a_iY variable
	m_iY = a_iY;


}

//This Function Takes User Input To Move The Player In The Cave And Use The Inventory Items
void Player::Move()
{
	//Create instances of Grid, Cell and Player - So the functions can be used from their respective classes
	Grid gGrid;
	Cell cCell;
	Player pPlayer;
    //Char type Variable that will be used to store users input
	char cInput;
	cout << endl;
	//Get user input and store it in cInput variable
	cin >> cInput;
	//switch statement for checking user input and movement
	switch (cInput)
	{
	//Move down the Y axis
	case 'w':
	{//Set players position to new coordinates
		SetPosition(m_iX, m_iY - 1);
		//Call PrintGame function
		gGrid.PrintGame();
		//Check if current Y position is less than 0
		if (m_iY < 0)
		{//if statement is true then set the players Y position back to 0
			SetPosition(m_iX, m_iY = 0);
			//Print this
			cout << "There is a wall there!\n";
		}
		//Calls Pits function 
		cCell.Pits(GetPositionY(), GetPositionX());
		//Calls Wumpus Function
		cCell.Wumpus(pPlayer, GetPositionY(), GetPositionX());
		//Calls Gold Function
		cCell.Gold(pPlayer, GetPositionY(), GetPositionX());
		//Print Players Current Position To Screen
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX() << endl;
		break;
	}
	//Move down the X axis
	case 'a':
	{//Set players position to new coordinates
		SetPosition(m_iX - 1, m_iY);
		//Call PrintGame function
		gGrid.PrintGame();
		//Check if current X position is less than 0
		if (m_iX < 0)
		{//if statement is true then set the players X position back to 0
			SetPosition(m_iX = 0, m_iY);
			//Print this
			cout << "There is a wall there!\n";
		}
		//Calls Pits function 
		cCell.Pits(GetPositionY(), GetPositionX());
		//Calls Wumpus Function
		cCell.Wumpus(pPlayer, GetPositionY(), GetPositionX());
		//Calls Gold Function
		cCell.Gold(pPlayer, GetPositionY(), GetPositionX());
		//Print Players Current Position To Screen
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX() << endl;
		break;
	}
	//Move up the Y axis
	case 's':
	{//Set players position to new coordinates
		SetPosition(m_iX, m_iY + 1);
		//Call PrintGame function
		gGrid.PrintGame();
		//Check if current X position is less than 0
		if (m_iY > 3)
		{//if statement is true then set the players X position back to 0
			SetPosition(m_iX, m_iY = 3);
			//Print this
			cout << "There is a wall there!\n";
		}
		//Calls Pits function
		cCell.Pits(GetPositionY(), GetPositionX());
		//Calls Wumpus Function
		cCell.Wumpus(pPlayer, GetPositionY(), GetPositionX());
		//Calls Gold Function
		cCell.Gold(pPlayer, GetPositionY(), GetPositionX());
		//Print Players Current Position To Screen
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX() << endl;
		break;
	}
	//Move up the X axis
	case 'd':
	{//Set players position to new coordinates
		SetPosition(m_iX + 1, m_iY);
		//Call PrintGame function
		gGrid.PrintGame();
		//Check if current X position is less than 0
		if (m_iX > 3)
		{//if statement is true then set the players X position back to 0
			SetPosition(m_iX = 3, m_iY);
			//Print this
			cout << "There is a wall there!\n";
		}
		//Calls Pits function
		cCell.Pits(GetPositionY(), GetPositionX());
		//Calls Wumpus Function
		cCell.Wumpus(pPlayer, GetPositionY(), GetPositionX());
		//Calls Gold Function
		cCell.Gold(pPlayer, GetPositionY(), GetPositionX());
		//Print Players Current Position To Screen
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX() << endl;
		break;
	}
	//Attacks
	case '1':
	{//Calls The Attack Function
		Attack();
		break;
	}
	    //Not Used
	default:
	{
		break;
	}
		
	};



}

//Bool Variable Used To Represent The Wumpus Life. It Is Set To True Meaning The Wumpus Is Alive
bool g_bWumpus = true;

//This Function Allows The Player To Use The Arrow From The Inventory To Attack and returns a boolean value
bool Player::Attack()
{
	//Creates instances of Cell objects Wumpus and gGrid to use functions that are in the Cell class
	Cell Wumpus;
	Grid gGrid;
	//if statement that checks players current position and quantity of arrows in the inventory.
	if (((((GetPositionX() == 1 && GetPositionY() == 2) && 
		(Wumpus.GetLife() == true) && (iItem[0].iQuantity == 1) ||
		(GetPositionX() == 3 && GetPositionY() == 2) && 
		(Wumpus.GetLife() == true) && (iItem[0].iQuantity == 1) || 
		(GetPositionX() == 2 && GetPositionY() == 1) && 
		(Wumpus.GetLife() == true) && (iItem[0].iQuantity == 1) || 
		(GetPositionX() == 2 && GetPositionY() == 3) && 
		(Wumpus.GetLife() == true) && (iItem[0].iQuantity == 1)))))
	{
		//If statement is true then set g_bWumpus variable to false - meaning wumpus is dead
		g_bWumpus = false;
		//Set the item at this index - 1 - indicating the player used and arrow
		iItem[0].iQuantity--;
		//Call PrintGame
		gGrid.PrintGame();
		//Print this to the screen
		cout << "You Have Killed The Wumpus!\n";
	}
	

	 
	//return the value of the g_bWumpus variable
	return g_bWumpus;
}

//This Function Sets Up The Players Inventory
void Player::Inventory()
{
	cout << "Inventory:\n";
	//This For Loop Is Used To Iterate(Loop) Through The Index Of All The Variables In The Item Struct And Then Prints Them
	for (int i = 0; i < 2; ++i)
	{
		cout << iItem[i].sName << " x " << iItem[i].iQuantity << endl;
	}

}

//Prompts User To Play Game Or Quit 
void Player::StartAdventure()
{
	//Create instance of Grid object so the functions from their respective class can be accessed
	Grid gGrid;
	//Create a char variable to store user input
	char cInput;
	//Print out intro to game
	cout << "Welcome To The Wumpus Adventure!\n\n";
	//Prompt user if they would like to play or quit
	cout << "Would You Like To Play Or Quit? Enter P or Q:\n";
	//Get user inpout and store it into cInput variable
	cin >> cInput;
	//If statment to check the input that was inputted by the user
	if (cInput == 'P' || cInput == 'p')
	{//if statment is true then clear the screen
		system("cls");
		
	}//else if statement was not true 
	else if (cInput == 'Q' || cInput == 'q')
	{//Clear the screen 
		system("cls");
		//print to the screen this
		cout << "You Have Quit The Game!\n";

	}
	else
	{//else if something else was inputted then 
		//print this
		cout << "Invalid Input!\n";
		//exit the program
		exit(1);
	}




}

//This Function Allows The Player To Automatically Get The Gold Once Inside The Room That Has The Gold And Put 
//It Into The Inventory
void Player::FoundGold(int &a_rfX, int &a_rfY)
{
	//Create an instance of a Grid object so that the functions from the respective class can be used
	Grid gGrid;
	//If statement to check players current position and the quantity of the item(Gold) at the given index
	if ((a_rfX == 3 && a_rfY == 3) && (iItem[1].iQuantity == 0))
	{//if statement is true then increase the quantitiy of the item(Gold) at the given index by 1
		iItem[1].iQuantity++;
		//Calls the PrintGame function
		gGrid.PrintGame();
		//print this to the screen
		cout << "You Found The Gold!\n";
	}
		
}

//This Function Is Used To Check If The Player Made It Back To The Entrance With The Gold. If So, Player Wins.
bool Player::Victory()
{//Created a bool variable named bVictory and set its value to true
	bool bVictory = true;
	//if statement to check players current position and the quantity of the item(Gold) at the given index
	if (((GetPositionX() == 0 && GetPositionY() == 0) &&
		iItem[1].iQuantity == 1))
	{//if statement is true then print this
		cout << "You have won! Congrats!\n";
		//set bVictory variables value to false
		bVictory = false;

	}
	//return bVictory variables value
	return bVictory;
}


