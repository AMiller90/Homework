#include<iostream>

using namespace std;

template<typename T>
T Min(T a, T b)
{
	if (a < b)
	{
		return a;
	}
	else if (b < a)
	{
		return b;
	}
}

template<typename T>
T Max(T a, T b)
{
	if (a > b)
	{
		return a;
	}
	else if (b > a)
	{
		return b;
	}
}

template<typename T>
T Clamp(T min, T max, T val)
{
	if (val < min)
	{
		return min;
	}
	else if (val > min && val < max)
	{
		return val;
	}
	else
	{
		return max;
	}


}

template<typename T>
T CMin(T a, T b)
{
	if (a < b)
	{
		return a;
	}
	else if (b < a)
	{
		return b;
	}
}

template<typename T>
T CMax(T a, T b)
{
	if (a > b)
	{
		return a;
	}
	else if (b > a)
	{
		return b;
	}

}

//Exercise 1:
//Create the following template functions :
//	1. Min
//	DESCRIPTION : Returns the lower of two values.
//	INPUT : Two template arguments(a, b).
//	OUTPUT : The lower of the two values a and b.
//	2. Max
//	DESCRIPTION : Returns the higher of two values.
//	INPUT : Two template arguments(a, b).
//	OUTPUT : The higher of the two values a and b.
//	3. Clamp
//	DESCRIPTION : Constrains a value within the range of two other values.
//	INPUT : Three template arguments(min, max, val).
//	OUTPUT : The value of the val constrained between min and max.
//	4. Min(specialised for char)
//	DESCRIPTION : As above but first checks if a and b represent alphabetical characters.If so,
//	the function will return the value that is alphabetically lower.
//	INPUT : Two template arguments(a, b).
//	OUTPUT : The alphabetically lower of the two values a and b.
//	5. Max(specialised for char)
//	DESCRIPTION : As above but first checks if a and b represent alphabetical characters.If so,
//	the function will return the value that is alphabetically higher.
//	INPUT : Two template arguments(a, b).
//	OUTPUT : The alphabetically higher of the two values a and b.

int main()
{
	
	/*1.)int a = Min(3, 4);
	cout << a;*/

	/*2.)int b = Max(2, 4);
	cout << b;*/

	/*3.)int c = Clamp(9, 10, 8);
	cout << c;*/
	
	/*4.)char a = CMin<char>('Z', 'A');
	cout << a;*/

    /*4.)char b = CMax<char>('B', 'A');
	cout << b;*/



	system("PAUSE");
	return 0;
}