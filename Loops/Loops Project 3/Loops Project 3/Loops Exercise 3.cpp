#pragma once

#include <iostream>


int sum;

int main() {

	

	for (int i = 0; i < 1000; i++) {

		if ((i % 3 == 0) || (i % 5 == 0)){

			
			
			std::cout << i << std::endl;
		
			
			sum += i;

	
		}
		
		

	}
	
	std::cout << "This Is The Total: " << sum << std::endl;


	system("PAUSE");
	return 0;
}