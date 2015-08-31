#pragma once

#include<iostream>
#include<string>

void lookAndsay(int array[], int size) {
	int count = 1;

	int num[5];
	int i = 0;


	
	for (i; i < size; i++) 
	{
		

		if (array[i] == array[i + 1])
		{
			count++;
			
		}
		
		
	    if (array[i] != array[i + 1]) 
		{
			std::cout << count << ",";

			count = 1;
			num[i] = array[i];
			
			std::cout << num[i] << ",";

			
			
		}
		
		
		
	}

	
}


//Problem 16
int main() {


	int array[5] = { 1, 1, 1, 1, 1};

	lookAndsay(array, 5);



	system("PAUSE");
	return 0;

}