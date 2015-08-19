#pragma once

#include <iostream>
#include <string>

int main() {

	std::string name;

	std::cout << "Please Into Your First And Last Name:" << std::endl;
	std::getline(std::cin, name);

	std::cout << "Your Name Is: " <<  name << std::endl;






	system("PAUSE");
	return 0;
}