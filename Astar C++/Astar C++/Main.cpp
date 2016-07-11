#include<iostream>
#include "Astar.h"
#include <windows.h>
using namespace std;

int main()
{
	int rows;
	int columns;
	int start;
	int goal;

	bool isDone = true;

	while(isDone)
	{
		cout << "Enter a number for the rows of the grid: ";
		cin >> rows;

		cout << "Enter a number for the columns of the grid: ";
		cin >> columns;

		cout << "Enter a number for the start node: ";
		cin >> start;

		cout << "Enter a number for the goal node: ";
		cin >> goal;

		Astar astar = Astar(start, goal, rows, columns);

		if (astar.checkStartandEndNodes())
		{
			char input;
			astar.Run();
			cout << "\n\nRun another test? y/n:\n";
			cin >> input;

			switch(input)
			{
			case 'y':
				isDone = true;
				break;
			case 'n':
				isDone = false;
				break;
			default:
				break;
			}
		}
		else
		{
			//Set the console text to this color
			HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
			SetConsoleTextAttribute(hConsole, 7);
			isDone = true;
		}
	}

	return 0;

}