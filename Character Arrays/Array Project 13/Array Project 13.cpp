#pragma once

#include<iostream>


int main() {


	std::cout << "Please Enter A Date: mm/dd/yyyy" << std::endl;
	char date[12];

	std::cin.getline(date, 12);


	char month[2];
	char day[2];
	char year[4];

	month[0] = date[0];
	month[1] = date[1];

	day[0] = date[3];
	day[1] = date[4];

	year[0] = date[6];
	year[1] = date[7];
	year[2] = date[8];
	year[3] = date[9];


	std::cout << std::endl;
	for (int i = 0; i < month[i]; i++)
	{
		
		if ((month[i] == '0') && (month[i + 1] == '1'))
		{
			std::cout << "January";
		}
		
		if ((month[i] == '0') && (month[i + 1] == '2'))
		{
			std::cout << "February";
		}

		if ((month[i] == '0') && (month[i + 1] == '3'))
		{
			std::cout << "March";
		}

		if ((month[i] == '0') && (month[i + 1] == '4'))
		{
			std::cout << "April";
		}

		if ((month[i] == '0') && (month[i + 1] == '5'))
		{
			std::cout << "May";
		}

		if ((month[i] == '0') && (month[i + 1] == '6'))
		{
			std::cout << "June";
		}

		if ((month[i] == '0') && (month[i + 1] == '7'))
		{
			std::cout << "July";
		}

		if ((month[i] == '0') && (month[i + 1] == '8'))
		{
			std::cout << "August";
		}

		if ((month[i] == '0') && (month[i + 1] == '9'))
		{
			std::cout << "September";
		}

		if ((month[i] == '1') && (month[i + 1] == '0'))
		{
			std::cout << "October";
		}

		if ((month[i] == '1') && (month[i + 1] == '1'))
		{
			std::cout << "November";
		}

		if ((month[i] == '1') && (month[i + 1] == '2'))
		{
			std::cout << "December";
		}

	}




		std::cout << " ";

		for (int i = 0; i < day[i]; i++)
		{
			std::cout << day[i];
		}

		std::cout << ",";

		for (int i = 0; i < year[i]; i++)
		{
			std::cout << year[i];
		}

		std::cout << std::endl;




		system("PAUSE");
		return 0;
	
}

//
//
//switch ((char)month) {
//
//case '01':
//	std::cout << "January";
//	break;
//
//case '02':
//	std::cout << "February";
//	break;
//
//case '03':
//	std::cout << "March";
//	break;
//
//case '04':
//	std::cout << "April";
//	break;
//
//case '05':
//	std::cout << "May";
//	break;
//
//case '06':
//	std::cout << "June";
//	break;
//
//case '07':
//	std::cout << "July";
//	break;
//
//case '08':
//	std::cout << "August";
//	break;
//
//
//case '09':
//	std::cout << "September";
//	break;
//
//
//case '10':
//	std::cout << "October";
//	break;
//
//
//case '11':
//	std::cout << "November";
//	break;
//
//case '12':
//	std::cout << "December";
//	break;
//
//default:
//	break;
//
//}