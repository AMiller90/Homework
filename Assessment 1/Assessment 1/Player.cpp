//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Player.cpp
//Author: Andrew Miller
//Date Created: 09/03/2015
//Brief: This is the Player cpp file. It will contain all the Player Class function definitions and variable definitions.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Include Header Files Of Classes In Order To Use Them
#include "Player.h"
#include "Game.h"

//Constructor Definition
Player::Player()
{
	//Initialize The Players Position To Zero
	m_iX = 0;
	m_iY = 0;
}
//Constructor Definition
Player::~Player()
{

}


//Item Struct Created To Give Player An Inventory
struct Items
{
	//Variable Representing The Index Of The Item Struct
	int iIndex;
	//Variable Representing The Names Of The Items
	string sName;
	//Variable To Represent The Quantity Of Each Item In The Inventory
	int iQuantity;

};

//Bool Variable Used To Represent The Wumpus Life. It Is Set To True Meaning The Wumpu Is Alive
bool wumpus = true;

//Creates An Array Of 3 Items Using The Item Struct And Its Variables.Then Initializes The Items After The "=" Sign.
Items iItems[3] = { { 1, "Arrow", 1 }, { 2, "Remote", 1 }, { 3, "Gold", 0 } };

//Function Used To Get The Private Variables Of This Class So They Can Be Used Outside The Class If Need Be.
int Player::GetPositionX()
{

	return m_iX;

}

//Function Used To Get The Private Variables Of This Class So They Can Be Used Outside The Class If Need Be.
int Player::GetPositionY()
{

	return m_iY;
}

//Function Used To Set The Player Position To 2 integer Variables if Wanting To Set Them To Something Different
void Player::SetPosition(int a_iX, int a_iY)
{

	m_iX = a_iX;
	m_iY = a_iY;
	
}

//This Function Takes User Input To Move The Player In The Cave And Use The Inventory Items
void Player::Actions()
{
	//Create An Instance Of The Game Class So The Program Can Use Its Functions 
	Game game;

	
	char cInput;
	//Gets Input From User
	cin >> cInput;

	//Switch Statement - Going To Be Used For Moving Player
	switch (cInput)
	{
		//Move Player Up
	case 'w':
		//Sets Player Position To New Position Based On Key Inputted
        SetPosition(m_iX, m_iY + 1);
		//Calls PrintGameData Function
		PrintGameData();
		//Calls Wumpus Function
		Wumpus();
		//Calls Pits Function
		Pits();
		cout << "What would you like to do?\n";
		break;

		//Move Player Down
	case 's':
		//Sets Player Position To New Position Based On Key Inputted
		SetPosition(m_iX, m_iY - 1);
		//Calls PrintGameData Function
		PrintGameData();
		//Calls Wumpus Function
		Wumpus();
		//Calls Pits Function
		Pits();
		cout << "What would you like to do?\n";
		break;

		//Move Player Left
	case 'a':
		//Sets Player Position To New Position Based On Key Inputted
		SetPosition(m_iX - 1, m_iY);
		//Calls PrintGameData Function
		PrintGameData();
		//Calls Wumpus Function
		Wumpus();
		//Calls Pits Function
		Pits();
		cout << "What would you like to do?\n";
		break;

		//Move Player Right
	case 'd':
		//Sets Player Position To New Position Based On Key Inputted
		SetPosition(m_iX + 1, m_iY);
		//Calls PrintGameData Function
		PrintGameData();
		//Calls Wumpus Function
		Wumpus();
		//Calls Pits Function
		Pits();
		cout << "What would you like to do?\n";
		break;

		//Brings Up The Help Menu
	case 'h':
		//Calls HelpMenu Function
		game.HelpMenu();
		//Calls PrintGameData Function
		PrintGameData();
		cout << "What would you like to do?\n";
		break;

		//Uses The Arrow
	case '1':
		//Calls UseArrow Function
		UseArrow();
		break;

		//Uses The Remote
	case'2':
		//Calls UseRemote Function
		UseRemote();
		break;

	default:
		break;



	}



}

//This Function Sets Up The Players Inventory
void Player::Inventory()
{
	//This For Loop Is Used To Iterate(Loop) Through The Index Of All The Variables In The Item Struct And Then Prints Them
	for (int i = 0; i < 3; ++i)
	{
		cout << iItems[i].iIndex << ".";
		cout << iItems[i].sName << " x " << iItems[i].iQuantity << endl;


	}


}

//This Function Allows The Player To Use The Arrow From The Inventory
void Player::UseArrow()
{
	//Clears The Screen
	system("cls");
	//Calls PrintGameFunction
	PrintGameData();

	//Checks To See If Player Uses The Arrow Unwisely
	if ((m_iX <= 1) && (m_iX >= 0) && (m_iY <= 3) && (iItems[0].iQuantity == 1))
	{
		iItems[0].iQuantity = 0;
		cout << "You Wasted Your Arrow!\n\n";
	}

	//Check If Player Has An Arrow To Use
	if ((m_iX <= 1) && (m_iX >= 0) && (m_iY <= 3) && (iItems[0].iQuantity == 0))
	{
		cout << "You Are Out Of Arrows!\n";
	}

	//Checks To See If Player Uses The Arrow Unwisely
	if ((m_iX == 3) && (m_iY == 3) && (iItems[0].iQuantity == 1))
	{
		iItems[0].iQuantity = 0;
		cout << "You Wasted Your Arrow!\n";
	}

	//Check If Player Has An Arrow To Use
	if ((m_iX == 3) && (m_iY == 3) && (iItems[0].iQuantity == 0))
	{
		cout << "You Are Out Of Arrows!\n";
	}

	//Checks To See If Player Uses The Arrow Unwisely
	if ((m_iX == 3) && (m_iY == 1) && (iItems[0].iQuantity == 1))
	{
		iItems[0].iQuantity = 0;
		cout << "You Wasted Your Arrow!\n";
	}

	//Check If Player Has An Arrow To Use
	if ((m_iX == 3) && (m_iY == 1) && (iItems[0].iQuantity == 0))
	{
		cout << "You Are Out Of Arrows!\n";
	}

	//Checks To See If Player Uses The Arrow Unwisely
	if ((m_iX == 2) && (m_iY == 0) && (iItems[0].iQuantity == 1))
	{
		iItems[0].iQuantity = 0;
		cout << "You Wasted Your Arrow!\n";
	}
	
	//Check If Player Has An Arrow To Use
	if ((m_iX == 2) && (m_iY == 0) && (iItems[0].iQuantity == 0))
	{
		cout << "You Are Out Of Arrows!\n";
	}
	//Calls The AttackWumpus Function
	AttackWumpus();
	
	cout << "What would you like to do?\n";
}

//This Function Allows The Player To Use The Remote From The Inventory
void Player::UseRemote()
{
	system("cls");
	PrintGameData();

	//These If Statements Check The Currently Players Position And Print Out To The Screen The Hint of What Dangers Or If The Gold
	//Is Nearby. I Have The Hints Printed Out Accordng To The Locatons Of The Dangers And Gold.
	if ((m_iX == 0) && (m_iY == 0))
	{//Prints Out Beep For Pits Nearby
		cout << "Beep Beep...Breeze Detected\n";
	}

	cout << endl;

	if((m_iX == 0) && (m_iY == 1))
	{//Prints Out Beep For Pits Nearby
		cout << "Beep Beep...Breeze Detected\n";
	}

	if ((m_iX == 0) && (m_iY == 3))
	{//Prints Out Beep For Pits Nearby
		cout << "Beep Beep...Breeze Detected\n";
	}

	if ((m_iX == 1) && (m_iY == 1))
	{//Prints Out Beep For Pits Nearby..2 Pits Nearby
		cout << "Beep Beep...Breeze Detected\n\n";
		cout << "Beep Beep...Breeze Detected\n";
	}

	if ((m_iX == 1) && (m_iY == 3))
	{//Prints Out Beep For Pits Nearby
		cout << "Beep Beep...Breeze Detected\n";
	}

	if ((m_iX == 2) && (m_iY == 0))
	{//Prints Out Beep For Pits Nearby..2 Pits Nearby
		cout << "Beep Beep...Breeze Detected\n\n";
		cout << "Beep Beep...Breeze Detected\n";
	}

	if ((m_iX == 2) && (m_iY == 1))
	{//Prints Out Smell For The Wumpus Nearby
		cout << "Beep Beep...Smell Detected\n";
	}

	if ((m_iX == 2) && (m_iY == 3))
	{//Prints Out Smell For The Wumpus Nearby And Glitter For Gold Nearby
		cout << "Beep Beep...Smell Detected\n\n";
		cout << "Beep Beep...Glitter Detected\n";
	}

	if ((m_iX == 3) && (m_iY == 1))
	{//Prints Out Breeze For Pits Nearby
		cout << "Beep Beep...Breeze Detected\n";
	}

	if ((m_iX == 3) && (m_iY == 2))
	{//Prints Out Smell For The Wumpus Nearby And Glitter For Gold NEarby
		cout << "Beep Beep...Glitter Detected\n\n";
		cout << "Beep Beep...Smell Detected\n";
	}
	
	cout << "What would you like to do?\n";
}

//This Function Allows The Player To Automatically Get The Gold And Put It Into The Inventory
void Player::FoundGold()
{
	//This If Statement Checks The Players Position.
	if ((m_iX == 3) && (m_iY == 3))
	{
		//If Players Position Is Equal To The Above Coordinates Then The Player Is In The Room With The Gold
		system("cls");
		//This Sets The Item Golds Quantity to 1..Meaning It Was Found
		iItems[2].iQuantity = 1;
		//Calls Print Function And Now It Will Show The Gold Having 1 In Inventory
		PrintGameData();
		cout << endl;
		//Prompts Player The Found The Gold
		cout << "Found the gold!\n";
		cout << endl;
		cout << "What Would You Like To Do?\n";
		
	}

	
	
}

//This Function Is Used To Check If The Player Made It Back To The Entrance With The Gold. If So, Player Wins.
void Player::Victory()
{
	//If Statement Checks Players Position And If The Gold Is In The Inventory
	if ((m_iX == 0) && (m_iY == 0) && iItems[2].iQuantity == 1)
	{
		//If Statement Is Correct Then The Screen Is Cleared And You Won And Thank You For Playing Are Prompted To The Screen
		//Then The Program Exits.
		system("cls");
		cout << "You Won!\n\n";
		cout << "Thank You For Playing!\n";
		system("PAUSE");
		//Exits Program
		exit(1);
	}

}
//This Function Prints The Controls, Inventory, Players Current Position And If They Run Into A Wall Out Onto The Screen.
void Player::PrintGameData()
{

	//Clears Screen
	system("cls");
	//Prints The Controls
	cout << "Controls:\n";
	cout << "Move Up: w" << endl;
	cout << "Move Down: s" << endl;
	cout << "Move Left: a" << endl;
	cout << "Move Right: d" << endl;
	cout << "Help Menu: h" << endl;
	cout << endl;


	cout << "Inventory:\n";
	//Prints Players Inventory
	Inventory();
	cout << endl;

	//If Statement Checks If Players X Positon Is Less Than 0
	if (m_iX < 0)
	{
		//If Statement Is True Then Add 1 To The X Position To Stop The Player From Moving To That Position 
		//Then Print Out There Is A Wall At That Location.
		m_iX = m_iX + 1;
		cout << "There Is A Wall There!\n";
	}
	//If Statement Checks If Players X Positon Is Greater Than 3
	if (m_iX > 3)
	{//If Statement Is True Then Subtract 1 From The X Position To Stop The Player From Moving To That Position 
		//Then Print Out There Is A Wall At That Location.
		m_iX = m_iX - 1;
		cout << "There Is A Wall There!\n";
	}
	//If Statement Checks If Players Y Positon Is Less Than 0
	if (m_iY < 0)
	{//If Statement Is True Then Add 1 To The Y Position To Stop The Player From Moving To That Position 
		//Then Print Out There Is A Wall At That Location.
		m_iY = m_iY + 1;
		cout << "There Is A Wall There!\n";
	}
	//If Statement Checks If Players Y Positon Is Greater Than 3
	if (m_iY > 3)
	{//If Statement Is True Then Subtract 1 From The Y Position To Stop The Player From Moving To That Position 
			//Then Print Out There Is A Wall At That Location.
		m_iY = m_iY - 1;
		cout << "There Is A Wall There!\n";
	}
	//Print Out Players Current Position
	cout << "Current position: " << m_iX << "," << m_iY << "\n\n";
	
}
//This Function Determines If The Wumpus Is killed Or If The Player Does Not Have An Arrow To Use
void Player::AttackWumpus()
{
	//If Statement Checks If The Players Current Position Is In Any Of The Adjacent Rooms Of The Wumpus AND If The Player Has An
	//Arrow In The Inventory To Use.
	if ((m_iX == 2) && (m_iY == 3) && (iItems[0].iQuantity == 1) ||
		(m_iX == 3) && (m_iY == 2) && (iItems[0].iQuantity == 1) ||
		(m_iX == 2) && (m_iY == 1) && (iItems[0].iQuantity == 1))
	{//If Statement Is True Then clear Screen
		system("cls");
		//Set Arrow Quantity to 0
		iItems[0].iQuantity = 0;
		//PrintGameData
		PrintGameData();
		//Prompt User That Wumpus Is Killed
		cout << "You Killed The Wumpus!\n\n";
		//Set Wumpus To False..Meaning It Is Now Dead
		wumpus = false;

	}
	//Else if Statment Means If The Above Statements Are Not Correct Then Check This Statement
	//This Statement Checks If The Players Current Position Is In Any Of The Adjacent Rooms Of The Wumpus AND If The Player Does Not Have An
	//Arrow In The Inventory To Use.
	else if ((m_iX == 2) && (m_iY == 3) && (iItems[0].iQuantity == 0) ||
		(m_iX == 3) && (m_iY == 2) && (iItems[0].iQuantity == 0) ||
		(m_iX == 2) && (m_iY == 1) && (iItems[0].iQuantity == 0))
	{//If Statement Is True Then clear Screen
		system("cls");
		//PrintGameData
		PrintGameData();
		//Prompt User That They Dont Have An Arrow To Kill The Wumpus With
		cout << "You Dont Have An Arrow To Kill The Wumpus With!\n";

	}
}
//This Function Checks The Wumpus Life
void Player::Wumpus()
{
	//If Players Current Position Is Equal To The Room Coordinates The Wumpus Is In AND Wumpus Is Alive 
	if ((m_iX == 2) && (m_iY == 2) && (wumpus == true))
		{//Then If The Statement Is True Then Clear Screen
			system("cls");
			//Then Prompt User They Were Killed By The Wumpus And The Game Is Over
			cout << "You Were Killed By The Wumpus....Game Over!\n";
			//Then The Screen Is Paused
			system("PAUSE");
			//Then The Program Is Exited When Any Key Is Pressed
			exit(1);

		}
	//Else If Players Current Position Is Equal To The Room Coordinates The Wumpus Is In AND Wumpus Is Dead
		else if ((m_iX == 2) && (m_iY == 2) && (wumpus == false))
		{//Then If The Statement Is True Then Clear Screen
			system("cls");
			//PrintGameData
			PrintGameData();
			//Prompt User That They Can See The Remains Of The Wumpus
			cout << "\nYou See The Remains Of The Wumpus.\n";
			

		}

}
//This Function Checks For The Players Position In The Level And The Pit Positions
void Player::Pits()
{
	//If Players Position Is Equal To These Coordinates 
	if ((m_iX == 0) && (m_iY == 2))
	{//Then Clear Screen
		system("cls");
		//Prompt User They Fell Into A Pit And Game Is Over
		cout << "You Fell Into A Pit....Game Over!\n";
		//Then The Screen Is Paused
		system("PAUSE");
		//Then The Program Is Exited When Any Key Is Pressed
		exit(1);
	}
	//If Players Position Is Equal To These Coordinates
	if ((m_iX == 1) && (m_iY == 0))
	{//Then Clear Screen
		system("cls");
		//Prompt User They Fell Into A Pit And Game Is Over
		cout << "You Fell Into A Pit....Game Over!\n";
		//Then The Screen Is Paused
		system("PAUSE");
		//Then The Program Is Exited When Any Key Is Pressed
		exit(1);
	}
	//If Players Position Is Equal To These Coordinates
	if ((m_iX == 1) && (m_iY == 2))
	{//Then Clear Screen
		system("cls");
		//Prompt User They Fell Into A Pit And Game Is Over
		cout << "You Fell Into A Pit....Game Over!\n";
		//Then The Screen Is Paused
		system("PAUSE");
		//Then The Program Is Exited When Any Key Is Pressed
		exit(1);
	}
	//If Players Position Is Equal To These Coordinates
	if ((m_iX == 3) && (m_iY == 0))
	{//Then Clear Screen
		system("cls");
		//Prompt User They Fell Into A Pit And Game Is Over 
		cout << "You Fell Into A Pit....Game Over!\n";
		//Then The Screen Is Paused
		system("PAUSE");
		//Then The Program Is Exited When Any Key Is Pressed
		exit(1);
	}

}

