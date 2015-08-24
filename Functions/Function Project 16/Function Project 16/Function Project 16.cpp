#pragma once

#include<iostream>

void lookAndsay(int array[], int size) {

	int a;
	//int b;

	for (int i = 0; i < size; i++) {

		std::cout << array[i] << " ";
		
	}

	//std::cout << std::endl;

	//std::cout << a << "," << b << std::endl;

}


int main() {


	int array[4] = { 1, 1, 2, 1 };

	lookAndsay(array, 4);



	system("PAUSE");
	return 0;

}