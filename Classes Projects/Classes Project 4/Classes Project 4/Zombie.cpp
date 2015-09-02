//includes the header file in order for this .cpp file to know what class this data belongs too

#include"Zombie.h"

using namespace std;

Zombie::Zombie()
{

}

//Initializes Zombie in constructor
Zombie::Zombie(string job, int h, int a, bool l)
{
	_occupation = job;
	_health = h;
	_attack = a;
	_life = l;


}

//Getters
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

std::string Zombie::getJob()
{

	return _occupation;
}



//Setters
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


void Zombie::setJob(std::string j)
{

	_occupation = j;

}

