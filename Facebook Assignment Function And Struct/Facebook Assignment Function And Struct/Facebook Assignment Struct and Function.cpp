#pragma once

#include<iostream>

#include<string>




struct Warrior
{

	std::string name;
	int hp;
	int energy;
	int attack;
	int defense;
	std::string armor;


};



int setupStruct(Warrior warrior1)
{

	std::string name;
	std::cout << "Enter First Warriors Name:\n";
	std::cin >> name;
	

	
	warrior1.name = name;
	warrior1.attack = 30;
	warrior1.defense = 20;
	warrior1.hp = 50;
	warrior1.energy = 20;
	warrior1.armor = "Shield";

	return warrior1.hp;
}

int setupStruct2(Warrior warrior2)
{

	
	std::string name2;
	std::cout << "Enter Second Warriors Name:\n";
	std::cin >> name2;


	warrior2.name = name2;
	warrior2.attack = 30;
	warrior2.defense = 20;
	warrior2.hp = 50;
	warrior2.energy = 20;
	warrior2.armor = "Vest";

	return warrior2.hp;
}

float average(float a, float b)
{
	
	
	float average = (a + b) / 2;

	return average;


}

int main()
{
	Warrior warrior1;
	Warrior warrior2;


	int hp1 = setupStruct(warrior1);
	int hp2 = setupStruct2(warrior2);
	std::cout << average(hp1, hp2) << std::endl;



	system("PAUSE");
	return 0;
}