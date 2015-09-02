#pragma once

#include<iostream>



class Circle {


public:
	
	Circle();


	//sets up all function decalarations
	void setRadius(double r);
	double getRadius();
	double getArea(double r);
	double getDiameter(double r);
	double getCircumference(double r);

private:

	//Private Variables
	double _radius;


};

