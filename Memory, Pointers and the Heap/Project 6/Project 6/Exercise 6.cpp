
#include <iostream>



void RevString(char *myArray)
{

	int len = strlen(myArray);

	for (int i = 0, j = len - 1; i < len / 2; i++, j--)
	{
		char temp;
	    temp = myArray[i];
		myArray[i] = myArray[j];
		myArray[j] = temp;

		
	}
}


int CountEven(int *array, int array_len)
{
	int count = 0;

	for (int i = 0; i < array_len; i++)
	{
		int *ptr = &array[i];
		if ((*ptr % 2) == 0)
		{
			count++;
	    }
		
    }
	

	return count;
}

double Maximum(double* array, int array_size)
{

	double *ptr = array;

	for (int i = 0; i < array_size; ++i)
	{
	
		if (array[i] < array[i + 1])
		{
			*ptr = array[i + 1];

		}

	}

	if (array == 0)
	{

		ptr = nullptr;
		
	}

	return *ptr;
}

bool Contains(char* array, char search_value)
{
	bool bFound = true;

	
	for (int i = 0; i < 4; ++i)
		{
			char *ptr = &array[i];

			if (*ptr == search_value)
			{
				
				bFound == true;
				std::cout << "Found It: " << *ptr << std::endl;
				
				return bFound;
			}
			

		}

	
		bFound == false;
		std::cout << "Its not here!\n";

	return bFound;
}


//Exercise 6
int main()
{

	
	/*Write a function for each of the following descriptions.For each function, use the pointer
		notation ONLY.Do NOT use the array index[] notation.
		A.Write a function RevString(char* array) which reverses array.The function
		returns nothing.
		B.Write a function CountEven(int* array, int array_len) which receives an
		integer array and its size, and returns the number of even numbers in the array.
		C.Write a function Maximum(double* array, int array_size) that returns a
		pointer to the maximum value of an array of doubles.If the array is empty, return
		nullptr.
		D.Write a function Contains(char* array, char search_value) which returns
		true if the 1st parameter contains the 2nd parameter, or false otherwise*/


	char myArray[100] = {'a','b','c','d'};
	RevString(myArray); 
	std::cout << myArray << std::endl;

		int iArray[4] = { 1, 2, 3, 4 };
		std::cout << CountEven(iArray, 4);
		std::cout << std::endl;

		double dArray[4] = { 32.0, 200.0, 201.0, 33.0 };
		std::cout << Maximum(dArray, 4);
		std::cout << std::endl;

	char search_value = 'd';
	Contains(myArray, search_value);

	





	system("PAUSE");
	return 0;
}