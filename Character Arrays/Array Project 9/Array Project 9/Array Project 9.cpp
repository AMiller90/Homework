#pragma once

#include<iostream>
#include<string>


//Problem 9
int main() {

	std::string input;

	std::getline(std::cin, input);
	
	
	int numOfwords = 1;
	int numOfchars = 0;

	//Keep looping through input until you get to the null character and then stop
	for (int i = 0; input[i] != '\0'; i++) {
	 //if the input[i] is equal to a ' ' charachter then add one to num of words
		if (input[i] == ' ') {

			numOfwords++;

		}


	}
	std::cout << "There Are " << numOfwords << " Words!" << std::endl;
	std::cout << "There Are " << input.length() << " Characters!" << std::endl;

	system("PAUSE");
	return 0;
}