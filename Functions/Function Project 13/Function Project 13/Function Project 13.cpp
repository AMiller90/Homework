#pragma once


#include<iostream>


int search(int array_[], int size, int number)  {

	for (int i = 0; i < size; i++) {

		std::cout << array_[i] << " " << std::endl;

	}

	return 0;
}

int main() {
	

	int array[4] = { 10, 11, 2, 6 };
	int number = 5;
	
	search(array, 4, 5);





	system("PAUSE");
	return 0;



}