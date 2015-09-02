#pragma once

#include<iostream>




class HighScores
{

public:

	HighScores();

	
	//Getters
	float getHS1();
	float getHS2();
	float getHS3();

	//Setters
	void setHS(float a);
	void setHS2(float b);
	void setHS3(float c);

	void average();






private:

	//Private Variables
	float _HS1;
	float _HS2;
	float _HS3;


};