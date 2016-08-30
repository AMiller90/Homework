#include<iostream>

//08/29/16
//Write a function that takes another function as an argument.
//Store this argument in an array. Then execute every function in the array

//Typedef a function pointer
typedef void(*funcptr)(void);

//Function with a Function pointer as arguement
void ExecuteFunctions(funcptr);

void PrintStuff()
{
	std::cout << "I am a function to print stuff";
}

//void(*functarray[1])();
funcptr functarray[1];

int main()
{
	//Call Function with passed in funcptr object
	ExecuteFunctions(PrintStuff);

	int tmp;
	std::cin >> tmp;

}

void ExecuteFunctions(void(*funcptr)())
{
	//Store into array
	functarray[0] = funcptr;

	//Doing sizeof(array) will get the total number of bytes allocated for the array.
	//You can then find out the number of elements in the array by dividing the size of one element in the array sizeof(*array)
	int size = sizeof(functarray) / sizeof(*functarray);

	//Loop through and call functions
	for (int i = 0; i < size; i++)
	{
		functarray[i]();
	}
}