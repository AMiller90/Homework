#pragma once

#include<iostream>
#include<string>

//Problem 14
int main() {




	char input[50];
	char copy[50];
	std::cin.getline(input, 30);





	for (unsigned int i = 0; i < strlen(input);  i++) {

		if (input[i] != ' ') {
			copy[i] = input[i];
			std::cout << copy[i];
		

		}

	}


		std::cout << std::endl;


		system("PAUSE");
		return 0;

	}
