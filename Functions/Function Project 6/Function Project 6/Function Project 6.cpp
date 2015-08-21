#pragma once

#include<iostream>


int main() {

	
	//Problemm 6
	The Error In This function Is That It Has No return Value
	In order to fix the problem youll need to retunr and integer value or change function type to void
	//int sum (int x, int y)
	/*{
		int result;
		result = x + y;
	}*/

	The Error in this function is that it doesnt return on the else statement.It should return n; 
	/*int sum(int n)
	{
		if (0 == n)
			return 0;
		else
			n = n + n;
	}*/

	The Error In This Problem Is That The function declaration was made AFTER The Main function. In order for main to recognize a called
	function it must be declared before the main function.
	/*double x = 13.6;
	std::cout << "Square of 13.6 = " << square(x) << std::endl;

	int square(int x) {

		return x * x;
	}*/

	system("PAUSE");
	return 0;
}

