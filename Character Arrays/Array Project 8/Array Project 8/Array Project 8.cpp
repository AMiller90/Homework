#pragma once


#include<iostream>
#include<string>



//Problem 8
int main() {






	std::string name;
	std::cin >> name;

	//check if consanant
	if ((((((char)name[0] != 65 && (char)name[0] != 97) &&
		(char)name[0] != 69 && (char)name[0] != 101) &&
		(char)name[0] != 73 && (char)name[0] != 105) &&
		(char)name[0] != 79 && (char)name[0] != 111) &&
		(char)name[0] != 85 && (char)name[0] != 117)
	{

		if (name.length() <= 4)
		{
			//std::string str2 = name.substr(0,1);
			std::string str2 = name.substr(0, 1);
			std::string str;
			str.append("ay");
			name[0] = (char)32;
			std::cout << name << str2 << str << std::endl;
			

		}
		else {
			//std::string str2 = name.substr(0,1);
			std::string str2 = name.substr(0, 2);
			name.erase(0, 1);
			//name.erase(0, 1);
			std::string str;
			str.append("ay");
			name[0] = (char)32;
			std::cout << name << str2 << str << std::endl;

		}
	}
	//check if vowel
		if ((((((char)name[0] == 65 || (char)name[0] == 97) ||
			(char)name[0] == 69 || (char)name[0] == 101) ||
			(char)name[0] == 73 || (char)name[0] == 105) ||
			(char)name[0] == 79 || (char)name[0] == 111) ||
			(char)name[0] == 85 || (char)name[0] == 117)
		{


			name.append("yay");
			std::cout << name << std::endl;
		}

		//std::cout << word << std::endl;



		system("PAUSE");
		return 0;
	}
