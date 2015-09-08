///////////////////////////////////////////////////////////////////////////////////////////////
//File: Player.cpp
//Author: Andrew Miller
//Date Created: 09/03/2015
//Brief: This is the player cpp file . It will contain all the players functions and define them
///////////////////////////////////////////////////////////////////////////////////////////////

#include "Player.h"
#include "Game.h"

Player::Player()
{
	m_iX = 0;
	m_iY = 0;

}

Player::~Player()
{

}

struct Items
{
	int iIndex;
	string sName;
	int iQuantity;

};

bool wumpus = true;

Items iItems[3] = { { 1, "Arrow", 1 }, { 2, "Remote", 1 }, { 3, "Gold", 0 } };




int Player::GetPosition()
{
	
	
	return (m_iX, m_iY);
	
}

void Player::SetPosition(int a_iX, int a_iY)
{

	m_iX = a_iX;
	m_iY = a_iY;
	
}

void Player::Victory(Player &Player)
{

	Player.GetPosition();

	if ((m_iX == 0) && (m_iY == 0) && iItems[2].iQuantity == 1)
	{
		system("cls");
		cout << "You Won!\n\n";
		cout << "Thank You For Playing!\n";
		system("PAUSE");
		exit(1);
	}

}

void Player::Actions(Player &Player)
{

	char cInput;
	cin >> cInput;

	switch (cInput)
	{
		//up
	case 'w':
		Player.GetPosition();
		Player.SetPosition(m_iX, m_iY + 1);
		system("cls");
		Player.PrintGameData();
		cout << endl;
		Wumpus(Player);
		Player.Pits(Player);
		cout << "What would you like to do?\n";
		break;

		//down
	case 's':
		Player.GetPosition();
		Player.SetPosition(m_iX, m_iY - 1);
		system("cls");
		Player.PrintGameData();
		cout << endl;
		Wumpus(Player);
		Player.Pits(Player);
		cout << "What would you like to do?\n";
		break;

		//left
	case 'a':
		Player.GetPosition();
		Player.SetPosition(m_iX - 1, m_iY);
		system("cls");
		Player.PrintGameData();
		cout << endl;
		Wumpus(Player);
		Player.Pits(Player);
		cout << "What would you like to do?\n";
		break;

		//right
	case 'd':
		Player.GetPosition();
		Player.SetPosition(m_iX + 1, m_iY);
		system("cls");
		Player.PrintGameData();
		cout << endl;
		Wumpus(Player);
		Player.Pits(Player);
		cout << "What would you like to do?\n";
		break;

		//Use Arrow
	case '1':
		system("cls");
		Player.UseArrow();
		break;

		//Use Remote
	case'2':
		system("cls");
		Player.PrintGameData();
		Player.UseRemote();
		cout << "What would you like to do?\n";
		break;

	default:
		break;



	}



}

void Player::Inventory(Player &Player)
{
	Player.GetPosition();

	for (int i = 0; i < 3; ++i)
	{
		cout << iItems[i].iIndex << ".";
		cout << iItems[i].sName << " x " << iItems[i].iQuantity << endl;


	}


}

void Player::UseArrow()
{
	Player Player;
	Player.GetPosition();

	//Checks To See If You Use Your Arrow Unwisely
	if ((m_iX <= 1) && (m_iX >= 0) && (m_iY <= 3) && (iItems[0].iQuantity == 1))
	{
		iItems[0].iQuantity = 0;
		Player.PrintGameData();
		cout << "You Wasted Your Arrow!\n";
	}

	//Check If You Have An Arrow To Use
	if ((m_iX <= 1) && (m_iX >= 0) && (m_iY <= 3) && (iItems[0].iQuantity == 0))
	{
		cout << "You Are Out Of Arrows!\n";
	}

	//Checks To See If You Use Your Arrow Unwisely
	if ((m_iX == 3) && (m_iY == 3) && (iItems[0].iQuantity == 1))
	{
		iItems[0].iQuantity = 0;
		Player.PrintGameData();
		cout << "You Wasted Your Arrow!\n";
	}

	//Check If You Have An Arrow To Use
	if ((m_iX == 3) && (m_iY == 3) && (iItems[0].iQuantity == 0))
	{
		Player.PrintGameData();
		cout << "You Are Out Of Arrows!\n";
	}

	//Checks To See If You Use Your Arrow Unwisely
	if ((m_iX == 3) && (m_iY == 1) && (iItems[0].iQuantity == 1))
	{
		iItems[0].iQuantity = 0;
		Player.PrintGameData();
		cout << "You Wasted Your Arrow!\n";
	}

	//Check If You Have An Arrow To Use
	if ((m_iX == 3) && (m_iY == 1) && (iItems[0].iQuantity == 0))
	{
	    Player.PrintGameData();
		cout << "You Are Out Of Arrows!\n";
	}

	//Checks To See If You Use Your Arrow Unwisely
	if ((m_iX == 2) && (m_iY == 0) && (iItems[0].iQuantity == 1))
	{
		iItems[0].iQuantity = 0;
		Player.PrintGameData();
		cout << "You Wasted Your Arrow!\n";
	}
	
	//Check If You Have An Arrow To Use
	if ((m_iX == 2) && (m_iY == 0) && (iItems[0].iQuantity == 0))
	{
		Player.PrintGameData();
		cout << "You Are Out Of Arrows!\n";
	}

	AttackWumpus(Player);
	
}

void Player::UseRemote()
{
	Player Player;

	Player.GetPosition();
	if ((m_iX == 0) && (m_iY == 0))
	{
		cout << "Beep Beep...Breeze Detected\n";
	}

	cout << endl;

	if((m_iX == 0) && (m_iY == 1))
	{
		cout << "Beep Beep...Breeze Detected\n";
	}

	if ((m_iX == 0) && (m_iY == 3))
	{
		cout << "Beep Beep...Breeze Detected\n";
	}

	if ((m_iX == 1) && (m_iY == 1))
	{
		cout << "Beep Beep...Breeze Detected\n\n";
		cout << "Beep Beep...Breeze Detected\n";
	}

	if ((m_iX == 1) && (m_iY == 3))
	{
		cout << "Beep Beep...Breeze Detected\n";
	}

	if ((m_iX == 2) && (m_iY == 0))
	{
		cout << "Beep Beep...Breeze Detected\n\n";
		cout << "Beep Beep...Breeze Detected\n";
	}

	if ((m_iX == 2) && (m_iY == 1))
	{
		cout << "Beep Beep...Smell Detected\n";
	}

	if ((m_iX == 2) && (m_iY == 2))
	{
		cout << "You Died By The Wumbus\n";
	}

	if ((m_iX == 2) && (m_iY == 3))
	{
		cout << "Beep Beep...Smell Detected\n\n";
		cout << "Beep Beep...Glitter Detected\n";
	}

	if ((m_iX == 3) && (m_iY == 1))
	{
		cout << "Beep Beep...Breeze Detected\n";
	}

	if ((m_iX == 3) && (m_iY == 2))
	{
		cout << "Beep Beep...Glitter Detected\n\n";
		cout << "Beep Beep...Smell Detected\n";
	}
	
	
}

void Player::FoundGold(Player &Player)
{

	Player.GetPosition();

	
	
	if ((m_iX == 3) && (m_iY == 3))
	{
		system("cls");
		iItems[2].iQuantity = 1;
		Player.PrintGameData();
		cout << endl;
		cout << "Found the gold!\n";
		cout << endl;
		cout << "What Would You Like To Do?\n";
		
	}

	
	
}

void Player::PrintGameData()
{
	Player Player;

	cout << "Move Up: w" << endl;
	cout << "Move Down: s" << endl;
	cout << "Move Left: a" << endl;
	cout << "Move Right: d" << endl;
	cout << endl;


	cout << "Inventory:\n";
	Player.Inventory(Player);
	cout << endl;

	if (m_iX < 0)
	{

		m_iX = m_iX + 1;
		cout << "There Is A Wall There!\n";
	}

	if (m_iX > 3)
	{
		m_iX = m_iX - 1;
		cout << "There Is A Wall There!\n";
	}

	if (m_iY < 0)
	{
		m_iY = m_iY + 1;
		cout << "There Is A Wall There!\n";
	}

	if (m_iY > 3)
	{
		m_iY = m_iY - 1;
		cout << "There Is A Wall There!\n";
	}

	cout << "Current position: " << m_iX << "," << m_iY << endl;

}

void Player::AttackWumpus(Player &Player)
{

	Player.GetPosition();

	if ((m_iX == 2) && (m_iY == 3) && (iItems[0].iQuantity == 1) ||
		(m_iX == 3) && (m_iY == 2) && (iItems[0].iQuantity == 1) ||
		(m_iX == 2) && (m_iY == 1) && (iItems[0].iQuantity == 1))
	{
		system("cls");
		iItems[0].iQuantity = 0;
		PrintGameData();
		cout << "You Killed The Wumpus!\n\n";
		wumpus = false;
		cout << "What would you like to do?\n";

	}

	else if ((m_iX == 2) && (m_iY == 3) && (iItems[0].iQuantity == 0) ||
		(m_iX == 3) && (m_iY == 2) && (iItems[0].iQuantity == 0) ||
		(m_iX == 2) && (m_iY == 1) && (iItems[0].iQuantity == 0))
	{
		system("cls");
		PrintGameData();
		cout << "You Dont Have An Arrow To Kill The Wumpus With!\n";
		cout << "What would you like to do?\n";
	}
}

void Player::Wumpus(Player &Player)
{
	Player.GetPosition();
	

	if ((m_iX == 2) && (m_iY == 2) && (wumpus == true))
		{
			system("cls");
			cout << "You Were Killed By The Wumpus....Game Over!\n";
			system("PAUSE");
			exit(1);

		}

		else if ((m_iX == 2) && (m_iY == 2) && (wumpus == false))
		{
			system("cls");
			PrintGameData();
			cout << "\nYou See The Remains Of The Wumpus.\n";
			

		}

}

void Player::Pits(Player &Player)
{

	Player.GetPosition();

	if ((m_iX == 0) && (m_iY == 2))
	{
		system("cls");
		cout << "You Fell Into A Pit....Game Over!\n";
		system("PAUSE");
		exit(1);
	}

	if ((m_iX == 1) && (m_iY == 0))
	{
		system("cls");
		cout << "You Fell Into A Pit....Game Over!\n";
		system("PAUSE");
		exit(1);
	}

	if ((m_iX == 1) && (m_iY == 2))
	{
		system("cls");
		cout << "You Fell Into A Pit....Game Over!\n";
		system("PAUSE");
		exit(1);
	}

	if ((m_iX == 3) && (m_iY == 0))
	{
		system("cls");
		cout << "You Fell Into A Pit....Game Over!\n";
		system("PAUSE");
		exit(1);
	}

}