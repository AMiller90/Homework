
//includes the header file in order for this .cpp file to know what class this data belongs too
#include "Class Project 1.h"

//Uses constructor to set variables
Date::Date(int d, int m, int y)
{

	 day = d;
	 month = m;
	 year = y;


}

//Prints The Data
void Date::printDate()
{


	std::cout << "Month: " << month << " Day: " << day << " Year: " << year << std::endl;


}

