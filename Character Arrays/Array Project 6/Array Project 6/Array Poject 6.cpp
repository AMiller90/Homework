#pragma once

#include<string>
#include<iostream>


int main() {



	char name[20] = { };
	char password[20] = { };

	char identifier[40] = {};


	bool isdone = true;

	while (isdone == true){
		std::cout << "Please Enter A Username: It must contain a sequence of 'usr' " << std::endl;
		std::cout << std::endl;
		std::cin >> name;

		int flag = 0;
		for (unsigned int i = 0; i < strlen(name); i++) {
			if (name[i] == 'u') {
				if (name[i + 1] == 's'){
					if (name[i + 2] == 'r') {
						flag = 1;
						std::cout << std::endl;
						break;
					}

				}
			}

		}
		if (flag == 0){

			std::cout << "That is Not valid" << std::endl;
			system("PAUSE");
			return false;
		}

		flag = 0;
		std::cout << "Please Enter This Password: P@55w0rd" << std::endl;
		std::cout << std::endl;
		std::cin >> password;

		for (unsigned int i = 0; i < strlen(password); i++) {
		if (password[i] == 'P') {
		if (password[i + 1] == '@'){
		if (password[i + 2] == '5') {
		if (password[i + 3] == '5') {
		if (password[i + 4] == 'w') {
		if (password[i + 5] == '0'){
		if (password[i + 6] == 'r'){
		if (password[i + 7] == 'd'){
			flag = 1;
			std::cout << std::endl;
			break;
		}
		      }
		     }
		    }
		   }
		  }
		}
	  }
		}if (flag == 0){

			std::cout << "This is Not valid" << std::endl;
			system("PAUSE");
			return false;
		}

		strcat_s(identifier, name);
		strcat_s(identifier, "-");
		strcat_s(identifier, password);
		
		std::cout << "Your identifier is: ";
		for (int i = 0; i < strlen(identifier); i++)
		{
			std::cout << identifier[i];
		}
		std::cout << std::endl;

		system("PAUSE");
		return false;
}

		system("PAUSE");
		return 0;
	
}