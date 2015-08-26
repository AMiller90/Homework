#pragma once

#include <iostream>
#include<string>


//works
void concatenate() {




	char namearray[5][100];



	for (int i = 0; i < 5; i++)
	{
		char input[100];
		std::cout << "Enter Something: \n";
		std::cin.getline(input, 50);

		for (int j = 0; j < 50; j++)
		{
			namearray[i][j] = input[j];
		}
	}

	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < strlen(namearray[i]); j++)
		{
			std::cout << namearray[i][j];
		}
		       std::cout << " ";
	}


}

//works
void compare(char word[], char word2[]) {


		for (int i = 0, j = 0; i < word[i], j < word2[j]; i++, j++)
		{

			
				if (word[i] < word2[j])
				{
				
					std::cout << word << " is smaller in value\n";
					break;

				}


				if (word[i] > word2[j])
				{
					std::cout << word << " is bigger in value\n";
					break;

				}
				
		}
	
		
		
		

		
	
}

//works
int length(char word[]) {

	int num = 0;
	for (int i = 0; i < word[i]; i++)
	{
		num++;
		//std::cout << word[i];
	}
	return num;
}

//works
void Copy(char from[], char to[]) 
{
	for (int i = 0; i < strlen(from); i++) 
	
		to[i] = from[i];
		
	
}


//Problem 11
int main() 
{
	//char input[20];
	//char word2[50] = { '0' };

	///*int result = length(word);
	//std::cout << " = " << result << " characters" << std::endl;*/

	//std::cin.getline(input, 20);
	//std::cin.getline(word2, 50);

	////length
	///*int result = length(input);
	//std::cout << result;*/

	////copy
 //  /* Copy(input, word2);
	//std::cout << std::endl;
	//std::cout << iCopy << std::endl;*/
	//strcat_s(word2, input);

	//std::cout << word2;
	////compare
	////compare(input, word2);



	concatenate();


	








	system("PAUSE");
	return 0;
}