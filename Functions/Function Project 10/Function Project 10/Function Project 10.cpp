#pragma once

#include<iostream>
int a;

void MultiplyByIndex(int input_array[], int output_array[], int array_size) {

	//If you would like to see the arrays before the change then uncomment this
	/*for (int i = 0; i < array_size; i++) {
		
		std::cout << input_array[i] << " ";
	}

	std::cout << std::endl;

	for (int j = 0; j < array_size; j++) {
		std::cout << output_array[j] << " ";
		
	}

	std::cout << std::endl;*/

	//this sets each index of output array to the answer of multiplying the indeces of output array and input array
		output_array[0] = output_array[0] * input_array[0];
		output_array[1] = output_array[1] + 1 * input_array[1];
		output_array[2] = output_array[2] + 2 * input_array[2];
		output_array[3] = output_array[3] + 3 * input_array[3];
		output_array[4] = output_array[4] + 4 * input_array[4];
		output_array[5] = output_array[5] + 5 * input_array[5];
		output_array[6] = output_array[6] + 6 * input_array[6];


		for (int i = 0; i < array_size; i++) {

			std::cout << output_array[i] << " ";
		}
	

	}


//Problem 10
int main() {

	int integer_array[7] = { 10, 15, 7, 4, 13, 19, 8 };
	int output_array[7] = {};
	MultiplyByIndex(integer_array, output_array, 7);



	system("PAUSE");
	return 0;
}