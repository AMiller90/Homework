
#include<iostream>

using namespace std;

//Function Declaration-Lets The Program Know It Exists
float addStuff(float num1, float num2)
{
	//Adds The 2 Entered Numbers By The User Together And Stores The Answer In The Sum Variable
	float sum = num1 + num2;

	//Returns The Answer
	return sum;
}


int main()
{
	//These Are The Variables Used To Store The Numbers We Will Be Using In The Function
	float num1, num2;

	//Prompts User To Enter 2 Numbers Of Their Choosing
	cout << "Please Enter 2 Numbers and I Will Add Them Up: " << endl;
	cin >> num1;
	cin >> num2;

	//Calls The Function And Prints It To The Screen
	cout << addStuff(num1, num2);

	cout << endl;

	system("PAUSE");
	return 0;
}