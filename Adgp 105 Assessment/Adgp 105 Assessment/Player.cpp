//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Player.cpp
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Player cpp file. It will contain all the Player Class function definitions and variable definitions.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


#include "Player.h"
#include "Grid.h"
#include "Cell.h"

Player::Player()
{
	m_iX = 0;
	m_iY = 0;

}


Player::~Player()
{
}

int Player::GetPositionX()
{
	return m_iX;
}

int Player::GetPositionY()
{
	return m_iY;
}

void Player::SetPosition(int a_iX, int a_iY)
{
	m_iX = a_iX;
	m_iY = a_iY;


}

void Player::Move()
{
	Grid gGrid;
	Cell cCell;
	Player pPlayer;

	char cInput;
	cout << endl;
	cin >> cInput;

	switch (cInput)
	{
	case 'w':
		SetPosition(m_iX, m_iY - 1);
		system("cls");
		gGrid.PrintGame();
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX();
		break;

	case 'a':
		SetPosition(m_iX - 1, m_iY);
		system("cls");
		gGrid.PrintGame();
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX();
		break;

	case 's':
		SetPosition(m_iX, m_iY + 1);
		system("cls");
		gGrid.PrintGame();
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX();
		break;

	case 'd':
		SetPosition(m_iX + 1, m_iY);
		system("cls");
		gGrid.PrintGame();
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX();
		break;

	case '1':
		gGrid.PrintGame();
		system("cls");
		Attack();
		break;



		default:
		break;

	}



}

void Player::Attack()
{




}

void Player::StartAdventure()
{
	char cInput;
	cout << "Welcome To The Wumpus Adventure!\n\n";
	cout << "Would You Like To Play Or Quit? Enter P or Q:\n";
	cin >> cInput;

	if (cInput == 'P' || cInput == 'p')
	{
		system("cls");
		
	}
	else if (cInput == 'Q' || cInput == 'q')
	{
		system("cls");
		cout << "You Have Quit The Game!\n";

	}
	else
	{
		cout << "Invalid Input!\n";
		exit(1);
	}




}

//void Player::ChooseMap()
//{
//	Grid gGrid;
//
//	int iInput;
//	
//	cout << "Please Choose A Map:\n";
//	cout << "1.Generate Random Map\n";
//	cout << "2.Generate Map From File\n";
//	cin >> iInput;
//
//	if (iInput == 1)
//	{
//		system("cls");
//		gGrid.GenerateRandomGrid();
//	}
//	else if (iInput == 2)
//	{
//		system("cls");
//		gGrid.GenerateGridFromFile();
//
//	}
//	else
//	{
//		cout << "Invalid Input!\n";
//		exit(1);
//	}
//
//}

void Player::Inventory()
{
	struct Items
	{
		string sName;
		int iQuantity;
	};

	Items iItem;

	iItem.sName = "Arrow";
	iItem.iQuantity = 1;


	cout << "Inventory:\n"; 
	cout << iItem.sName << " x " << iItem.iQuantity << endl; 
}