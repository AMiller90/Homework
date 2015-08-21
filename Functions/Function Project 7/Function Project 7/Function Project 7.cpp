#pragma once

#include<iostream>

//global variable
int sum;
int SumTo(int n){
	
	for (int i = 1; i <= n; i++){
		std::cout << i << " ";

		sum += i;
	}
	
	return sum;

}
int main() {

	
	//Problem 7
	int result = SumTo(3);
	std::cout << result << std::endl;

	std::cout << std::endl;

	result = SumTo(15);
	std::cout << result << std::endl;


	system("PAUSE");
	return 0;
}