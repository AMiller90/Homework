#pragma once


#include<string>


#include<iostream>




//Creates Structs
struct Player
{

	std::string Name;

	int Health;
	int Score;
	int Position;
	int Velocity;




};


struct Rect2D
{

	float x, y;



	float point1;
	float point2;
	float point3;
	float point4;


	unsigned char Red;
	unsigned char Green;
	unsigned char Blue;





};




Player PlayerData(std::string Name, int Score)
{
	Player user;
	

	user.Name = Name;
	user.Score = Score;

	
	
	return user;


}

/*Problem 3
Pull the code you wrote for question 2 out into a function that creates and then returns the
player the user created.*/

int main()
{

	Player user;

	std::string Name;
	int Score;

	std::cout << "Please Input Your Name And A Score:" << std::endl;
	std::cin >> Name;
	std::cin >> Score;

   

	 user = PlayerData(Name,Score);

	 std::cout << user.Name;
	 std::cout << std::endl;
	 std::cout << user.Score;
	 std::cout << std::endl;
	
	
	















	system("PAUSE");
	return 0;
}