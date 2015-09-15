

#include<iostream>


using namespace std;

//Exercise 1
int main()

{
	/*Look at the following definitions and initializations:*/
	char c = 'T', d = 'S';
	char *p1 = &c;
	char *p2 = &d;
	char *p3;


	/*If the address of c is 6940, the address of d is 9772, and the address of e is 2224. What will
		be printed when the following statements are executed sequentially ?*/



	p3 = &d; 
	cout << "*p3 = " << *p3 << endl; // (1)
	p3 = p1; 
	cout << "*p3 = " << *p3; // (2)
	
	cout << ", p3 = " << p3 << endl; // (3)

	*p1 = *p2; 
	cout << "*p1 = " << *p1; // (4)
	
	cout << ", p1 = " << p1 << endl; // (5)
/*
	Answers:
	1.S
	2.T
	3.T
	4.S
	5.S*/



	system("PAUSE");
	return 0;

}