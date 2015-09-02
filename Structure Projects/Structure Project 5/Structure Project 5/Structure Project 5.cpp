#pragma once


#include<iostream>
#include<string>

//Create Struct
struct Player
{

	std::string Name;

	int Health;
	int Score;
	int Position;
	int Velocity;




};

//Create and define function
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


/*Problem 5
After completing Question 4, now prompt the user to enter in a name.Loop through the 5
Players and find the player with that name.If there is a match, output that player’s score,
otherwise report this back to the user that a match could not be found.*/
int main()
{


	//Call function
	PlayerData();

	










	system("PAUSE");
	return 0;
}