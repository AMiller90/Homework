#pragma once


#include<iostream>


class Question
{

public:

	Question();
	
	//Function Declarations
	void question1(std::string player1);
	void question2(std::string player1);
	void question3(std::string player2);
	void question4(std::string player2);
	int getAnswer1();
	int getAnswer2();
	int getAnswer3();
	int getAnswer4();
	void setAnswer1(int one);
	void setAnswer2(int two);
	void setAnswer3(int three);
	void setAnswer4(int four);

private:

	//Private Variables
	int _answer1;
	int _answer2;
	int _answer3;
	int _answer4;

};