#pragma once

#include<iostream>

//declare function
float sfloat(float a, float b) {

	if (a < b) {
		float result = a;
		return result;
	}
	else if (b < a) {

		float result = b;
		return result;
	}
	else {
		return 0;
	}
	
}
//Problem 2
int main() {

	float a, b;
	
	std::cout << "Enter Value 1: " << std::endl;
	std::cin >> a;

	std::cout << "Enter Value 2: " << std::endl;
	std::cin >> b;
	//store the return result from the function we called
	float result = sfloat(a, b);

	std::cout << result;

	system("PAUSE");
	return 0;
}

