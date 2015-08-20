#pragma once

#include<iostream>




int main () {
//Problem 6

	
int a;
int b;
char Operator;

//Prompts user to enter 2 numbers and a math operator
std::cout << "Please Enter 2 Numbers And Then A Math Operator: " << std::endl;
std::cin >> a;
std::cin >> b;
std::cin >> Operator;

//sets each answer variable for the operations
int answer1 = a / b;
int answer2 = a * b;
int answer3 = a + b;
int answer4 = a - b;
int answer5 = a % b;

//Performs operations based on which operator variable is being used
switch (Operator) {
//Division
case '/':

std::cout << a << " / " << b << " is: " << answer1 << std::endl;
break;

//Multiplication
case '*':
std::cout << a << " * " << b << " is: " << answer2 << std::endl;
break;

//Addition
case '+':
std::cout << a << " + " << b << " is: " << answer3 << std::endl;
break;

//Subtraction
case '-':
std::cout << a << " - " << b << " is: " << answer4 << std::endl;
break;

//Modelo
case '%':
std::cout << a << " % " << b << " is: " << answer5 << std::endl;
break;

default:
	std::cout << "Oops that does not work" << std::endl;
break;
}


system("PAUSE");
return 0;
}
