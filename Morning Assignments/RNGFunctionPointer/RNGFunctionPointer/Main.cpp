//09/06/16
//Write a function that takes a function as a parameter.The function it receives should take two arguments(min, max).
//Calculate a random number between those two numbers and return it.If the function fails return or assert on the call. 
//If the function that takes the min, max function fails give feedback to the user.

#include<iostream>
#include<random>
#include<stdlib.h>
#include <time.h>
#include<assert.h>

typedef int (*funcptr)(const int &min, const int &max);

//Determines whether number is valid or not
int CalculateRNG(int funcptr)
{
	if (funcptr == 0)
	{
		std::cout << "The numbers are the same! No numbers in between.\n";
		return false;
	}		
	else
		return funcptr;
}

//Calculate a random number between passed in values
int RNGFunction(const int &min, const int &max)
{

	int number;
	//If numbers are equal return 0
	if (min == max)
	{
		return 0;
	}
	else
	{
		//Randomize based on internal clock time
		srand(time(NULL));

		//Formula to produce random numbers between the range
		int difference = max - min;
		number = min + rand() % difference;
		//Return the number
		return number;
	}
}

int main()
{
	//Return the number
	int num = CalculateRNG(RNGFunction(1,10));

	std::cout << num;

	int tmp;
	std::cin >> tmp;

	return 0;
}