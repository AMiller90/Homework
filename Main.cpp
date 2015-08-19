#pragma once

//Include library For Input And output
#include <iostream>




int main() {


	int apples = 2;
	int bananas = 8;

	//Fruit program
	int TotalFruit = apples + bananas;

	std::cout << TotalFruit << std::endl;

	int Sold = TotalFruit - bananas;

	std::cout << Sold << std::endl;

	int Bought = TotalFruit * bananas;

	std::cout << Bought << std::endl;

	int Divide = TotalFruit / apples;

	std::cout << Divide << std::endl;
   


	std::cout << "What Would You Like To Buy? Enter A Number: " << std::endl;
	std::cout << std::endl;
	std::cout << "1. Gun" << std::endl;
	std::cout << "2. Sword" << std::endl;

	int number;

	//This Is A Get Function!
	std::cin >> number;

	bool isDone;

	while (isDone = true) {

		if (number == 1) {

			std::cout << "You Bought A Gun!" << std::endl;
			break;
		}
		else if (number == 2) {

			std::cout << "You Bought A Sword!" << std::endl;
			break;
		}
		else {

			std::cout << "That Is Bad Input!" << std::endl;
			break;
		}

	}










	system("PAUSE");
	return 0;
}