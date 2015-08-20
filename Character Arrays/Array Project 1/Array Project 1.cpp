#pragma once

#include <iostream>
#include <string>

int main() {
	//Variable for The First And Last Name
	std::string name;
	//Prompts user to first or last name
	std::cout << "Please Into Your First And Last Name:" << std::endl;
	//This getline function Take In A String From User Ans Stores It In The name Variable
	std::getline(std::cin, name);
	//This Prints The First And Last Name Stored In The name Variable To The Screen
	std::cout << "Your Name Is: " << name << std::endl;






	system("PAUSE");
	return 0;
}