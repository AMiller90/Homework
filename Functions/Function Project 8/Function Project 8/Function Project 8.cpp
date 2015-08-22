#pragma once


#include<iostream>


int sum;

int SumArray(int integer_array[], int array_size){

	for (int i = 0; i < array_size; i++){
		//commented this out to show only the return value..if you want to see all the numbers outputted to screen then uncomment and run program
		//std::cout << integer_array[i] << " ";
		

		sum += integer_array[i];
	}
	
	return sum;
}


//Problem 8
int main() {



	int integer_array[5] = { 7, 3, 2, 4, 9 };
    int result = SumArray(integer_array, 5);
	std::cout << result << std::endl;

	system("PAUSE");
	return 0;
}