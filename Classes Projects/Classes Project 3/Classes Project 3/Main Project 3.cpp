#pragma once

#include<iostream>

#include "Class Project 3.h"

int main()
{

	HighScores Scores;

	float a = Scores.getHS1();
	float b = Scores.getHS2();
	float c = Scores.getHS3();

	Scores.setHS(a);
	Scores.setHS2(b);
	Scores.setHS3(c);



	Scores.average();









	system("PAUSE");
	return 0;
}