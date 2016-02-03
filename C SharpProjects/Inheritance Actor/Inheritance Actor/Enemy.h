#ifndef _ENEMY_H_
#define _ENEMY_H_

#include "Actor.h"

class Enemy : public Actor
{
public:
	Enemy();
	~Enemy();

	void AI();

protected:


private:

	int LootTable[5];

};



#endif