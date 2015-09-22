#include<fstream>
#include<string>
#include<iostream>

using namespace std;

//Add Data to file
void AddScoresToFile(string file)
{
	bool bLoop = true;
	int ScoresArray[5];
	int max = 0;
	
	ofstream Scores;
	
	Scores.open(file, ios_base::app);

	if (Scores.fail())
	{
		cout << "File Failed To Open!";
	}
	else
	{
		cout << "Please Enter The Scores You Want To Record:\n";
		while (bLoop == true)
		{

			for (int i = 0; i < 5; i++)
			{
				cin >> ScoresArray[i];

			}
			bLoop = false;
		}

	
			for (int i = 0; i < 5; i++)
			{
				if (ScoresArray[i] > max)
				{
					max = ScoresArray[i];

				}

			}

			Scores << max << endl;
		

		Scores.close();
	}
}

//Read data from file
void ReadFromFile(string file)
{
	//Variable for data from the file
	int data;
	//Creates in stream
	ifstream Scores;
	//variable for loop
	bool bIsDone = true;

	Scores.open("Scores.txt", ios_base::in);

	//Error checking
	if (Scores.fail())
	{
		cout << "File Failed To Open!";
	}
	else
	{
		cout << "This Is The Files Content:\n";
		//While there is something to put into the data variable from the Scores variable
		while (Scores >> data)
		{
			//Prints out the data to console
			cout << data;
		}
		
	}



}

//For those that have completed yesterday's assignment early attempt this exercise
//Create a text file that records scores.
//create a Function that adds scores to the file.
//only keep the 10 highest.
//Save them to the file
//Order the scores from highest to lowest
//Print the newly ordered list to the console
int main()
{


	AddScoresToFile("Scores.txt");
	
	ReadFromFile("Scores.txt");


	system("PAUSE");
	return 0;
}