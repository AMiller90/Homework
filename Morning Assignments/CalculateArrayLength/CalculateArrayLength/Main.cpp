#include<iostream>

//09/07/2016
//Write a function that calculates the length of a character array using only pointers. 
//Pass that function as an argument to another function to evaluate it's correctness.

typedef int(*functptr)(const char* c);

//Function that checks another functions return value and a passed in value
bool Evaluate(int functptr, int sizeofarray)
{
	if (functptr == sizeofarray)
	{
		std::cout << "The passed in size is valid!\n";
		return true;
	}
	else
	{
		std::cout << "The passed in size is not valid!\n";
		return false;
	}
}

//Function to calculate the length of an array
int CalculateArrayLength(const char* c)
{
	int counter = 0;

	for (; *c != '\0'; c++)
	{
		counter++;
	}
	/*for (int i = 0; i <= c[i]; i++)
	{
		counter++;
	}*/

	//The reason i add one is because of the null terminator character '\0'
	std::cout << "The array size is: " << counter + 1 << "\n";
	return counter + 1;
};

int main()
{
	char boop[] = { "Hello World"};

	Evaluate(CalculateArrayLength(boop), 12);
	

	int tmp;
	std::cin >> tmp;
	return 0;
}