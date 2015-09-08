/////////////////////////////////////////////////////////////////////////////////////////
//File: Player.h
//Author: Andrew Miller
//Date Created: 09/03/2015
//Brief: This is the Player header file. It will contain the players function protypes 
/////////////////////////////////////////////////////////////////////////////////////////

#ifndef _PLAYER_H_
#define _PLAYER_H_

#include<iostream>
#include<string>


using namespace std;



class Player 
{


public:

	

	Player();
	~Player();
	

	void PrintGameData();


	void GetPosition(int i_iX, int i_iY);
	void SetPosition(int i_iX, int i_iY);
	void Actions(Player &Player);
	void AdventureStart();
	void Inventory(Player &Player);
	void UseArrow();
	void UseRemote();
	void FoundGold(Player &Player);
	void Pits(Player &Player);
	void AttackWumpus(Player &Player);
	void Wumpus(Player &Player);
	void Victory(Player&Player);


private:

	int m_iX;
	int m_iY;
	





};












#endif _PLAYER_H_