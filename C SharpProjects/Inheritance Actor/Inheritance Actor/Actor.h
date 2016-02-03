#ifndef _ACTOR_H_
#define _ACTOR_H_

#include<string>
#include<iostream>

using namespace std;

template<typename T>
struct Vector3
{
public:
	T X, Y, Z;

};


class Actor
{

public:

	void Update();
	virtual void Move();
	void Attack();

protected:
	Vector3<float> Pos;
	int Health;
	int Damage;
	string Name;

private:


};

#endif