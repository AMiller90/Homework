#pragma once


#include<iostream>
#include<cstring>
#include<string>
#include<ctype.h>

//Problem 5
int main() {

	char password[20];
	char username[20];

	std::cout << "Please Enter A Username:" << std::endl;
    std::cin >> username;

	std::cout << std::endl;

	std::cout << "Please Enter A Password - It Must Be atleast 8 characters long, Contain Atleast 1 Number, 1 Uppercase letter  And 1 Symbol:" << std::endl;
	std::cin >> password;


	int i = strlen(password);


	if (i < 8) {
		
		bool isdone = true;
		while (isdone = true) {

		std::cout << "Password is not long enough" << std::endl;
			std::cout << "Please Try Again: " << std::endl;
			std::cin >> password;
			int i = strlen(password);
			if (i >= 8) {
				break;
			}
		}
	}
	
	/*for (int i = 0; i < password[i]; i++) {
			if (password[i] != isupper(i)) {
				std::cout << password[i];
			}
			
			

		}*/

	std::cout << "Good!";
	system("PAUSE");
	return 0;

}