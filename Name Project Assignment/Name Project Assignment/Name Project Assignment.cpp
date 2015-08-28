#pragma once



#include<iostream>
#include<string>



void converttoASCII(char name[]) {

	int ASCII[50];
	
	//Loops through the name input
	for (int i = 0; i < name[i]; i++)
	{
		//checks for index equal to space and sets the index before the space to a smiley face
		if ((name[i] == (char)32))
		{
			name[i - 1] = (char)1;
		}

		//checks for index of last character at end of line and sets it to smiley face
		if (i == strlen(name) - 1)
		{
			name[i] = (char)1;
		}

		////Type cast the char array to its ASCII equivalent
		ASCII[i] = name[i];
	
	
	}
	
	
		


	}

void converttoString(char name[])
{
	//Calls The ASCII Conversion
	converttoASCII(name);

	char fullName[3][30];

	//Loops Through Input And Sets It To 2D Array
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < strlen(name); j++)
		{
			fullName[i][j] = name[j];

			
		}


	}

	//Loops Through 2D Array And Prints Data
	for (int i = 0; i < 1; i++)
	{
		for (int j = 0; j < strlen(name); j++)
		{
			std::cout << fullName[i][j];


		}
		std::cout << std::endl;
	}

	
}
int main() {

	
	char name[50];
	std::cout << "What Is Your Name?\n";
	std::cin.getline(name, 50);

	std::cout << std::endl;

	converttoString(name);
	

	system("PAUSE");
	return 0;
}