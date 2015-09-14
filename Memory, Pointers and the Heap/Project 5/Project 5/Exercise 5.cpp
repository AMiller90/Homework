

#include<iostream>

//Exercise 5
int main()
{

	/*Look at the following code.Give the value of the left - hand side variable in each assignment
		statement.Assume the lines are executed sequentially.Assume the address of the blocks
		array is 4434.*/


	char blocks[3] = { 'A','B','C' };
	char* ptr = &blocks[0];
	char temp;

	Answers:
	//temp = blocks[0]; // 'A'
	//temp = *(blocks + 2); // 'C'
	//temp = *(ptr + 1);// 'B'
	//temp = *ptr //'A'
	//ptr = blocks + 1; // BC and garbage?
	//temp = *ptr // 'A'
	//temp = *(ptr + 1) // 'B'
	//ptr = blocks // ABC then garbage?
	//temp = *++ptr; //B
	//temp = ++*ptr; //B
	//temp = *ptr++; //A ?
	//temp = *ptr; //A

	std::cout << temp;



	system("PAUSE");
	return 0;

}