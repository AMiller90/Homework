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







/*Problem 1
 Create the following structures :
a.A Player with the following attributes : Name, Health, Score, Position and Velocity
b.A rectangle in 2D space with the following attributes : 4 points(each with X, Y
	positions) and its colour(RGB value).*/
int main()
{










	system("PAUSE");
	return 0;
}