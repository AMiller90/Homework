#ifndef PLAYER_H_
#define PLAYER_H_

#include<string>
using namespace std;

class Player
{

public:

	Player();
	~Player();

	Player(string Name, unsigned int hp, unsigned int mp, unsigned int atk, unsigned int def, unsigned int spd);
	
    string getName();
	unsigned int getHp();
	unsigned int getMp();
	unsigned int getatk();
	unsigned int getdef();
	unsigned int getspd();

	void setHp(unsigned int h);
	void setMp(unsigned int m);
	void setatk(unsigned int a);
	void setdef(unsigned int d);
	void setspd(unsigned int s);

private:

	string _name;
	unsigned int _hp;
	unsigned int _mp;
	unsigned int _atk;
	unsigned int _def;
	unsigned int _spd;
};



#endif