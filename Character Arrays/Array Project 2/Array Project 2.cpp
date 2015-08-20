#pragma once

#include <iostream>
#include <string>

int main() {

	//std::string name;
	std::string name;
	
	//Prompts user to enter first and last name
	std::cout << "Please Into Your First And Last Name:" << std::endl;
	//getline is a function that gets the string that the user iputted into the name variable
	std::getline(std::cin, name);

	


	//the length() function counts the number of characters stored in a variable and returns it..i stored the returning value into x
	int x = name.length();
	
	//Informing user of the result of the name being backwards
	std::cout << "Your name backwards is: " << std::endl;

	//looping through the lngth of the name and iterating from the length of the name down to 0
	for (int x = name.length() - 1; x >= 0; x--) {

		//Prints result
		std::cout << name[x];
	}
	
	std::cout << std::endl;
	

	system("PAUSE");
	return 0;
}