#pragma once

#include<iostream>
#include<string>

void lookAndsay(int array[], int size) {
	int count = 0;

	int num = 0;


	for (int i = 0; i < size; i++) 
	{
		std::cout << array[i] << " ";

		if (array[i] = array[i]){

			count++;
			if (array[i] != array[i]) {

				count == 0;
			}
		}
		
	}


		

	
	std::cout << count;
	

	
}



int main() {


	int array[4] = { 1, 1, 1, 1};

	lookAndsay(array, 4);



	system("PAUSE");
	return 0;

}