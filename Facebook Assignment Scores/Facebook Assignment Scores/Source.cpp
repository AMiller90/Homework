#include<fstream>
#include<string>
#include<iostream>

using namespace std;

//Add Data to file
void AddScoresToFile(string file)
{
	//bool variable used to store true or false
	bool bLoop = true;
	//int array variable
	int ScoresArray[10];
	//int variable
	int hold;

	//Creates instance of ofstream
	ofstream Scores;
	
	//Opens A File To Write To It
	Scores.open(file, ios_base::app);

	//Error Checking
	if (Scores.fail())
	{//If file fails to open then print this
		cout << "File Failed To Open!";
	}
	else
	{//if file is opened then print this and set up while loop
		cout << "Please Enter The Scores You Want To Record:\n";
		//while the loop variable is set to true
		while (bLoop == true)
		{
			//Loop through the array 
			for (int i = 0; i < 10; i++)
			{//Get input from user and store into array
				cin >> ScoresArray[i];

			}
			//once all input is gathered then bloop is set to false and break out the while loop
			bLoop = false;
		}

		    //loop through the array
			for (int i = 0; i < 10; i++)
			{
				//loop through the array
				for (int j = 0; j < 10; j++)
				{
					//checks if current variables value is less than the next variables value
					if (ScoresArray[j] < ScoresArray[j + 1])
					{
						//if true then store current variables value in hold variable
						hold = ScoresArray[j];
						 //Store next variable value into current variable
						ScoresArray[j] = ScoresArray[j + 1];
						//store hold variables value into next variable
						ScoresArray[j + 1] = hold;
					}

				}
			
				
			}
			//Loop through array
			for (int i = 0; i < 10; i++)
			{//Store the data in the array into the file and a space in between each index value
				Scores << ScoresArray[i] << " " ;
			
			}
			//Put a new line in the file after all data has been put in
			Scores << endl;

			//Closes The File
		Scores.close();
	}
}

//Read data from file
void ReadFromFile(string file)
{
	//Variable for data from the file
	int data;
	//Creates instance of ifstream
	ifstream Scores;
	//variable for while loop
	bool bIsDone = true;

	//Opens the file to read from
	Scores.open("Scores.txt", ios_base::in);

	//Error checking
	if (Scores.fail())
	{//If file fails to open then print this
		cout << "File Failed To Open!";
	}
	else
	{
		cout << "File Contents:\n";
		//While there is something to put into the data variable from the Scores variable
		while (Scores >> data)
		{
			//Prints out the data to console and a space between each element
			cout << data << " ";
		}
		//Print out newline
		cout << endl;
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

	//Open and Add Data to file
	AddScoresToFile("Scores.txt");
	
	//Read data from file
	ReadFromFile("Scores.txt");


	system("PAUSE");
	return 0;
}