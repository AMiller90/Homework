#pragma once

#include<iostream>


int main() {

	bool isPlaying = true;

	while (isPlaying) {
		//Using a for loop to iterate backward, print the values 100 to 0.
		//Modify the for loop to include 0 and include 100

		for (int i = 100; i >= 0; i--) {

			std::cout << i << " ";

		}

		std::cout << std::endl;
		std::cout << std::endl;
		std::cout << std::endl;

		//Modify the for loop to include 0 and not 100
		for (int i = 100 - 1; i >= 0; i--) {

			std::cout << i << " ";

		}

		std::cout << std::endl;
		std::cout << std::endl;
		std::cout << std::endl;

		//Modify the for loop to not include 0 and include 100
		for (int i = 100; i > 0; i--) {

			std::cout << i << " ";

		}

		std::cout << std::endl;
		std::cout << std::endl;
		std::cout << std::endl;

		//Modify the for loop to decrement by 2
		for (int i = 100; i >= 0; i--) {

			std::cout << i-- << " ";

		}

		break;
	}
	system("PAUSE");
	return 0;

}