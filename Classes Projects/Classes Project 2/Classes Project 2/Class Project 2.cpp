
//includes the header file in order for this .cpp file to know what class this data belongs too
#include "Class Project 2.h"

Circle::Circle()
{




}

//Sets Radius
void Circle::setRadius(double r)
{
	//set radius
	_radius = r;
	r = _radius;

	std::cout << "The Radius You Want Is: " << r << std::endl;
}

//Returns Radius
double Circle::getRadius()
{
	double r;
	std::cout << "Enter a number for the radius of a circle:" << std::endl;
	std::cin >> r;
	return r;
	


}

//Gets Radius
double Circle::getArea(double r)
{
	double a;
	//Area = Pi x The Radius Squared
	a = 3.14f * (r * r);
	return a;

}

//Get Diameter
double Circle::getDiameter(double r)
{
	double d;
	//Diameter = Radius x 2
	d = r * 2.0f;
	return d;
}

//Get Circumference
double Circle::getCircumference(double r)
{
	double c;
	//Circumference = 2 x pi x radius
	c = 2.0f * 3.14f * r;

	return c;
}