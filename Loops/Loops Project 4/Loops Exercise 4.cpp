#pragma once

#include<iostream>


int sum;


int main() {

	//Problem 4- Put all 3 exercies in a while loop

	std::cout << "Hello! I Put All 3 Loop Exercises Into 1 While Loop and You Get To Choose Which You Want To View. Just Enter A Number From 1 - 3: " << std::endl;
	int choice1;
	std::cin >> choice1;

	
	bool codeisRunning;

	while (codeisRunning = true) {

		switch (choice1) {


		case 1:
			std::cout << std::endl;
			std::cout << "Exercise 1:" << std::endl;

			//Problem 1
			//Using a for loop to iterate backward, print the values 100 to 0.
			//Modify the for loop to include 0 and include 100

			for (int i = 100; i >= 0; i--) {

				std::cout << i << " ";

			}

			std::cout << std::endl;
			std::cout << std::endl;
			std::cout << std::endl;

			//Modify the for loop to include 0 and not 100
			for (int i = 100 - 1; i >= 0; i--) {

				std::cout << i << " ";

			}

			std::cout << std::endl;
			std::cout << std::endl;
			std::cout << std::endl;

			//Modify the for loop to not include 0 and include 100
			for (int i = 100; i > 0; i--) {

				std::cout << i << " ";

			}

			std::cout << std::endl;
			std::cout << std::endl;
			std::cout << std::endl;

			//Modify the for loop to decrement by 2
			for (int i = 100; i >= 0; i--) {

				std::cout << i-- << " ";

			}

			std::cout << std::endl;
			break;


		case 2:

			std::cout << std::endl;
			std::cout << "Exercise 2:" << std::endl;
			//Problem 2
			//Using a for loop, iterate through numbers 0 to 100
			//Loop through variable i
			for (int i = 0; i <= 100; i++) {
				//checks every third i value && checks every fifth value
				if ((i % 3 == 0) && (i % 5 == 0)) {
					//Prints FizzBuzz if both conditions are true
					std::cout << "FizzBuzz " << std::endl;

				}//Checks only every third i value
				else if ((i % 3 == 0)) {
					//Prints Fizz if Conditon is True
					std::cout << "Fizz" << std::endl;

				}//Checks only every fifth i value
				else if ((i % 5 == 0)) {
					//Prints Buzz if condition is true
					std::cout << "Buzz " << std::endl;

				}
				else {
					//Whichever numbers do not meet previous conditions then print the number
					std::cout << i << std::endl;
				}
			}

			break;

		case 3:

			std::cout << std::endl;
			std::cout << "Exercise 3:" << std::endl;

			//Problem 3
			//for loop to iterate from 0 - 999
			for (int i = 0; i < 1000; i++) {

				//checking for every 5th number during  loop
				if (i % 5 == 0) {


					//print the i value when if statement is true
					std::cout << i << std::endl;

					//while looping and as the if statement continues to be == 0 - the value of i gets added into the variable sum and therefore
					//adds the new i value to the already value stored in sum causing the values to add each time.
					sum += i;


				}



			}
			//Prints grand total of all numbers iterated from 0 to 995
			std::cout << "This Is The Total: " << sum << std::endl;


			break;

		default:
			std::cout << "That Is The Wrong Input!";
			break;


		}// end switch statement



		std::cout << "What Other Exercise Would You Like To See? Or Enter Q To Quit" << std::endl;
		int result;
		std::cin >> result;

		choice1 = result;
		
		
	}
		system("PAUSE");
		return 0;
	
}