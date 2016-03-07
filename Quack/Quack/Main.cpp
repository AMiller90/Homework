#include "Quack.h"
#include<iostream>

using namespace std;


void Run();

int main()
{
	
	Run();

    system("PAUSE");

	return 0;
}

void Run()
{
	
	int input;
	int element;
	
	cout << "What would you like to do with the Quack?\n";
	cout << "1. Push: Add a new element in front first\n";
	cout << "2. Enqueuer: Add a new element in front first\n";
	cout << "3. Pop: Remove the first element\n";
	cout << "4. Dequeue: Remove the last element\n";
	cout << "5. Check if the quack is empty\n";
	cout << "6. Print Quack\n";
	cout << "7. Get Size\n";
	cout << "0. Quit\n\n";
	
	cout << "Enter the corresponding number 1 - 7 or 0 To Quit:\n\n";
	

	Quack<int> user;
	bool play = true;
	while (play)
	{
		cin >> input;
		

		switch (input)
		{
		case 1:
			cout << "What would you like to add?\n";
			cin >> element;
			user.push(element);
			break;

		case 2:
			cout << "What would you like to add?\n";
			cin >> element;
			user.enqueuer(element);
			break;

		case 3:
			user.pop();
			break;

		case 4:
			user.dequeue();
			break;

		case 5:
			user.isEmpty();
			break;

		case 6:
			user.print();
			break;

		case 7:
			cout << "Size is: " << user.getSize() << endl;
			break;

		case 0:
			play = false;
			break;

		default:
			break;
		}
	}

}