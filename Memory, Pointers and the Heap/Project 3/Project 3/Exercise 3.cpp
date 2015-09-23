

#include<iostream>

//Exercise 3
int main()
{
	int *p;
	int i;
	int k;
	i = 42;
	k = i;
	p = &i;

	//Question 3.After these statements, which of the following statements will change the value of i to 75 ?*/
	k = 75; //This will not work
	*k = 75;//This will not work
	p = 75; //This will not work
    *p = 75;//This Will Work!!
	Two or more of the answers will change i to 75. //This is not correct


	system("PAUSE");
	return 0;

}