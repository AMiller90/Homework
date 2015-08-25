#pragma once
 

#include<iostream>
#include<cstring>
#include<string>
#include<ctype.h>

//Problem 5
int main() {

	char username[30];
	char password[30];
	bool capt = false;
	bool num = false;
	bool symbol = false;


	std::cout << "Please Enter A Username:" << std::endl;
	std::cin.getline(username, 30);

	std::cout << std::endl;

	std::cout << "Please Enter A Password - It Must Be atleast 8 characters long, Contain Atleast 1 Number, 1 Uppercase letter  And 1 Symbol:" << std::endl;
	std::cin.getline(password, 30);
	//how do i get a number when ever the user inputs a string that contains said number
	//for example 

	///*
	////switch(numrange)
	////case numrange >65 + 26 
	//1.check ascii values
	//2.if ascii values do not pass the criteria then give user feedback
	//
	//int asciiLetter = (int)username[i]
	//
	//
	//
	//
	//
	//*/

	//convert password to length of it
	int i = strlen(password);

	//check length
	if (i < 8) {

		bool isdone = true;
		while (isdone = true) {

			std::cout << "Password is not long enough" << std::endl;
			std::cout << "Please Try Again: " << std::endl;
			std::cin >> password;
			int i = strlen(password);
			if (i >= 8)
			{
				break;
			}
		}

	}


	//Loop through and check for a capital letter
	for (int j = 0; j < strlen(password); j++)
	{
		//std::cout << (int)password[i];
		if ((char)password[j] >= 65 && (char)password[j] <= 90 && !capt)
		{
			
			std::cout << "Great! There is atleast one capital letter!\n";
			capt = true;
		}



		//Loop through and check for a number
		if ((char)password[j] >= 48 && (char)password[j] <= 57 && !num)
		{
			
			std::cout << "Great! There is atleast one number!\n";
			num = true;
		}


		//Loop through and check for a symbol
		if (((char)password[j] >= 33 && (char)password[j] <= 47) || 
			((char)password[j] >= 58 && (char)password[j] <= 64) ||
			((char)password[j] >= 91 && (char)password[j] <= 96) ||
			((char)password[j] >= 123 && (char)password[j] <= 126 && !symbol))
		{
			
			std::cout << "Great! There is atleast a symbol!\n";
			symbol = true;
		}

	}
	


	system("PAUSE");
	return 0;

}
