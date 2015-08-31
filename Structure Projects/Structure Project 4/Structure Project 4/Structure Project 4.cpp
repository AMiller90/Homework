#pragma once

#include<iostream>
#include<string>

struct Player
{

	std::string Name;

	int Health;
	int Score;
	int Position;
	int Velocity;




};


void PlayerData()
{

	Player User[5];

	std::string Name;
	int Score;

	for (int i = 0; i < 5; i++)
	{
		std::cout << "Please Input A Name And Score: " << std::endl;
		std::cin >> User[i].Name;
		std::cin >> User[i].Score;

		Name = User[i].Name;
		Score = User[i].Score;
	}


	for (int i = 0; i < 5; i++)
	{

		std::cout << User[i].Name << std::endl;
		std::cout << User[i].Score << std::endl;


	}


}



//Problem 4
int main()
{

	


	PlayerData();


	

	system("PAUSE");
	return 0;
}