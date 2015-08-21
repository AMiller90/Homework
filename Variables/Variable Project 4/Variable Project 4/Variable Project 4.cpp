#pragma once

#include<iostream>


int main() {

	//Problem 4
	int a;
	int b;

	std::cout << "Please Enter Any 2 Numbers: " << std::endl;
	std::cin >> a;
	std::cin >> b;

	std::cout << "These Are Your Numbers: " << a << " And " << b << std::endl;

	//variable c is only going to be used to hold a value of another variable temporarily
	int c;
	//c is assigned a's value
	c = a;
	//a is assigned b's value
	a = b;
	//b is assigned c's value that was the orignal a variables value
	b = c;

	std::cout << "These Are Your Numbers in Reverse: " << a << " And " << b << std::endl;

	system("PAUSE");
	return 0;
}