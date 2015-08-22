#pragma once


#include<iostream>

int output;

int MinInArray(int integer_array[], int array_size) {

	for (int i = 0; i < array_size; i++) {
		//commented this out to show only the lowest value..if you want to see all the numbers outputted to screen then uncomment and run program
		//std::cout << integer_array[i] << " ";

		if ((((((integer_array[3] < integer_array[0]) && 
			(integer_array[3] < integer_array[1])) && 
			(integer_array[3] < integer_array[2])) &&
			(integer_array[3] < integer_array[4])) &&
			(integer_array[3] < integer_array[5])) &&
			(integer_array[3] < integer_array[6]))

		{
			
			output = integer_array[3];
			
		}
		
	}

	return output;
}



//Problem 9
int main(){


	int integer_array[7] = { 10, 15, 7, 4, 13, 19, 8 };
	int result = MinInArray(integer_array, 7);
	std::cout << result << std::endl;




	system("PAUSE");
	return 0;
}