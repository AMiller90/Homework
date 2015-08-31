#pragma once

#include<iostream>

#include "Class Project 2.h"

int main()
{


	Circle circle;

	double r = circle.getRadius();
	circle.setRadius(r);
	double a = circle.getArea(r);
	double c = circle.getCircumference(r);
	double d = circle.getDiameter(r);


	
	std::cout << "The Area Is: " << a << std::endl;
	std::cout << "The Circumference Is: " << c << std::endl;
	std::cout << "The Diameter Is: " << d << std::endl;


	system("PAUSE");
	return 0;
}