#pragma once

#include<iostream>



class Circle {


public:
	
	Circle();



	void setRadius(double r);
	double getRadius();
	double getArea(double r);
	double getDiameter(double r);
	double getCircumference(double r);

private:

	double _radius;


};

