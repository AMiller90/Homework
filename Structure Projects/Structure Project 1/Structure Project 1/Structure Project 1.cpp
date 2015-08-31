#pragma once

#include<iostream>


#include<string>


struct Player 
{

	std::string Name;

	

	int Health;
	int Score;
	float Position;
	float Velocity;




};

//Player user = {"Andrew", 100, 0, {0.0f, 0.0f}, {1.0f, 1.0f}};

struct Position
{

	float x, y;





};


struct Velocity
{

	float x, y;



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
//point1, point2, point3, point4, r, g, b
//Rect Rectangle = {{0.0f, 0.0f} , {1.0f, 0.0f}, {0.0f, 0.1}, {1.0f, 1.0f}, 255, 255, 255}


//Problem 1
int main()
{


















	system("PAUSE");
	return 0;
}