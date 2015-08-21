#pragma once

#include<iostream>


int main() {

	//Problem 6
	std::cout << "Please Enter 5 Whole Numbers: " << std::endl;

	//Variables
	int a;
	int b;
	int c;
	int d;
	int e;

	//Get input And store in Variables
	std::cin >> a;
	std::cin >> b;
	std::cin >> c;
	std::cin >> d;
	std::cin >> e;

	//Add All Input Numbers Together
	int sum = a + b + c + d + e;
	
	//Get Average of all input numbers by taking the sum and dividing it by number of inputs.
	int avg = sum / 5;

	std::cout << std::endl;
	
	//Output The Answer
	std::cout << "This Is The Average Number Of Your Input: " << avg << std::endl;




	system("PAUSE");
	return 0;

}