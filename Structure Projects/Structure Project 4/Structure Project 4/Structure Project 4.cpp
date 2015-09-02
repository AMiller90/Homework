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

//Declare Function and Define
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



/*Problem 4
Create an array of 5 Player structures.Loop through each Player and ask the user to
input the Player’s name and score and store them in each of the 5 Player structures.Do
this step using the function you wrote in question 3. Then loop through the 5 players and
output each of their names and scores*/
int main()
{

	

	//Call Function
	PlayerData();


	

	system("PAUSE");
	return 0;
}