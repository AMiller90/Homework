#include<iostream>
#include<vector>

//08/31/16 
//1. create a function to calculate a prime number(show on paper or in comments what you think a prime number is. do not google it...)
//2. write a function that uses that function to find all prime numbers under 100.
//3. write a function that determines if a number is a multiple of another number.
//4. use your functions together to find all prime numbers below 1000.
// A Prime number is a number that is only divisible by 1 and itself evenly

bool CalculateThePrime(int num)
{
	std::vector<int> nums;
	//Countdown from passed in number all the way to 2
	for (int i = num; i > 1; i--)
	{//If the passed in number modulo the current i is equal to 0
		if (num % i == 0)
		{//Add to vector
			nums.push_back(i);
		}
	}

	//Check if the size is 1, if it is, then the only number in the vector will be the passed in number - so it is prime
	if (nums.size() == 1)
	{
		return true;
	}
	//More than one number is inside the vector so it is not a prime number
	return false;
}

//Check if the number is a multiple
bool IsMultiple(int num , int multiof)
{
	return (multiof % num == 0) ? true : false;
}

//Function that runs both other functions
void CheckForPrimeAndMultiple()
{
	for (int i = 1; i <= 1000; i++)
	{
		if (CalculateThePrime(i) && IsMultiple(i, 1000))
			std::cout << i << " ,";
	}
}


int main()
{

	
	CheckForPrimeAndMultiple();

	int tmp;
	std::cin >> tmp;

	return 0;

}
