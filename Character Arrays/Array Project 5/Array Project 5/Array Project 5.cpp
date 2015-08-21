#pragma once


#include<iostream>
#include<string>

int main() {

	std::string username;
	std::string password;

	std::cout << "Please Enter A Username And A Password: " << std::endl;
	std::getline(std::cin, username);

	
		if (username.length() < 8) {

			std::cout << "Username Needs To Be Atleast 8 characters long!";

		}
		
	std::getline(std::cin, password);






	system("PAUSE");
	return 0;

}