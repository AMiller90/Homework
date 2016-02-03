#ifndef _PLAYER_H_
#define _PLAYER_H_

#include "Actor.h"


class Player : public Actor
{
public:

	Player();
	~Player();

	void Input();
	void Move();

protected:

private:
	int inventory[5];

};


#endif