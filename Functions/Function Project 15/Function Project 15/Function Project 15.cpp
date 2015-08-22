#pragma once

#include<iostream>
//includes pow
#include<cmath>

int power(int x, int y){
	//pow function is used for determining the power of a number
	//first number in parenthesis is for the base number
	//the second number is the exponent
	
	int result = pow(x, y);

		return result;
}


//Problem 15
int main() {

	int x;
	int y;
	

	std::cout << "Lets Find Numbers To The Nth Power! The First number will be the number you want to find the power of and the second will be the power: " << std::endl;
	std::cin >> x;
	std::cin >> y;

	int result = power(x, y);

	std::cout << result << std::endl;





	system("PAUSE");
	return 0;


}