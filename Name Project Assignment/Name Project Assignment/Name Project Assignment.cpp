#pragma once



#include<iostream>
#include<string>



void convert(char name[]) {


	char fullName[3][30];

	for (int i = 0; i < name[i]; i++)
	{

		if ((name[i] == (char)32))
		{
			name[i - 1] = (char)1;
		}

		if (i == strlen(name) - 1)
		{
			name[i] = (char)1;
		}



		for (int i = 0; i < 3; i++)
		{

			do {
				for (int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 30; j++)
					{
						fullName[i][j] = (int)name[j];

					}
				}


			} while (name[i] != (char)32);

		}
			
		


	}

	
}


int main() {

	
	char name[30];
	std::cout << "Enter Your Full Name:" << std::endl;
	std::cin.getline(name, 30);

	

	convert(name);

	std::cout << name;

	system("PAUSE");
	return 0;
}