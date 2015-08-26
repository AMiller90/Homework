#pragma once

#include<iostream>
#include<string>

//Problem 14
int main() {


	

	char input[30];
	std::cin.getline(input, 30);
	std::string input2;
	int numOfchars = strlen(input);

	


	for (unsigned int i = 0; i < strlen(input);  i++) {

		if (input[i] == ' ') {

			std::cout << (int)' ';
			//std::cout << input;

		}

	}


	//std::cout << numOfchars << std::endl;
	//std::cout << input << std::endl;

	system("PAUSE");
	return 0;

}