#include "Class Project 1.h"


Date::Date(int d, int m, int y)
{

	 day = d;
	 month = m;
	 year = y;


}


void Date::printDate()
{


	std::cout << "Month: " << month << " Day: " << day << " Year: " << year << std::endl;


}

