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
//Done
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
		if (m_iY < 0)
		{
			SetPosition(m_iX, m_iY = 0);
			cout << "There is a wall there!\n";
		}
		cCell.Pits(GetPositionY(), GetPositionX());
		cCell.Wumpus(pPlayer, GetPositionY(), GetPositionX());
		cCell.Gold(pPlayer, GetPositionY(), GetPositionX());
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX() << endl;
		break;
	}
	case 'a':
	{
		SetPosition(m_iX - 1, m_iY);
		gGrid.PrintGame();
		if (m_iX < 0)
		{
			SetPosition(m_iX = 0, m_iY);
			cout << "There is a wall there!\n";
		}
		cCell.Pits(GetPositionY(), GetPositionX());
		cCell.Wumpus(pPlayer, GetPositionY(), GetPositionX());
		cCell.Gold(pPlayer, GetPositionY(), GetPositionX());
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX() << endl;
		break;
	}
	case 's':
	{
		SetPosition(m_iX, m_iY + 1);
		gGrid.PrintGame();
		if (m_iY > 3)
		{
			SetPosition(m_iX, m_iY = 3);
			cout << "There is a wall there!\n";
		}
		cCell.Pits(GetPositionY(), GetPositionX());
		cCell.Wumpus(pPlayer, GetPositionY(), GetPositionX());
		cCell.Gold(pPlayer, GetPositionY(), GetPositionX());
		cout << "Current Position: " << GetPositionY() << ',' << GetPositionX() << endl;
		break;
	}
	case 'd':
	{
		SetPosition(m_iX + 1, m_iY);
		gGrid.PrintGame();
		if (m_iX > 3)
		{
			SetPosition(m_iX = 3, m_iY);
			cout << "There is a wall there!\n";
		}
		cCell.Pits(GetPositionY(), GetPositionX());
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

bool g_bWumpus = true;

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
		g_bWumpus = false;
		iItem[0].iQuantity--;
		gGrid.PrintGame();
		cout << "You Have Killed The Wumpus!\n";
	}
	

	 

	return g_bWumpus;
}
//Done
void Player::Inventory()
{
	cout << "Inventory:\n";
	for (int i = 0; i < 2; ++i)
	{
		cout << iItem[i].sName << " x " << iItem[i].iQuantity << endl;
	}

}
//Done
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
//Done
void Player::FoundGold(int &a_rfX, int &a_rfY)
{
	Grid gGrid;
	if ((a_rfX == 3 && a_rfY == 3) && (iItem[1].iQuantity == 0))
	{
		iItem[1].iQuantity++;
		gGrid.PrintGame();
		cout << "You Found The Gold!\n";
	}
		
}
//Done
bool Player::Victory()
{
	bool bVictory = true;
	if (((GetPositionX() == 0 && GetPositionY() == 0) &&
		iItem[1].iQuantity == 1))
	{
		cout << "You have won! Congrats!\n";
		bVictory = false;

	}

	return bVictory;
}


