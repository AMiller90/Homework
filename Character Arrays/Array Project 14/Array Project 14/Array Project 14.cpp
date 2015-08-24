#pragma once

#include<iostream>
#include<string>

//Problem 14
int main() {

	std::string input;
	std::getline(std::cin, input);
	std::string input2;
	int numOfchars = input.length();

	for (unsigned int i = 0; i < input.length(); i++) {

		if (input[i] == ' ') {

			//std::cout << input;

		}

	}


	std::cout << numOfchars << std::endl;
	std::cout << input << std::endl;

	system("PAUSE");
	return 0;

}