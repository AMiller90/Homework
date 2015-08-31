#include "Class Project 2.h"

Circle::Circle()
{




}

void Circle::setRadius(double r)
{
	//set radius
	_radius = r;
	r = _radius;

	std::cout << "The Radius You Want Is: " << r << std::endl;
}


double Circle::getRadius()
{
	double r;
	std::cout << "Enter a number for the radius of a circle:" << std::endl;
	std::cin >> r;
	return r;
	


}


double Circle::getArea(double r)
{
	double a;
	//Area = Pi x The Radius Squared
	a = 3.14f * (r * r);
	return a;

}


double Circle::getDiameter(double r)
{
	double d;
	//Diameter = Radius x 2
	d = r * 2.0f;
	return d;
}


double Circle::getCircumference(double r)
{
	double c;
	//Circumference = 2 x pi x radius
	c = 2.0f * 3.14f * r;

	return c;
}