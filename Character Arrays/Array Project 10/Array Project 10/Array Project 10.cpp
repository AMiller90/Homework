#pragma once

#include<iostream>
#include<string>

int x;
int y;


int main() {


	char input[80];

	std::cin.getline(input, 80);

	int i;

	//get length of input
	for (i = 0; input[i] != '\0'; i++);

	int a, b;
	int flag = 1;

	//Loops through word in both directions 
	for (a = 0, b = i - 1; a < i / 2; a++, b--) {

		if (input[a] != input[b]) {
			//checks for equality
			
			flag = 0;
			break;
		}

	}
	if (flag == 1)//if equal then this
	std::cout << "It is a palindrome" << std::endl;

	else//if not equal then this
		std::cout << "It is not a palindrome." << std::endl;


	system("PAUSE");
	return 0;

}