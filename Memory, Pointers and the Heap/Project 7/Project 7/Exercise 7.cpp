
#include<iostream>

using namespace std;

//Exercise 7
int main()
{


	//Question 7.Predict the output of the following program.Run the program to see if your prediction is
	//right.

	//Answer: program will not compile
	int * ptr_a, ptr_b, *ptr_c;

	ptr_a = new int;
	*ptr_a = 3;
	ptr_b = ptr_a;
	cout << *ptr_a << " " << *ptr_b << "\n";

	ptr_b = new int;
	*ptr_b = 9;
	cout << *ptr_a << " " << *ptr_b << "\n";

	*ptr_b = *ptr_a;
	cout << *ptr_a << " " << *ptr_b << "\n";

	delete ptr_a;
	ptr_a = ptr_b;
	cout << *ptr_a << " " << *&*&*&*&*ptr_b << "\n";

	ptr_c = &ptr_a;
	cout << *ptr_c << " " << **ptr_c << "\n";

	delete ptr_a;
	ptr_a = NULL;
	





	system("PAUSE");
	return 0;
}