#pragma once

#include<iostream>
//Library so I can use the floor function
#include<math.h>

int main() {

	//Problem 7
	char a;
	char b;

	std::cout << "Please Input 2 Letters In The Alphabet:" << std::endl;
	std::cin >> a;
	std::cin >> b;

	//converts The variables a and b to floating point numbers using (float)
	float floatA = (float)a;
	float floatB = (float)b;

	//difference will be subtracting the 2 inputed characters variables float values. 
	float difference = b - a;
	//divide will be the difference divided by 2. 
	//Dividing by 2 because we are trying to find the letter that is between 2 letters and that is equal to half the distance between the variables.
	float divide = difference / 2;

	//Give c the value of b - divide
	float c = b - divide;
	//Print to screen the char representing the float number stored in variable c. floor means to round down.
	std::cout << (char)floor(c) << std::endl;


	




	system("PAUSE");
	return 0;


}