#include <iostream>


unsigned int multiply(unsigned int num1, unsigned int num2)
{
	unsigned int answer = 0;

	//As long as i is not equal to 0
	for (int i = num2; i != 0; i--)
	{//Add the passed in first parameter to the current answer variable
		answer += num1;
	}
	//Check if either number is 0..if true then set answer to 0 
	if (num1 == 0 || num2 == 0)
		answer = 0;

	//Return the result
	return answer;
}

unsigned int multi(unsigned int num1, unsigned int num2)
{
	if (num2 == 0)
		return num2;

	if (num2 == 1)
		return num1;

	//Return the result
	return num1 + multi(num1, num2 - 1);
}

int main()
{

	std::cout << multiply(10,12);

	int tmp;
	std::cin >> tmp;
	return 0;
}