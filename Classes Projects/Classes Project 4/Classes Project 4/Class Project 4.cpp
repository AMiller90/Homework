#include"Class Project 4.h"

#include<ctime>
#include<random>

Zombie::Zombie()
{



}


int Zombie::getHealth()
{
	_health = 30;
	return _health;

}



int Zombie::getAttack(int a)
{
	_attack = a;

	return _attack;



}



void Zombie::setAttack(int a)
{

	_attack = a;

	
}
void Zombie::setHealth(int h)
{

	_health = h;

	
}

std::string Zombie::Job(std::string job)
{
	_occupation = job;

	return _occupation;
}

void Zombie::Battle()
{

	Zombie zombie[5];

	int a = zombie[0].getAttack(25);
	int f = zombie[0].getHealth();
	zombie[0].setAttack(a);
	zombie[0].setHealth(f);
	zombie[0].Job("Programmer");

	int b = zombie[1].getAttack(10);
	int g = zombie[1].getHealth();
	zombie[1].setAttack(30);
	zombie[1].setHealth(g);
	zombie[1].Job("Construction Worker");

	int c = zombie[2].getAttack(7);
	int h = zombie[2].getHealth();
	zombie[2].setAttack(c);
	zombie[2].setHealth(h);
	zombie[2].Job("Babysitter");

	int d = zombie[3].getAttack(15);
	int i = zombie[3].getHealth();
	zombie[3].setAttack(d);
	zombie[3].setHealth(i);
	zombie[3].Job("Salesman");

	int e = zombie[4].getAttack(35);
	int j = zombie[4].getHealth();
	zombie[4].setAttack(e);
	zombie[4].setHealth(j);
	zombie[4].Job("Bodybuilder");

	
	


		if ((((a > g) && (a > h) && (a > i) && (a > j))))
		{
			std::cout << "Zombie 1 The " << zombie[0].Job("Programmer") << " Is The Winner!" << std::endl;
			
		}


		if ((((b > h) && (b > i) && (b > j) && (b > f))))
		{
			std::cout << "Zombie 2 The " << zombie[1].Job("Construction Worker") << " Is The Winner!" << std::endl;
			
		}
	

		if ((((c > i) && (c > j) && (c > f) && (c > g))))
		{
			std::cout << "Zombie 3 The " << zombie[2].Job("Babysitter") << " Is The Winner!" << std::endl;

		}


		if ((((d > j) && (d > f) && (d > g) && (d > h))))
		{
			std::cout << "Zombie 4 The " << zombie[3].Job("Salesman") << " Is The Winner!" << std::endl;

		}


		if ((((e > f) && (e > g) && (e > h) && (e > i))))
		{
			std::cout << "Zombie 5 The " << zombie[4].Job("Bodybuilder") << " Is The Winner!" << std::endl;

		}

}