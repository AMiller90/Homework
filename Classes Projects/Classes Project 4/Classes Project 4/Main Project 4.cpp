#pragma once


#include<iostream>

#include<string>

#include"Zombie.h"


//Problem 4
void startBattle()
{
	Zombie z[5];
	
	z[0] = Zombie("Programmer", 20, 15, true);
	z[1] = Zombie("Construction Worker", 20, 25, true);
	z[2] = Zombie("Babysitter", 10, 30, true);
	z[3] = Zombie("Salesman", 15, 40, true);
	z[4] = Zombie("Bodybuilder", 25, 30, true);

	/*====PSEUDOCODE====
	loop through the array of zombies
	check to see if the job is the same
	if it is not
	then
		attack dude decrement health

		
	
	*/

	
	int numZ = 5;
	do {
		
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				if ((z[i].getAttack() >= z[j].getHealth()) && z[j].getlife() == true)
				{
					z[j].setlife(false);
					numZ--;
				}


				if (z[i].getAttack() < z[j].getHealth())
				{
					z[j].setHealth(z[j].getHealth() - z[i].getAttack());
				}
			}

		}

	} while (numZ > 1);
	
	std::cout << numZ;
}

int main()
{

	
	std::cout << "Let See What Zombie Will Win" << std::endl;

	
	startBattle();
	

	


	

	system("PAUSE");
	return 0;
}