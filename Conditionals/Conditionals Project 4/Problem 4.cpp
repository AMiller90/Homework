#pragma once

#include <iostream>



//Problem 4 
int main() {

	int choice;
	//Prompt user to input a number between 1 - 4
	std::cout << "Please Enter a Number Between 1 - 4: " << std::endl;
	std::cin >> choice;

	//Put The variable storing the users input into switch statement
	switch (choice) {
	//Perform this statement if variable is equal to 1
	case 1:
		std::cout << "1" << std::endl;
		break;

	//Perform this statement if variable is equal to 2
	case 2:
		std::cout << "2" << std::endl;
		break;

	//Perform this statement if variable is equal to 3
	case 3:
		std::cout << "3" << std::endl;
		break;

	//Perform this statement if variable is equal to 4
	case 4:
		std::cout << "4" << std::endl;
		break;

	//Perform this statement if variable is not equal to a number between 1 - 4
	default:
		std::cout << "Invalid" << std::endl;

		
	}

	system("PAUSE");
	return 0;

}
