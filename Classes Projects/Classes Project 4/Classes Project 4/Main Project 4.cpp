#pragma once


#include<iostream>

#include<string>

//includes the header file in order for this .cpp file to know what class this data belongs too

#include"Zombie.h"



//Simulates Battle
void startBattle()
{
	Zombie z[5];
	
	z[0] = Zombie("Programmer", 20, 15, true);
	z[1] = Zombie("Construction Worker", 20, 25, true);
	z[2] = Zombie("Babysitter", 10, 30, true);
	z[3] = Zombie("Salesman", 15, 40, true);
	z[4] = Zombie("Bodybuilder", 25, 30, true);


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


/* Problem 4
Create a class representing a zombie.Each zombie should have a health and attack value,
and a previous occupation.Ensure that the zombie’s variables are private and there are
functions to access and modify the zombie’s data.
a.Using the zombie class, create a game in which a small number of zombies attack
each other until only one remains!*/

int main()
{

	
	std::cout << "Let See How Many Zombies Will Be Left\n" << std::endl;

	//Calls Function
	startBattle();

	std::cout << std::endl;
	

	


	

	system("PAUSE");
	return 0;
}