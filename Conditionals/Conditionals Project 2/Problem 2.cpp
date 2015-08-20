#pragma once

#include <iostream>




int main() {



	//Problem 2.
	//Prompt user for 2 numbers
	std::cout << "Please Enter 2 Numbers: " << std::endl;
	int a;
	int b;
	std::cin >> a;
	std::cin >> b;

	
	if (a > b) {
		//check if a is greater than b..if true then perform this statement
	std::cout << "The First Number..." << a << "..Is Bigger" << std::endl;

	}
	else if (a < b) {
		//check if a is less than b..if true then perform this statement
	std::cout << "The Second Number..." << b << "..Is Bigger" << std::endl;

	}
	else if (a = b) {
		//check if a and b are equal..if true then perform this statement
	std::cout << "Both Numbers " << a << " And " << b << " Are Equal"<< std::endl;
	}

	system("PAUSE");
    return 0;
}


