////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Player.h
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Player header file. It will contain the Player Class function prototypes And Variables.
////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Preprocessor Directives - If Not Defined Then Define 
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

	int GetPositionX();
	int GetPositionY();
	void SetPosition(int a_iX, int a_iY);
	void Move();
	void Attack();
	void StartAdventure();
	void ChooseMap();
	void Inventory();

private:

	int m_iX;
	int m_iY;

};

//Ends The Inclusion Of This Class
#endif _PLAYER_H_