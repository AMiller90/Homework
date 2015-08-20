#pragma once

#include<iostream>




int main () {
//Problem 6

	
	int a;
int b;
char Operator;

std::cout << "Please Enter 2 Numbers And Then A Math Operator: " << std::endl;
std::cin >> a;
std::cin >> b;
std::cin >> Operator;

int answer1 = a / b;
int answer2 = a * b;
int answer3 = a + b;
int answer4 = a - b;
int answer5 = a % b;

switch (Operator) {

case '/':

std::cout << a << " / " << b << " is: " << answer1 << std::endl;
break;

case '*':
std::cout << a << " * " << b << " is: " << answer2 << std::endl;
break;

case '+':
std::cout << a << " + " << b << " is: " << answer3 << std::endl;
break;

case '-':
std::cout << a << " - " << b << " is: " << answer4 << std::endl;
break;

case '%':
std::cout << a << " % " << b << " is: " << answer5 << std::endl;
break;

default:
break;
}


system("PAUSE");
return 0;
}
