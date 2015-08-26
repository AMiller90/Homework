//#pragma once
//
//#include<iostream>
//#include<string>
//
//
//
//
//
//void printName() 
//{
//
//	std::cout << "What Is Your First Name" << std::endl;
//	char firstName[30];
//	std::cin >> firstName;
//
//	std::cout << firstName;
//	std::cout << std::endl;
//	
//}
//
//
//void printLastName() {
//
//	std::cout << "What Is Your Last Name" << std::endl;
//	char lastName[30];
//	std::cin >> lastName;
//	std::cout << lastName;
//	std::cout << std::endl;
//
//
//}
//
//int numOfCharInName() 
//{
//	char name[20];
//	std::cin.getline(name, 20);
//
//	for (int i = 0; i < name[i]; i++) {
//		strlen(name);
//	}
//
//	return strlen(name);
//
//
//}
//
//char lastCharOfInput()
//{
//	char a;
//	char name[7];
//	std::cin >> name;
//
//	for (int i = 0; i < name[i]; i++)
//	{
//		a = name[5];
//
//	}
//
//	
//	return a;
//	
//}
//
//bool TrueorFalse() 
//{
//	char firstName[30];
//	char lastName[30];
//
//	
//	std::cout << "Enter First Name:" << std::endl;
//	std::cin >> firstName;
//
//	std::cout << std::endl;
//
//	std::cout << "Enter Last Name:" << std::endl;
//	std::cin >> lastName;
//
//
//	if (strlen(firstName) == strlen(lastName))
//	{
//		std::cout << "The Lengths Are The Same";
//		std::cout << std::endl;
//		return true;
//	}
//	if (strlen(firstName) != strlen(lastName))
//	{
//		std::cout << "The Lengths Are The Not The Same";
//		std::cout << std::endl;
//		return false;
//	}
//
//	
//}
//
//int main() {
//
//
//	printName();
//
//	std::cout << std::endl;
//
//	printLastName();
//
//
//    std::cout << TrueorFalse();
//	 
//
//	std::cout << numOfCharInName();
//	
//
//	std::cout << lastCharOfInput();
//	
//
//	system("PAUSE");
//	return 0;
//}