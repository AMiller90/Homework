//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//File: Player.cpp
//Author: Andrew Miller
//Date Created: 09/27/2015
//Brief: This is the Player cpp file. It will contain all the Player Class function definitions and variable definitions.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


#include "Player.h"


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


}

void Player::Attack()
{


}