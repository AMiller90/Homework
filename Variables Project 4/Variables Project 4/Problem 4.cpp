#pragma once

#include <iostream>



//Problem 4 
int main() {

	int choice;

	std::cout << "Please Enter a Number Between 1 - 4: " << std::endl;
	std::cin >> choice;

	switch (choice) {

	case 1:
		std::cout << "1" << std::endl;
		break;

	case 2:
		std::cout << "2" << std::endl;
		break;

	case 3:
		std::cout << "3" << std::endl;
		break;

	case 4:
		std::cout << "4" << std::endl;
		break;

	default:
		std::cout << "Invalid" << std::endl;

		
	}

	system("PAUSE");
	return 0;

}
