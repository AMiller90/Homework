#include<iostream>
#include<fstream>
#include<string>

using namespace std;

//Allows User To Write To File
void Write()
{
	//bool flag variable
	bool bFlag = true;
	//Output stream
	ofstream file;
	//string variable for storing the users input
	string data;

	//Opens file For appending
	file.open("MyLog.txt", ios_base::app);

	cout << "Please Write To The File..To Quit:\n";

	//Error Checking - If file was not created
	if (file.fail())
	{
		cout << "File Failed To Be Created!" << endl;
	}
	else
	{
		//While bFlag is true continue to get user input and store it into the data variable
		while (bFlag == true)
		{
			//Ignores the first newline by cin
			cin.ignore();
			//Gets user input
			getline(cin, data);
			//stores the input data into the file
			file << data << endl;

			//Checks if the current input is not equal to any character
			if (data != "\0")
			{
				//If statement is true then stop getting user input
				bFlag = false;
			}

		}
			
		
	}
	//Closes File
	file.close();
	system("cls");



}

//Displays Text File To Screen
void Display()
{
	//String variable used for storing the data in the file
	string s;

	//Input stream for reading data
	ifstream file;

	//Opens file for reading
	file.open("MyLog.txt", ios_base::in);

	//Error checking
	if (file.fail())
	{//If file does not exist then print this out 
		cout << "File Does Not Exist!" << endl;
	}
	else
	{//while loop is used on getline to continuously read iun the data from the file and store it into the s variable
		cout << "This Is The Files Content:\n";
		while (getline(file, s))
		{//Prints out the s data
			cout << s;
		}
	}
	//Newlines
	cout << endl << endl;

	//Closes file
	file.close();

}

//Creates File If One Does Not Exist
void Create()
{
	//Output stream
	ofstream file;
	//Creates File
	file.open("MyLog.txt");

	//Error Checking 
	if (file.fail())
	{//If file could not be created print out this
		cout << "File Failed To Be Created!" << endl;
	}
	//closes file
	file.close();
}

//Erases Current Text And Replaces It With A Blank
void Clear()
{
	//Output stream 
	ofstream file;
	//Opens file to write to it
	file.open("MyLog.txt", ios_base::out);

	//Error Checking
	if (file.fail())
	{//If fails to open file then print this
		cout << "File Failed To Be Opened!" << endl;
	}
	else
	{//Input the "" int the file to replace the current data in the file
		/*file << "" << endl;*/
		Create();
	}

	//Prints out cleared file
	cout << "File Cleared!\n";
	//Closes File
	file.close();

}

//Function to get uer input
char Input()
{
	//variable for storing user input
	char cInput;

	cout << "What Would You Like To Do?\n\n";

	cout << "0.Create A File\n";
	cout << "1.Display\n";
	cout << "2.Write\n";
	cout << "3.Clear\n";
	cout << "4.Exit\n";
	cin >> cInput;
	system("cls");

	return cInput;

}

//User Uses Program
bool Use()
{
	//bool variable
	bool bIsDone = true;
	
	//Switch statement for implementing user interaction with program 
	switch (Input())
	{
	//Creates A File
	case '0':
		Create();
		break;
	//Displays Current Data In File
	case '1':
		Display();
		break;
	//Allows User To Write To The File
	case '2':
		Write();
		break;
	//Clears The File With A Blank Space
	case '3':
		Clear();
		break;
	//Exits The Program
	case '4':
		bIsDone = false;
		cout << "You Have Quit The Program\n";
		break;

	default:
		break;

	}
	//Returns true or false
	return bIsDone;
}

//Exercise 1
int main()
{

	//bool variable
	bool bIsDone = true;
	//While loop used as the game loop..if bIsDone is equal to false then game is over
	while (bIsDone == true)
	{//bIsDone is set to the return value of Use() function
		bIsDone = Use();
	}








	system("PAUSE");
	return 0;
}