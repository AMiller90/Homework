#pragma once

#include<iostream>




int main() {
	//Problem 7

	//Sets Up Variables
	int Month;
	int Days;

	//Propmts user to enter a number between 1 - 12 to find out how many days are in that month
	std::cout << "Please Enter The Month from 1 - 12 To See The Number Of Days In That Month: " << std::endl;

	//Gets user input
	std::cin >> Month;

	//Uses the month variable to refer to get the number of days
	switch (Month) {

	case 1:

	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;

	case 2:
	std::cout << "Month " << Month << " Has 28 Days" << std::endl;
	break;

	case 3:
	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;

	case 4:
	std::cout << "Month " << Month << " Has 30 Days" << std::endl;
	break;


	case 5:
	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;


	case 6:
	std::cout << "Month " << Month << " Has 30 Days" << std::endl;
	break;

	case 7:
	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;

	case 8:
	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;

	case 9:
	std::cout << "Month " << Month << " Has 30 Days" << std::endl;
	break;

	case 10:
	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;

	case 11:
	std::cout << "Month " << Month << " Has 30 Days" << std::endl;
	break;


	case 12:
	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;

	default:
	std::cout << "ERROR: Invalid Input" << std::endl;
	break;
	}

	system("PAUSE");
    return 0;
}