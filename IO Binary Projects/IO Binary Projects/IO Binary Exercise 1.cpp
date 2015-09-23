#include<iostream>
#include<fstream>

using namespace std;

struct CallNumber
{

	float x;


};

//A) Write a function to load records from a file.
void LoadRecords() 
{
	CallNumber callnumber;

	//This opens the file
	ofstream fout("library.dat", ios::out | ios::binary);

	//If the file opens 
	if (fout.good())
	{//Read in the data
		ifstream fin("library.dat", ios::in | ios::binary);

		while (!fin.eof())
		{
			fin.read((char*)&callnumber, sizeof(CallNumber));
			cout << callnumber.x;
		}

		fout.close();
	}
	else
	{//Opens the file
		ofstream fout("library.txt", ios::out | ios::binary);
		//If fail
		if (fout.fail())
		{//Print file was not opened
			cout << "File Was Not Opened!\n";
			exit(1);
		}
		else
		{
			ifstream fin("library.txt", ios::in | ios::binary);
			while (!fin.eof())
			{//read from the data
				fin.read((char*)&callnumber, sizeof(CallNumber));
				
			}

			fout.close();

			//Create and open the binary file
			ofstream fout("library.dat", ios::out | ios::binary);
			//Error checking
			if (fout.good())
			{
				for (int i = 0; i < 30; i++)
				{//write the contents 
					fout.write((char*)&callnumber, sizeof(CallNumber));
				}
				
				fout.close();

			}

		}
	}


}

//B) Write a function to save records to the binary file.
void SaveRecords()
{



}

//C) Write a function to 
//Exercise 1
int main()
{

	LoadRecords();


	

	system("PAUSE");
	return 0;
}