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

struct Items
{
	string sName;
	int iQuantity;

};

Items iItem[2] = {{ "Arrow", 1 }, {"Gold", 0}};

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
	{
		SetPosition(m_iX, m_iY - 1);
		gGrid.PrintGame();
		cCell.Pits(pPlayer, GetPositionY(), GetPositionX());
		cCell.Wumpus(pPlayer, GetPositionY(), GetPositionX());
		cCell.Gold(pPlayer, GetPositionY(), GetPositionX());
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX() << endl;
		break;
	}
	case 'a':
	{
		SetPosition(m_iX - 1, m_iY);
		gGrid.PrintGame();
		cCell.Pits(pPlayer, GetPositionY(), GetPositionX());
		cCell.Wumpus(pPlayer, GetPositionY(), GetPositionX());
		cCell.Gold(pPlayer, GetPositionY(), GetPositionX());
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX() << endl;
		break;
	}
	case 's':
	{
		SetPosition(m_iX, m_iY + 1);
		gGrid.PrintGame();
		cCell.Pits(pPlayer, GetPositionY(), GetPositionX());
		cCell.Wumpus(pPlayer, GetPositionY(), GetPositionX());
		cCell.Gold(pPlayer, GetPositionY(), GetPositionX());
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX() << endl;
		break;
	}
	case 'd':
	{
		SetPosition(m_iX + 1, m_iY);
		gGrid.PrintGame();
		cCell.Pits(pPlayer, GetPositionY(), GetPositionX());
		cCell.Wumpus(pPlayer, GetPositionY(), GetPositionX());
		cCell.Gold(pPlayer, GetPositionY(), GetPositionX());
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX() << endl;
		break;
	}
	case '1':
	{
		Attack();
		break;
	}
	    
	default:
	{
		break;
	}
		
	};



}

bool bWumpus = true;

bool Player::Attack()
{
	Cell Wumpus;
	Grid gGrid;

	if (((((GetPositionX() == 1 && GetPositionY() == 2) && 
		(Wumpus.GetLife() == true) && (iItem[0].iQuantity == 1) ||
		(GetPositionX() == 3 && GetPositionY() == 2) && 
		(Wumpus.GetLife() == true) && (iItem[0].iQuantity == 1) || 
		(GetPositionX() == 2 && GetPositionY() == 1) && 
		(Wumpus.GetLife() == true) && (iItem[0].iQuantity == 1) || 
		(GetPositionX() == 2 && GetPositionY() == 3) && 
		(Wumpus.GetLife() == true) && (iItem[0].iQuantity == 1)))))
	{
		bWumpus = false;
		iItem[0].iQuantity--;
		gGrid.PrintGame();
		cout << "You Have Killed The Wumpus!\n";
	}

	/*else if  (((((GetPositionX() != 2 && GetPositionY() != 3) &&
		(GetPositionX() != 2 && GetPositionY() != 1) &&
		(GetPositionX() != 3 && GetPositionY() != 2) &&
		(GetPositionX() != 1 && GetPositionY() != 2) &&
		(iItem[0].iQuantity == 1)))))
	{
		iItem[0].iQuantity--;
		gGrid.PrintGame();
		cout << "You Have Wasted Your Arrow!\n";
	}*/

	return bWumpus;
}

void Player::Inventory()
{
	cout << "Inventory:\n";
	for (int i = 0; i < 2; ++i)
	{
		cout << iItem[i].sName << " x " << iItem[i].iQuantity << endl;
	}

}

void Player::StartAdventure()
{
	Grid gGrid;

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

void Player::FoundGold(int &x, int &y)
{
	Grid gGrid;
	if ((x == 3 && y == 3) && (iItem[1].iQuantity == 0))
	{
		iItem[1].iQuantity++;
		gGrid.PrintGame();
		cout << "You Found The Gold!\n";
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
//		gGrid.GenerateGridToFile();
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

