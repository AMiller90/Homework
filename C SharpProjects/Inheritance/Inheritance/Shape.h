#ifndef _SHAPE_H_
#define _SHAPE_H_


#include<string>
#include<iostream>

using namespace std;

template<typename T>
struct Vector3
{

public:
	T X, Y, Z;

}; 

class Shape
{

public:

	Shape();
	~Shape();

	void Draw();
	void Move(Vector3<float> Pos);

private:


protected:

	int Sides;
	string Tag;
	Vector3<float> Pos;





};

#endif 