#pragma once

#include <iostream>




int main() {



	//Problem 2.
	std::cout << "Please Enter 2 Numbers: " << std::endl;
	int a;
	int b;
	std::cin >> a;
	std::cin >> b;

	if (a > b) {

	std::cout << "The First Number..." << a << "..Is Bigger" << std::endl;

	}
	else if (a < b) {

	std::cout << "The Second Number..." << b << "..Is Bigger" << std::endl;

	}
	else if (a = b) {

	std::cout << "Both Numbers " << a << " And " << b << " Are Equal"<< std::endl;
	}

	system("PAUSE");
    return 0;
}


