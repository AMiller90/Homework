#pragma once


#include<string>


#include<iostream>





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

	//std::cout << "This Is Your Name " << user.Name << " and Your Score " << user.Score << std::endl;

	
	return user;


}

//Problem 3
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
	 std::cout << user.Score;
	
	
	















	system("PAUSE");
	return 0;
}