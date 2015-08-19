#pragma once

#include<iostream>




int main() {

	//Problem 1
	/*int x;
	int y;

	std::cin >> y;

	//Problem 1.
	if (y == 0) {

	x = 100;

	std::cout << x << std:: endl;
	}*/



	//Problem 2.
	/*std::cout << "Please Enter 2 Numbers: " << std::endl;
	int a;
	int b;
	std::cin >> a;
	std::cin >> b;

	if (a > b) {

	std::cout << "The First Number..." << a << "..Is Bigger" << std::endl;

	}
	else if (a < b) {

	std::cout << "The Second Number..." << b << "..Is Bigger" << std::endl;

	}
	else if (a = b) {

	std::cout << "Both Numbers " << a << " And " << b << " Are Equal"<< std::endl;
	}*/



	//Problem 3 
	int a, b, c, d, e;



	std::cin >> a;
	std::cin >> b;
	std::cin >> c;
	std::cin >> d;
	std::cin >> e;

	int sum = a + b + c + d + e;

	if (sum > 0) {

		if ((a < b && a < c && a < d && a < e) &&
			(b < c && b < d && b < e && b > a) &&
			(c < d && c < e && c > a && c > b) &&
			(d < e && d > a && d > b && d > c) &&
			(e > a && e > b && e > c && e > d)){
			std::cout << a << std::endl;
			std::cout << b << std::endl;
			std::cout << c << std::endl;
			std::cout << d << std::endl;
			std::cout << e << std::endl;
		}
		if ((b < c && b < d && b < e && b < a) &&
			(c < d && c < e && c < a && c > b) &&
			(d < e && d < a && d > b && d > c) &&
			(e < a && e > b && e > c && e > d) &&
			(a > b && a > c && a > d && a > e)){
			std::cout << b << std::endl;
			std::cout << c << std::endl;
			std::cout << d << std::endl;
			std::cout << e << std::endl;
			std::cout << a << std::endl;
		}
		if ((c < d && c < e && c < a && c < b) &&
			(d < e && d < a && d < b && d > c) &&
			(e < a && e < b && e > c && e > d) &&
			(a < b && a > d && a > e && a > c) &&
			(b > c && b > d && b > e && b > a)){
			std::cout << c << std::endl;
			std::cout << d << std::endl;
			std::cout << e << std::endl;
			std::cout << a << std::endl;
			std::cout << b << std::endl;
		}
		if ((d < e && d < a && d < b && d < c) &&
			(e < a && e < b && e < c && e > d) &&
			(a < b && a < c && a > d && a > e) &&
			(b < c && b > e && b > a && b > d) &&
			(c > d && c > a && c > b && c > e)){
			std::cout << d << std::endl;
			std::cout << e << std::endl;
			std::cout << a << std::endl;
			std::cout << b << std::endl;
			std::cout << c << std::endl;
		}

		if ((e < a && e < b && e < c && e < d) &&
			(a < b && a < c && a < d && a > e) &&
			(b < c && b < d && b > a && b > e) &&
			(c < d && c > e && c > a && c > b) &&
			(d > e && d > a && d > b && d > c)){
			std::cout << e << std::endl;
			std::cout << a << std::endl;
			std::cout << b << std::endl;
			std::cout << c << std::endl;
			std::cout << d << std::endl;

		}
	}
		  if (sum < 0) {


			  if ((a < b && a < c && a < d && a < e) &&
				 (b < c && b < d && b < e && b > a) &&
				 (c < d && c < e && c > a && c > b) &&
				 (d < e && d > a && d > b && d > c) &&
				 (e > a && e > b && e > c && e > d)){
				 std::cout << a << std::endl;
				 std::cout << b << std::endl;
				 std::cout << c << std::endl;
				 std::cout << d << std::endl;
				 std::cout << e << std::endl;
			 }
			 if ((b < c && b < d && b < e && b < a) &&
				 (c < d && c < e && c < a && c > b) &&
				 (d < e && d < a && d > b && d > c) &&
				 (e < a && e > b && e > c && e > d) &&
				 (a > b && a > c && a > d && a > e)){
				 std::cout << b << std::endl;
				 std::cout << c << std::endl;
				 std::cout << d << std::endl;
				 std::cout << e << std::endl;
				 std::cout << a << std::endl;
			 }
			 if ((c < d && c < e && c < a && c < b) &&
				 (d < e && d < a && d < b && d > c) &&
				 (e < a && e < b && e > c && e > d) &&
				 (a < b && a > d && a > e && a > c) &&
				 (b > c && b > d && b > e && b > a)){
				 std::cout << c << std::endl;
				 std::cout << d << std::endl;
				 std::cout << e << std::endl;
				 std::cout << a << std::endl;
				 std::cout << b << std::endl;
			 }
			 if ((d < e && d < a && d < b && d < c) &&
				 (e < a && e < b && e < c && e > d) &&
				 (a < b && a < c && a > d && a > e) &&
				 (b < c && b > e && b > a && b > d) &&
				 (c > d && c > a && c > b && c > e)){
				 std::cout << d << std::endl;
				 std::cout << e << std::endl;
				 std::cout << a << std::endl;
				 std::cout << b << std::endl;
				 std::cout << c << std::endl;
			 }

			 if ((e < a && e < b && e < c && e < d) &&
				 (a < b && a < c && a < d && a > e) &&
				 (b < c && b < d && b > a && b > e) &&
				 (c < d && c > e && c > a && c > b) &&
				 (d > e && d > a && d > b && d > c)){
				 std::cout << e << std::endl;
				 std::cout << a << std::endl;
				 std::cout << b << std::endl;
				 std::cout << c << std::endl;
				 std::cout << d << std::endl;

			 }

		 }else if (sum == 0) {

	std::cout << a << b << c << d << e;

}



	/*else if (sum < 0) {

		if (a > b && a > c && a > d && a > e) {
		std::cout << a;
		} if (b > a && b > c && b > d && b > e) {
		std::cout << b;
		} if (c > a && c > b && c > d && c > e) {
		std::cout << c;
		} if (d > a && d > b && d > c && d > e) {
		std::cout << d;
		} if (e > a && e > b && e > c && e > d) {
		std::cout << e;
		}

		std::cout << a << b << c << d << e;

		}
		else if (sum == 0) {

		std::cout << a << b << c << d << e;

		}*/


	//Problem 4 

	/*int choice;

std::cout << "Please Enter a Number Between 1 - 4: " << std::endl;
std::cin >> choice;

switch (choice) {

case 1:
std::cout << "1" << std::endl;
break;

case 2:
std::cout << "2" << std::endl;
break;

case 3:
std::cout << "3" << std::endl;
break;

case 4:
std::cout << "4" << std::endl;
break;

default:
std::cout << "Invalid" << std::endl;


}*/


	//Problem 5
	/* int x;
	 int y;
	 std::cin >> x;

	 (x == 0) ? (y = 0) : (y = 10 / x);


	 std::cout << y;*/





	//Problem 6
	/*int a;
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
	}*/



	//Problem 7

	/*int Month;
	int Days;

	std::cout << "Please Enter The Month from 1 - 12 To See The Number Of Days In That Month: " << std::endl;

	std::cin >> Month;

	switch (Month) {

	case 1:

	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;

	case 2:
	std::cout << "Month " << Month << " Has 28 Days" << std::endl;
	break;

	case 3:
	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;

	case 4:
	std::cout << "Month " << Month << " Has 30 Days" << std::endl;
	break;


	case 5:
	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;


	case 6:
	std::cout << "Month " << Month << " Has 30 Days" << std::endl;
	break;

	case 7:
	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;

	case 8:
	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;

	case 9:
	std::cout << "Month " << Month << " Has 30 Days" << std::endl;
	break;

	case 10:
	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;

	case 11:
	std::cout << "Month " << Month << " Has 30 Days" << std::endl;
	break;


	case 12:
	std::cout << "Month " << Month << " Has 31 Days" << std::endl;
	break;

	default:
	std::cout << "ERROR: Invalid Input" << std::endl;
	break;
	}*/


	//Problem 8 
	/* A.True
	 B.True
	 C.True
	 D.True
	 E.True
	 F.False
	 G.True
	 H.True
	 I.False
	 J.True */



	//Problem 9
	/* A.Answer is 1 or True
	 B.Answer is 0 or False
	 C.Answer is 0 or False
	 D.Answer is 1 or True
	 E.Answer is 0 or False*/




	system("PAUSE");
	return 0;
}
