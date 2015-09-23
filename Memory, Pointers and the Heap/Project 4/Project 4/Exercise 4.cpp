

#include<iostream>

//Exerceise 4
int main()
{
	//Question 4.Explain the error.
	char c = 'A';
	double *p = &c;

	//The error here is that The double data type of the pointer does not match the data type of the variable it is trying to access the value of.
	//Data types must be the same of the pointer and the variable it is trying to access

	system("PAUSE");
	return 0;


}