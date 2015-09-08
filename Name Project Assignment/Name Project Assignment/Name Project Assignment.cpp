#pragma once



#include<iostream>
#include<string>



void converttoASCII(char name[], int ASCII []) {

	
		//Loops through the name input
		for (int i = 0; i < name[i]; i++)
		{
			//sets name to ascii characters
			ASCII[i] = name[i];

		}
	
		

	}

void converttoString(char name[], int ASCII[])
{


	char fullName[3][30];

	//Loops Through Input And Sets It To 2D Array
	for (int i = 0; i < 3; i++)
	{

		for (int j = 0; j < ASCII[j]; j++)
		{
		
			////checks for index equal to space and sets the index before the space to a smiley face
			if (name[j] == (char)32)
			{
				name[j - 1] = 1;
			}
			//checks for index of last character at end of line and sets it to smiley face
			if (j == strlen(name) - 1)
			{
				name[j] = (char)1;
			}

			
			fullName[i][j] = name[j];


		}



	}





	//Loops Through 2D Array And Prints Data
	for (int i = 2; i < 3; i++)
	{
		for (int j = 0; j < ASCII[j]; j++)
		{
			

			std::cout << fullName[i][j];


		}
		std::cout << std::endl;
	}

	}

int main() {


	int ASCII[50];
	char name[50];
	std::cout << "What Is Your Name?\n";
	std::cin.getline(name, 50);

	std::cout << std::endl;

	//Calls The ASCII Conversion
	converttoASCII(name, ASCII);

    converttoString(name, ASCII);


	system("PAUSE");
	return 0;
}







