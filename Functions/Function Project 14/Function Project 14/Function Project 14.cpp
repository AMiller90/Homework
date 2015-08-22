#pragma once

#include<iostream>

int Split(int input[], int size, int output_array[], int op_array[]) {

	for (int i = 0; i < size; i++){

		std::cout << input[i] << " ";
		//std::cout << output_array[i] << " ";
		//std::cout << op_array[i] << " ";
	}

	return 0;
}


//Problem 14
int main() {

	int input[4] = { 1, 2, -3, -4 };
	int output_array[4] = {};
	int op_array[4] = {};


	Split(input, 4, output_array, op_array);



	system("PAUSE");
	return 0;
}