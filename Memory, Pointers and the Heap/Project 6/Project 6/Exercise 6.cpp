
#include <iostream>


/*A.Write a function RevString(char* array) which reverses array.The function
returns nothing.*/
void RevString(char *myArray)
{
	//Get length of myArray and set it to new int len variable.
	int len = strlen(myArray);

	//Use for loop to iterate through the length of the array.
	//i is set to 0. j is set to the len - 1..because we do not want to include the null pointer at the end of the array...char arrays have a null pointer at the end.
	//The conditon will be while i is les than the length of the array dvided by 2.
	//i will increment by one each iteration and j will decrement by one each iteration.
	for (int i = 0, j = len - 1; i < len / 2; i++, j--)
	{
		//Create a new char variable and Store the current i index value into the temp variable each iteration.
	    char temp = myArray[i];
		//Store the j index value into the current i index each iteration.
		myArray[i] = myArray[j];
		//Store the value in temp that was given by i into the j index each iteration.
		myArray[j] = temp;

		
	}
}

/*B.Write a function CountEven(int* array, int array_len) which receives an
integer array and its size, and returns the number of even numbers in the array.*/
int CountEven(int *array, int array_len)
{
	//Create int count variable and set to 0.
	int count = 0;

	//Use For Loop to loop through array length.
	for (int i = 0; i < array_len; i++)
	{
		//This if statement checks to see if using the modulus operator on the current value at array index i will be zero.
		//If it is not equal to zero then it skips this statement and count does not increment.
		if ((array[i] % 2) == 0)
		{
			//If statement is true that means the number after the operation is even because it will have not have a remainder..it will be 0.
			//Increase count by 1
			count++;
	    }
		
    }
	
	//return the count value
	return count;
}

/*C.Write a function Maximum(double* array, int array_size) that returns a
pointer to the maximum value of an array of doubles.If the array is empty, return
nullptr.*/
double* Maximum(double* array, int array_size)
{
	//Sets array to a double pointer.
	double *ptr = array;

	//For loop loops throught the size of the array.
	for (int i = 0; i < array_size; ++i)
	{
	//Checks if the current array index is < the next value in the index
		if (array[i] < array[i + 1])
		{
			//If statement is correct then i stores the value at the next array index into the pointer variable
			*ptr = array[i + 1];

		}

	}

	//Checks if the array is not initialized
	if (array == 0)
	{
		//If statement is true then set pointer to nullptr. which is 0.
		ptr = nullptr;
		
	}
	//returns a pointer value
	return ptr;
}

/*D.Write a function Contains(char* array, char search_value) which returns
true if the 1st parameter contains the 2nd parameter, or false otherwise*/
bool Contains(char* array, char search_value)
{
	//Create a boolean variable and set it to true
	bool bFound = true;

	//For loop to loop through the size of the array
	for (int i = 0; i < 4; ++i)
		{//Create a char pointer and set its value to the current index in the array
			char *ptr = &array[i];

			//Checks if the value at *ptr is equal to the search value
			if (*ptr == search_value)
			{
				//If statement is true then set bFound variable to true.
				bFound == true;
				//Print out found it and the value.
				std::cout << "Found It: " << *ptr << std::endl;
				//returns true
				return bFound;
			}
			

		}

	   //If statment was not true then set bFound to false because the search value was not in the array.
		bFound == false;
		//Print out its not here
		std::cout << "Its not here!\n";

		//returns false
	return bFound;
}


//Exercise 6
int main()
{

	
	/*Question 6.Write a function for each of the following descriptions.For each function, use the pointer
		notation ONLY.Do NOT use the array index[] notation.*/
		
		
		
		
	//Create a char array and initialize array.
	char myArray[100] = {'a','b','c','d'};
	
	//Call RevString function and pass in myArray
	RevString(myArray); 

	//Prints out myArray that has been modified from previous function
	std::cout << myArray << std::endl;

	//Create an integer array and intitialize array.
		int iArray[4] = { 1, 2, 3, 4 };
		//Print out the return value of the CountEven Function. Function Passes in iArray and the array size.
		std::cout << CountEven(iArray, 4);
		//Prints out a new line
		std::cout << std::endl;

		//Create a double array and initialize array.
		double dArray[4] = { 230.0, 211.0, 260.0, 290.0 };
		//Creates A ptr variable to dereference the return value of the Maximum function.
		double *ptr = Maximum(dArray, 4);
		//Prints out the dereference value
		std::cout << *ptr;
		//Prints out a newline
		std::cout << std::endl;


		//Creates a char variable and sets it to a value
	char search_value = 'd';
	//Calls Function and passes in the myArray and search_value.
	Contains(myArray, search_value);

	





	system("PAUSE");
	return 0;
}