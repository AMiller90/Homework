#pragma once


#include<iostream>

#include<string>


//Creates Different Structs
struct Player
{

	std::string Name;



	int Health;
	int Score;
	//uses Point 2d Variables
	Point2D Position;
	Point2D Velocity;




};




struct Point2D
{
	int x, y;



};


struct Rect2D
{

	//uses Point 2d Variables
	Point2D p1;
	Point2D p2;
	Point2D p3;
	Point2D p4;


	Color value;


};



struct Color
{


	unsigned char Red;
	unsigned char Green;
	unsigned char Blue;

};




/*Problem 2
2. Create an instance of the Player structure and ask the user to input a name and score.
Store the user’s input into the member variables of the structure.Then output the name and
score in the Player structure.*/
int main()
{


	//Creates Instance of Struct
	Player user;


	std::cout << "Please Input Your Name And A Score:" << std::endl;
	std::cin >> user.Name;
	std::cin >> user.Score;


	std::cout << "This Is Your Name " << user.Name << " and Your Score " << user.Score << std::endl;







	system("PAUSE");
	return 0;
}