#pragma once

#include<iostream>
//includes the header file in order for this .cpp file to know what class the data belongs too
#include "Class Project 2.h"


//Problem 2
/*Create a class declaration named Circle with a private member variable names radius.
a.Write set and get functions to access the radius variable
b.Write a getArea function that returns the area of the circle
c.Write a getDiamater function that returns the diameter of the circle
d.Write a getCircumference functions that returns the circumference of the circle*/
int main()
{


	Circle circle;

	//Function Calls
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