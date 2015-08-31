#include "Class Project 3.h"


HighScores::HighScores()
{









}


void HighScores::average()
{
	float sum = _HS1 + _HS2 + _HS3;

	float result = sum / 3;

	std::cout << "The Average Of All 3 Numbers is: " << result << std::endl;



}



//Getters
float HighScores::getHS1()
{
	std::cout << "Please Enter The First Score: " << std::endl;
	std::cin >> _HS1;
	return _HS1;


}

float HighScores::getHS2()
{
	std::cout << "Please Enter The Second Score: " << std::endl;
	std::cin >> _HS2;
	return _HS2;

}


float HighScores::getHS3()
{
	std::cout << "Please Enter The Third Score: " << std::endl;
	std::cin >> _HS3;
	return _HS3;

}


//Setters
void HighScores::setHS(float a)
{
	_HS1 = a;

}


void HighScores::setHS2(float b)
{
	_HS1 = b;

}


void HighScores::setHS3(float c)
{
	_HS1 = c;

}
