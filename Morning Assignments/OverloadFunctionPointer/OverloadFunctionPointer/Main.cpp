//09/12/16
//Write a function that takes another Func as a parameter.
//The passed function need only to add two numbers.
//Can the passed function be overloaded ? Explain why / why not

//YES! The passed in function can be overloaded as long as the return type stays the same.
//The parameters are of no importance to the function pointer. What matters is the return type.

#include<iostream>

//typedef function pointer with a return type of int
typedef int(*functptr)();

//Function that will take function pointer as a paramater and return its value
int Evaluate(int functptr)
{
	return functptr;
}

//Function to add numbers together
int AddNumbers()
{
	int num1 = 10;
	int num2 = 10;
	return num1 + num2;
}

//Function overload
int AddNumbers(const int& num1, const int& num2)
{
	return num1 + num2;
}

//Function overload
int AddNumbers(char* stuff)
{
	if (stuff == nullptr)
		return 0;

	for (; *stuff != '\0'; stuff++)
	{
		std::cout << *stuff;

	}

	return 1;
}

int main()
{
	char stuff[] = { "Andrew" };

	std::cout << Evaluate(AddNumbers(10, 20)) << "\n";

	std::cout << Evaluate(AddNumbers()) << "\n";

	Evaluate(AddNumbers(stuff));

	int tmp;
	std::cin >> tmp;

	return 0;
}
