#pragma once

#include<iostream>
#include<string>

//includes the header file in order for this .cpp file to know what class this data belongs too
#include"Class Project 5.h"


//Declare Functions
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



/*Problem 5
Create a simple trivia game for two players.The program will work like this:

a.Starting with player 1, each player gets a turn at answering 2 trivia questions. (There
	are 4 questions, 2 for each player.) When a question is displayed, four possible
	answers are also displayed.Only one of the answers is correct, and if the player
	selects the correct answer, he or she earns a point.
	b.After answers have been selected for all of the questions, the program displays the
	number of points earned by each player and declares the player with the highest
	number of points the winner.
	You are to design a Question class to hold the data for a trivia question.The Question class
	should have character array fields for the following data :
A trivia question
Possible answer 1
Possible answer 2
Possible answer 3
Possible answer 4
The number of the correct answer(1, 2, 3, or 4)

The Question class should have appropriate set and get methods.The program should
create an array of 4 Question objects, one for each trivia question.Make up your own trivia
questions on the subject or subjects of your choice for the objects.*/



int main()
{
	
	//Instance of Class
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

	//Calls Function
	trivia(questions, player1, player2);


	



	system("PAUSE");
	return 0;
}