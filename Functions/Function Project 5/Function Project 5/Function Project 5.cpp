#pragma once

#include<iostream>
//access the rand() function
#include<cstdlib>
#include<time.h>

//Function To Simulate Coin Tossing
int CoinToss() 
{
	srand(time(NULL));
	char hOt[20];
	std::cout << "Heads or Tails?" << std::endl;
	std::cin >> hOt;


	 //rand() is a random number generator
		int results = rand() % 100;

		if (results <= 50) {
			std::cout << "It's Heads!" << std::endl;
			
		}
		else
			std::cout << "It's Tails!" << std::endl;
		//returns the rndomly generated numbers
		return results;
}


//Problem 5
int main() {
	
	
	int tosses;
	std::cout << "Lets Toss A Coin! How Many Times Would You Like It To Be Tossed?" << std::endl;
	std::cin >> tosses;

	for (int i = 0; i < tosses; i++){
		//callng the function and storing the return in a variable to be printed to screen
		int results = CoinToss();

		std::cout << results << std::endl;
}
	system("PAUSE");
	return 0;

}