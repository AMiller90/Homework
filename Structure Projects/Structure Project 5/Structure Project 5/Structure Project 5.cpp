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


	std::cout << std::endl;

	for (int i = 0; i < 5; i++)
	{

		std::cout << User[i].Name << std::endl;
		std::cout << User[i].Score << std::endl;


	}

	std::cout << std::endl;

	std::cout << "Please Enter A Name" << std::endl;
	std::string input;
	std::cin >> input;

	bool flag = false;

	for (int i = 0; i < 5; i++)
	{

		User[i].Name;
		User[i].Score;

		if (input == User[i].Name)
		{
			std::cout << User[i].Score << "\n";
			flag = true;
		}
	}

	if (flag == false)
	{
		std::cout << "Match Could Not Be Found\n";
	}

	


}


//Problem 5
int main()
{



	PlayerData();

	










	system("PAUSE");
	return 0;
}