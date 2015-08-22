#pragma once


#include<iostream>



void addArrays(int input[], int input_array[], int array_size, int output[]){
	
	//If you want to check the answer then uncomment these 2 loops 
	//loop through input[]
	/*for (int i = 0; i < array_size; i++) {

		std::cout << input[i] << " ";
	}

	std::cout << std::endl;

	//loop through input_array
	for (int i = 0; i < array_size; i++) {

		std::cout << input_array[i] << " ";
	}
	std::cout << std::endl;*/

	//loop through all 3 arrays 
	for (int i = 0; i < array_size; i++) {
    //add the indeces of input array and input_array together to get the sum to be stored into the indeces of output array
   //at the same indeces
	output[i] = input[i] + input_array[i];

	std::cout << output[i] << " ";
	}

	return;
}


//Problem 11
int main() {

	int input[2] = { 2, 4 };
	int input_array[2] = { 2, 4 };
	int output[2] = {};

	addArrays(input, input_array, 2, output);



	system("PAUSE");
	return 0;

}