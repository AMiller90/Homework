#pragma once
#include<ctype.h>


#include <iostream>
#include <random>
#include <time.h>
#include<string>

int randomGen() {

	//sets random generator
	std::mt19937 randomGen(time(0));
	
	//distributes random numbers that are between the numbers set in parenthesis
	std::uniform_int_distribution<int> computerchoice(1, 3);
	//sets variable to the random number generated from the range and generator
	 int Number = computerchoice(randomGen);

	 return Number;
}


std::string input() {

	std::string input;
	std::cout << "Lets Play Rock Paper Scissors!" << std::endl;
	std::cout << std::endl;
	std::cout << "Please Enter Your Choice Of either Rock, Paper Or Scissors: " << std::endl;
	std::getline(std::cin, input);

	return input;
}


std::string computer(int number) {



	if (number == 1) {
		std::string a = "Rock";
		std::cout << "Rock" << std::endl;
		return a;
	}
	 if (number == 2) {

		std::string b = "Paper";
		std::cout << "Paper" << std::endl;
		return b;

	}
	  if (number == 3) {
		std::string c = "Scissors";
		std::cout << "Scissors" << std::endl;
		return c;
	}

}

void results(std::string inp, std::string rps, int number) {

	if (inp == rps) {
		std::cout << std::endl;
		std::cout << "It's a Tie" << std::endl;
		std::cout << std::endl;
		int number = randomGen();
		std::string inp = input();
		std::string rps = computer(number);
		results(inp, rps, number);

	} else if (inp != rps) {

		if ((inp == "Rock" || inp == "rock") && (rps == "Scissors" || rps == "scissors")) {
			std::cout << std::endl;
			std::cout << "Rock beats Scissors" << std::endl;
			std::cout << "You Win!" << std::endl;
			
		}
		
		if ((inp == "Paper") && (rps == "Rock")) {
			std::cout << std::endl;
			std::cout << "Paper beats Rock" << std::endl;
			std::cout << "You Win!" << std::endl;
		
		}
		if ((inp == "Scissors") && (rps == "Paper")) {
			std::cout << std::endl;
			std::cout << "Scissors beats Paper" << std::endl;
			std::cout << "You Win!" << std::endl;
			
		}

		if ((inp == "Scissors") && (rps == "Rock")) {
			std::cout << std::endl;
			std::cout << "Rock beats Scissors" << std::endl;
			std::cout << "Computer Wins!" << std::endl;
		
		}

		if ((inp == "Rock") && (rps == "Paper")) {
			std::cout << std::endl;
			std::cout << "Paper beats Rock" << std::endl;
			std::cout << "Computer Wins!" << std::endl;
			
		}
		if ((inp == "Paper") && (rps == "Scissors")) {
			std::cout << std::endl;
			std::cout << "Scissors beats Paper" << std::endl;
			std::cout << "Computer Wins!" << std::endl;
			
		}






	}
}


//Problem 17
int main() {
	

		int number = randomGen();
		

		std::string inp = input();
	

		std::string rps = computer(number);


		results(inp, rps, number);

		std::cout << std::endl;


	system("PAUSE");
	return 0;
}