//09/26/16
//Question 1: Distance from a Rectangle
//We expect this question to take approximately 20 - 40 minutes.
//Write a function that tests if a point falls within a specified distance(“dist”) of any part of a solid, 2D rectangle.The rectangle is specified by the bottom left corner, a width, and a height.
//A function prototype and data structures you can assume exist are supplied below.You may make additions to the structures if you deem it appropriate.If you answer in a different language, you should follow a similar format :
#include<iostream>
struct Point
{
	float x;
	float y;
};
struct Rectangle
{
	Point bottomLeft;
	float width;
	float height;
};
bool IsPointWithinDistOfRectangle(const Rectangle& rect, const Point& point, float dist)
{
	int xdist;
	int ydist;

	//Calculate distance between points
	xdist = point.x - rect.bottomLeft.x;
	ydist = point.y - rect.bottomLeft.y;

	//Squarte each point
	xdist *= xdist;
	ydist *= ydist;

	//Add them together
	float sum = xdist + ydist;
	//Square root the sum to get the "magnitude"
	float direction = sqrtf(sum);

	//If the direction is less than or equal to the dist
	if (direction <= dist)
		return true;
	else
		return false;

	////Get the distance between the width of the rectangle and point.x
	//xdist = rect.width - point.x;
	////Get the distance between the height of the rectangle and point.y
	//ydist = rect.height - point.y;

	////Check if the dist variable is greater than the width and the height
	////If its true, then the dist is checking outside the dimensions of the rectangle
	//if (dist > rect.width && dist > rect.height)
	//	return false;

	////If both numbers are less than or equal to the distance variable then the point resides with the rectangle
	//if (xdist <= dist && ydist <= dist)
	//	return true;
	//else
	//	return false;

}


int main()
{
	Rectangle a;
	a.bottomLeft.x = 10;
	a.bottomLeft.y = 10;
	a.height = 30;
	a.width = 20;

	Point p;
	p.x = 10;
	p.y = 10;

	std::cout << IsPointWithinDistOfRectangle(a, p, 0);



	int tmp;
	std::cin >> tmp;

	return 0;

}