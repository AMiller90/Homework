#pragma once


#include<iostream>
#include <string>

int main() {




	//std::string name;
	std::string name1;
	std::string name2;
	std::string name3;
	std::string name4;
	std::string name5;

	std::cout << "Please Into The First And Last Name of 5 People:" << std::endl;
	std::getline(std::cin, name1);
	std::getline(std::cin, name2);
	std::getline(std::cin, name3);
	std::getline(std::cin, name4);
	std::getline(std::cin, name5);

	std::cout << "The First Name Is: " << name1 << std::endl;
	std::cout << "The Second Name Is: " << name2 << std::endl;
    std::cout << "The Third Name Is: " << name3 << std::endl;
	std::cout << "The Fourth Name Is: " << name4 << std::endl;
	std::cout << "The Fifth Name Is: " << name5 << std::endl;



	int x = name1.length();
	int y = name2.length();
	int z = name3.length();
    int a = name4.length();
	int b = name5.length();

	for (int x = name1.length() - 1; x >= 0; x--) {
		
		std::cout << name1[x];

	}

	for (int y = name2.length() - 1; y >= 0; y--) {

	std::cout << name2[y];

	}

	for (int y = name3.length() - 1; z >= 0; z--) {

	std::cout << name3[z];

	}

	for (int y = name4.length() - 1; a >= 0; a--) {

	std::cout << name4[a];

	}

	for (int y = name5.length() - 1; b >= 0; b--) {

	std::cout << name5[b];

	}

	std::cout << std::endl;




	


	system("PAUSE");
	return 0;

}