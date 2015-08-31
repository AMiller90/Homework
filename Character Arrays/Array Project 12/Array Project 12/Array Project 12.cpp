#pragma once


#include<iostream>

#include<string>


//Problem 12
int main()
{
	int max = 0;
	char input[25];
	char Char;
	std::cin.getline(input, 25);
	
	//loop through all characters
	for (char c = ' '; c < '~'; c++)
	{
		int count = 0;

		//loop through the length of the input
		for (int i = 0; i < strlen(input); i++)
		{

			if (input[i] == c)
			{

				count++;


			}
		}
			
		//the count number is greater than 0 then store it in max
		if (count > max)
		{
			max = count;
			Char = c;
		}
		
	}
	//max is the number of times the character appears and Char is the character
	std::cout << max << std::endl;
	std::cout << Char << std::endl;
	//std::cout << input << std::endl;

	


	system("PAUSE");
	return 0;
}