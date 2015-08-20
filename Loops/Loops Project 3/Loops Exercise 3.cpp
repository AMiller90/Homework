#pragma once

#include <iostream>

//variable for sum of all i numbers
int sum;

int main() {

	
	//for loop to iterate from 0 - 999
	for (int i = 0; i < 1000; i++) {

		//checking for every 5th number during  loop 
		if (i % 5 == 0) {

			
			//print the i value when if statement is true
			std::cout << i << std::endl;
		
			/*while looping and as the if statement continues to be == 0 - the value of i gets added into the variable sum and therefore
			adds the new i value to the already value stored in sum causing the values to add each time.*/
			sum += i;

	
		}
		
		

	}
	//Prints grand total of all numbers iterated from 0 to 995
	std::cout << "This Is The Total: " << sum << std::endl;


	system("PAUSE");
	return 0;
}