#pragma once


#include<iostream>
#include <string>

int main() {

	//Problem 3


	//std::string name;
	std::string name1;
	std::string name2;
	std::string name3;
	std::string name4;
	std::string name5;

	//Prompts user to print 5 first and last names
	std::cout << "Please print The First And Last Name of 5 People:" << std::endl;
	//getline stores the strings in the name variables
	std::getline(std::cin, name1);
	std::getline(std::cin, name2);
	std::getline(std::cin, name3);
	std::getline(std::cin, name4);
	std::getline(std::cin, name5);

	//Prints out the first and last names the user put in
	std::cout << "The First Name Is: " << name1 << std::endl;
	std::cout << "The Second Name Is: " << name2 << std::endl;
    std::cout << "The Third Name Is: " << name3 << std::endl;
	std::cout << "The Fourth Name Is: " << name4 << std::endl;
	std::cout << "The Fifth Name Is: " << name5 << std::endl;

	//the length() function reads through the name variable and gets the number of characters and i store the value in integer variables
	int x = name1.length();
	int y = name2.length();
	int z = name3.length();
    int a = name4.length();
	int b = name5.length();
	std::cout << std::endl;

	//Loops through variable name1s length and decrements the value by i each time it loops through
	for (int x = name1.length() - 1; x >= 0; x--) {
		//Prints the Result of This for loop
	std::cout << name1[x];

	}
	//Loops through variable name2s length and decrements the value by i each time it loops through
	for (int y = name2.length() - 1; y >= 0; y--) {
		//Prints the Result of This for loop
	std::cout << name2[y];

	}
	//Loops through variable name3s length and decrements the value by i each time it loops through
	for (int y = name3.length() - 1; z >= 0; z--) {
		//Prints the Result of This for loop
	std::cout << name3[z];

	}
	//Loops through variable name4s length and decrements the value by i each time it loops through
	for (int y = name4.length() - 1; a >= 0; a--) {
		//Prints the Result of This for loop
	std::cout << name4[a];

	}
	//Loops through variable name5s length and decrements the value by i each time it loops through
	for (int y = name5.length() - 1; b >= 0; b--) {
		//Prints the Result of This for loop
	std::cout << name5[b];

	}

	std::cout << std::endl;



	system("PAUSE");
	return 0;

}