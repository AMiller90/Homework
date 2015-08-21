#pragma once

#include<iostream>


float Half(float number) {

	float result = number / 2;


	return result;
}

//Problem 4
int main() {

	float number = 16.721f;

	float result = Half(number);

	std::cout << result << std::endl;

	system("PAUSE");
	return 0;
}