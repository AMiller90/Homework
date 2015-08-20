#pragma once

#include <iostream>





int main () {

	
	//Problem 5

	//declare variables and get input from user
	int x;
    int y;
    std::cin >> x;

	//Tertiary Statement
	//(x==0) is the condition being compared to the users input and ? is The Teritary Operator.
	//if the condtion is true then (y = 0) is the result...if the condition is false then (y = 10 / x) is the result
     (x == 0) ? (y = 0) : (y = 10 / x);

	 //printout answer
     std::cout << y;



      system("PAUSE");
      return 0;
}

