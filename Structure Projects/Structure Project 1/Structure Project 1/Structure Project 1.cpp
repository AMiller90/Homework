#pragma once

#include<iostream>
#include<string>


struct Player 
{

	std::string Name;

	

	int Health;
	int Score;
	Point2D Position;
	Point2D Velocity;




};




struct Point2D
{
	int x, y;



};


struct Rect2D
{


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



//Problem 1
int main()
{










	system("PAUSE");
	return 0;
}