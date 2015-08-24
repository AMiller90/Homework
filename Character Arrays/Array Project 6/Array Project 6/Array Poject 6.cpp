#pragma once

#include<string>
#include<iostream>
#include<string>

int main() {



	char name1[6] = { 'h', 'e', 'l', 'l', 'o' };
	char name2[6] = { 'w', 'o', 'r', 'l', 'd' };

	char name3[2][40] = { name1[6] + name2[5] };

	for (int i = 0; name2[i] != '\0'; i++){
		
			//std::cout << name1[i];
			//std::cout << name2[i];
			//std::cout << name3[i];
	}
	/*bool isdone = true;

	while (isdone == true){
		std::cout << "Please Enter A Username: It must contain a sequence of 'usr' " << std::endl;
		std::cout << std::endl;
		std::string username;
		std::getline(std::cin, username);

		int flag = 0;
		for (unsigned int i = 0; i < username.length(); i++) {
			if (username.at(i) == 'u') {
				if (username.at(i + 1) == 's'){
					if (username.at(i + 2) == 'r') {
						flag = 1;
						std::cout << std::endl;
						//std::cout << "Valid Name" << std::endl;
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


		std::cout << "Please Enter This Password: P@55w0rd" << std::endl;
		std::cout << std::endl;
		std::string password;
		std::getline(std::cin, password);

		for (unsigned int i = 0; i < password.length(); i++) {
		if (password.at(i) == 'P') {
		if (password.at(i + 1) == '@'){
		if (password.at(i + 2) == '5') {
		if (password.at(i + 3) == '5') {
		if (password.at(i + 4) == 'w') {
		if (password.at(i + 5) == '0'){
		if (password.at(i + 6) == 'r'){
		if (password.at(i + 7) == 'd'){
			flag = 1;
			std::cout << std::endl;
			//std::cout << "Good Job!" << std::endl;
			//system("PAUSE");
			//return false;
		
		
		       
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

		std::cout << "This Is Your identifier: " << username << '-' << password << std::endl;
		std::cout << std::endl;
		system("PAUSE");
		return false;
}*/
		system("PAUSE");
		return 0;
	
}