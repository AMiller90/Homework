#include"Zombie.h"

using namespace std;

Zombie::Zombie()
{

}
Zombie::Zombie(string job, int h, int a, bool l)
{
	_occupation = job;
	_health = h;
	_attack = a;
	_life = l;


}


int Zombie::getHealth()
{
	
	return _health;

}



int Zombie::getAttack()
{
	

	return _attack;



}

bool Zombie::getlife()
{


	return _life;

}


void Zombie::setlife(bool l)
{


	_life = l;

}

void Zombie::setAttack(int a)
{

	_attack = a;

	
}
void Zombie::setHealth(int h)
{

	_health = h;

	
}



std::string Zombie::getJob()
{

	return _occupation;
}

void Zombie::setJob(std::string j)
{

	_occupation = j;

}

