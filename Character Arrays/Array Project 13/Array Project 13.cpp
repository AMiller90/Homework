#pragma once

#include<iostream>


int main() {


	std::cout << "Please Enter A Date: mm/dd/yyyy" << std::endl;
	char date[15];


	std::cin.getline(date, 15);

	//std::cout << date;
	
	int month;
	int day, year;

	std::cout << month << " " << day << "," << year;

	switch (month) {

	case '01':
		std::cout << "January";
		break;

	case '02':
		std::cout << "February";
		break;

	case '03':
		std::cout << "March";
		break;

	case '04':
		std::cout << "April";
		break;

	case '05':
		std::cout << "May";
		break;

	case '06':
		std::cout << "June";
		break;

	case '07':
		std::cout << "July";
		break;

	case '08':
		std::cout << "August";
		break;


	case '09':
		std::cout << "September";
		break;


	case '10':
		std::cout << "October";
		break;


	case '11':
		std::cout << "November";
		break;

	case '12':
		std::cout << "December";
		break;

	default:
		break;

	}
	system("PAUSE");
	return 0;
}