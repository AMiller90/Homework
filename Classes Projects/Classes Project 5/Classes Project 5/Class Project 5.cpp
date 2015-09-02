
//includes the header file in order for this .cpp file to know what class this data belongs too
#include"Class Project 5.h"

Question::Question()
{



}


void Question::question1(std::string player1)
{
	int a = 1;
	int b = 2;
	int c = 3;
	int d = 4;

	std::cout << "Question 1\n";
	std::cout << std::endl;

	char question1[50] = { "In What Game Is Their A Rank Called High Warlord?" };

	char answer1[20] = { "World of Warcraft" };
	char answer2[20] = { "Starcraft" };
	char answer3[20] = { "League of Legends" };
	char answer4[20] = { "Dragon Age" };

	std::cout << question1 << std::endl;
	std::cout << a << ". " << answer1 << std::endl;
	std::cout << b << ". " << answer2 << std::endl;
	std::cout << c << ". "<< answer3 << std::endl;
	std::cout << d << ". "<< answer4 << std::endl;

	


}

void Question::question2(std::string player1)
{

	int a = 1;
	int b = 2;
	int c = 3;
	int d = 4;


	std::cout << "Question 2\n";

	char question2[51] = { "Which Game Is On The SNES?" };
	
	char answer1[20] = { "Final Fantasy X" };
	char answer2[20] = { "Super Smash Bros" };
	char answer3[20] = { "Halo" };
	char answer4[20] = { "Super Mario" };

	std::cout << question2 << std::endl;
	std::cout << a << ". " << answer1 << std::endl;
	std::cout << b << ". " << answer2 << std::endl;
	std::cout << c << ". " << answer3 << std::endl;
	std::cout << d << ". " << answer4 << std::endl;

	



}


void Question::question3(std::string player2)
{
	int a = 1;
	int b = 2;
	int c = 3;
	int d = 4;

	std::cout << "Question 3\n";

	char question3[58] = { "Who Go On A Journey To Save The King In Kingdom Hearts?" };
	
	char answer1[20] = { "Roxas & Mickey" };
	char answer2[20] = { "Donald & Goofy" };
	char answer3[20] = { "Hercules & Zeus" };
	char answer4[20] = { "Cid & Cloud" };


	std::cout << question3 << std::endl;
	std::cout << a << ". " << answer1 << std::endl;
	std::cout << b << ". " << answer2 << std::endl;
	std::cout << c << ". " << answer3 << std::endl;
	std::cout << d << ". " << answer4 << std::endl;



}

void Question::question4(std::string player2)
{
	int a = 1;
	int b = 2;
	int c = 3;
	int d = 4;

	int points = 0;
	int input;


	std::cout << "Question 4\n";

	char question4[45] = { "What Social Media Site Calls A Post a Tweet?" };
	
	char answer1[20] = { "Myspace" };
	char answer2[20] = { "Facebook" };
	char answer3[20] = { "Twitter" };
	char answer4[20] = { "Pinterest" };

	std::cout << question4 << std::endl;
	std::cout << a << ". " << answer1 << std::endl;
	std::cout << b << ". " << answer2 << std::endl;
	std::cout << c << ". " << answer3 << std::endl;
	std::cout << d << ". " << answer4 << std::endl;

	

}

//Getters
int Question::getAnswer1()
{

	int input;
	int points = 0;
	std::cout << "Input Number Of Your Choice" << std::endl;
	std::cin >> input;

	_answer1 = input;
	
	if (_answer1 == 1)
	{
		std::cout << "You Got A Point!\n";
		points++;
	}
	else if (_answer1 != 1)
	{
		std::cout << "That Is Incorrect\n";
		points = 0;
	}

	return points;


}


int Question::getAnswer2()
{

	int input;
	int points = 0;
	std::cout << "Input Number Of Your Choice" << std::endl;
	std::cin >> input;

	_answer2 = input;

	if (_answer2 == 4)
	{
		std::cout << "You Got A Point!\n";
		points++;
	}
	else if (_answer2 != 4)
	{
		std::cout << "That Is Incorrect\n";
		points = 0;
	}

	return points;
}

int Question::getAnswer3()
{


	int input;
	int points = 0;
	std::cout << "Input Number Of Your Choice" << std::endl;
	std::cin >> input;

	_answer3 = input;
	
	if (_answer3 == 2)
	{
		std::cout << "You Got A Point!\n";
		points++;
	}
	else if (_answer3 != 2)
	{
		std::cout << "That Is Incorrect\n";
		points = 0;
	}

	return points;
}

int Question::getAnswer4()
{

	int input;
	int points = 0;
	std::cout << "Input Number Of Your Choice" << std::endl;
	std::cin >> input;

	_answer4 = input;

	if (_answer4 == 3)
	{
		std::cout << "You Got A Point!\n";
		points++;
	}
	else if (_answer4 != 3)
	{
		std::cout << "That Is Incorrect\n";
		points = 0;
	}

	return points;

}

//Setters
void Question::setAnswer1(int one)
{

	_answer1 = one;

}


void Question::setAnswer2(int two)
{

	_answer2 = two;

}


void Question::setAnswer3(int three)
{

	_answer3 = three;

}

void Question::setAnswer4(int four)
{

	_answer4 = four;


}

