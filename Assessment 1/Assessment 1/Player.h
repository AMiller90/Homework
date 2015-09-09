/////////////////////////////////////////////////////////////////////////////////////////
//File: Player.h
//Author: Andrew Miller
//Date Created: 09/03/2015
//Brief: This is the Player header file. It will contain the players function prototypes 
/////////////////////////////////////////////////////////////////////////////////////////

#ifndef _PLAYER_H_
#define _PLAYER_H_

#include<iostream>
#include<string>

#include"Game.h"

using namespace std;



class Player 
{


public:

	

	Player();
	~Player();
	

	

	void PrintGameData();
	int GetPositionX();
	int GetPositionY();
	void SetPosition(int a_iX, int a_iY);
	void Actions();
	void Inventory();
	void Pits();
	void UseArrow();
	void UseRemote();
	void FoundGold();
	void Victory();
	void AttackWumpus();
	void Wumpus();
	
	


private:

	
	int m_iX;
	int m_iY;
	



};












#endif _PLAYER_H_