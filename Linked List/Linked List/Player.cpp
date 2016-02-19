#include"Player.h"

Player::Player()
{


}


Player::~Player()
{




}

Player::Player(string Name, unsigned int hp, unsigned int mp, unsigned int atk, unsigned int def, unsigned int spd)
{
	_name = Name;
	_hp = hp;
	_mp = mp;
	_atk = atk;
	_def = def;
	_spd = spd;

}

string Player::getName()
{
	return _name;
}

unsigned int Player::getHp()
{
	return _hp;
}

unsigned int Player::getMp()
{
	return _mp;
}

unsigned int Player::getatk()
{
	return _atk;
}

unsigned int Player::getdef()
{
	return _def;
}

unsigned int Player::getspd()
{
	return _spd;

}

void Player::setHp(unsigned int h)
{
	_hp = h;
}

void Player::setMp(unsigned int m)
{
	_mp = m;
}

void Player::setatk(unsigned int a)
{
	_atk = a;
}

void Player::setdef(unsigned int d)
{
	_def = d;
}

void Player::setspd(unsigned int s)
{
	_spd = s;
}
