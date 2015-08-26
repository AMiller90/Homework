#pragma once

#include<iostream>
#include<array>

int sum;

 void modify(int array_input[], int array_size){

	
	 //Loops through the array
	for (int i = 0; i < array_size; i++){
		//std::cout << array_input[i] << " ";
	
		//stores value of array into sum
		 sum += array_input[i];

		 //stores the value back into the array
		 array_input[i] = sum;
		 std::cout << array_input[i] << " ";
	

}

	std::cout << std::endl;


	return;
}

//Problem 12
int main() {

	
	int array_input[4] = { 3, 2, 4, 7};

	modify(array_input, 4);


	system("PAUSE");
	return 0;

}