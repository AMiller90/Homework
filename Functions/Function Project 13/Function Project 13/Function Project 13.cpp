#pragma once

#include<iostream>


int search(int array[], int size, int number)
{

	for (int i = 0; i < size; i++)
	{
		//if the current index is equal to the number to be found then return the index it is found at.
		if (array[i] == number)
		{

			int result = i;
			return  i;
		}
		
		



	}
	//if number is not found then return -1
	return -1;
}

//Problem 13
int main() {

	int array[5] = { 1, 2, 3, 4, 5 };
	int size = 5;
	int number = 7;


	int result = search(array, 5, 5);

	std::cout << result << std::endl;

	system("PAUSE");
	return 0;
}