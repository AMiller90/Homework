#pragma once

#include<iostream>
#include<string>
#include"Class Project 5.h"



void result(std::string player1,std::string player2, int Score, int Score2, int Score3, int Score4)
{


	int totalScorePlayer1 = Score + Score2;
	int totalScorePlayer2 = Score3 + Score4;

	std::cout << player1 << "'s Score is " << totalScorePlayer1 << std::endl;
	std::cout << player2 << "'s Score is " << totalScorePlayer2 << std::endl;

	if (totalScorePlayer1 > totalScorePlayer2)
	{

		std::cout << player1 << " wins!\n";

	}
	else if (totalScorePlayer2 > totalScorePlayer1)
	{
		std::cout << player2 << " wins!\n";
	}
	else if (totalScorePlayer1 == totalScorePlayer2)
	{
		std::cout << "Its A Tie!\n";
	}




}

void trivia(Question questions[4], std::string player1, std::string player2)
{



	questions[0].question1(player1);
	int Score = questions[0].getAnswer1();
	std::cout << std::endl;

	 questions[1].question2(player1);
	 int Score2 = questions[1].getAnswer2();

	std::cout << std::endl;

	std::cout << "Now It's " << player2 << "'s Turn\n";
	std::cout << std::endl;


	questions[2].question3(player2);
	int Score3 = questions[2].getAnswer3();
	std::cout << std::endl;
	questions[3].question4(player2);
	int Score4 = questions[3].getAnswer4();
	std::cout << std::endl;

	result(player1, player2, Score, Score2, Score3, Score4);

}


int main()
{
	

	Question questions[4];

	std::string player1;
	std::string player2;

	std::cout << "Lets Play A Trivia Game!\n";
	std::cout << "\n";

	std::cout << "Enter Name For Player 1" << std::endl;
	std::cin >> player1;

	std::cout << std::endl;

	std::cout << "Enter Name For Player 2" << std::endl;
	std::cin >> player2;

	std::cout << std::endl;

	std::cout << player1 << " Goes First\n";
	std::cout << std::endl;


	trivia(questions, player1, player2);


	



	system("PAUSE");
	return 0;
}