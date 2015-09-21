#include<iostream>
#include<fstream>

using namespace std;



//A) Write a function to load records from a file.
void LoadRecords()
{
	int myArray[30];

	//This opens the file
	ofstream fout("library.dat", ios::out | ios::binary);

	//If the file opens 
	if (fout.good())
	{
		ifstream fin("library.dat", ios::in | ios::binary);

		while (!fin.eof())
		{

		}

		fout.close();
	}
	else
	{
		ofstream fout("library.txt", ios::out | ios::binary);

		if (fout.fail())
		{
			cout << "File Was Not Opened!\n";

		}
		else
		{
			ifstream fin("library.txt", ios::in | ios::binary);
			while (!fin.eof())
			{

			}

			fout.close();

			ofstream fout("library.dat", ios::out | ios::binary);

			if (fout.good())
			{
				fout.write();
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

	


	

	system("PAUSE");
	return 0;
}