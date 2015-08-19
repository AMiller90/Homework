#pragma once

#include <iostream>
#include <string>

int main() {

	//std::string name;
	std::string name;
	
	std::cout << "Please Into Your First And Last Name:" << std::endl;
	std::getline(std::cin, name);

	std::cout << "Your Name Is: " << name << std::endl;



	int x = name.length();

	for (int x = name.length() - 1; x >= 0; x--) {

		std::cout << name[x];
	}

	std::cout << std::endl;


	system("PAUSE");
	return 0;
}