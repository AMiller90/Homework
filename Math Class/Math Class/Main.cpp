#include<iostream>
#include "Vector3.h"
#include "Vector2.h"

//Assignment : Math...
//	1. Create a templated class that supports 2D Vector addition and subtraction.
//	2. Add support for 3D vectors.
//	3. Add support for magnitude of a vector.
//	4. Add support for normalizing a vector.
//	5. Add support for dot and cross product. (you have not learned this yet)

int main()
{
	std::cout << "Vec2: \n";
	//Variable for holding Magnitude
	float Mag;
	//Variable for holding dot product
	int Dot;
	//Vec2 objects
	Vector2<int>TwoDVec1(3, 3);
	Vector2<int>TwoDVec2(1, 1);
	Vector2<int>TwoDVec3;
	Vector2<int>TwoDVec4;

	//Add Vectors
	TwoDVec4 = TwoDVec3.Add(TwoDVec1, TwoDVec2);
	std::cout << "(" << TwoDVec4.x << "," << TwoDVec4.y << ")\n";
	//Subtract Vectors
	TwoDVec4 = TwoDVec3.Sub(TwoDVec1, TwoDVec2);
	std::cout << "(" << TwoDVec4.x << "," << TwoDVec4.y << ")\n";
	//Multiply Vectors
	TwoDVec4 = TwoDVec3.Multiply(TwoDVec1, TwoDVec2);
	std::cout << "(" << TwoDVec4.x << "," << TwoDVec4.y << ")\n";
	//Magnitude of Vector
	Mag = TwoDVec3.Mag(TwoDVec1);
	std::cout << "Magnitude is: " << Mag << std::endl;
	//Magnitude of Vector
	Mag = TwoDVec3.Mag(TwoDVec2);
	std::cout << "Magnitude is: " << Mag << std::endl;
	//Normalise Vector
	TwoDVec4 = TwoDVec3.Normalise(TwoDVec1);
	std::cout << "(" << TwoDVec4.x << "," << TwoDVec4.y << ")\n";
	//Dot Product
	Dot = TwoDVec3.Dot(TwoDVec1, TwoDVec2);
	std::cout << "Dot Product is: " << Dot << std::endl;

	std::cout << "\nVec3: \n";
	//Vec3 objects
	Vector3<int> Vec1(5,6,7);
	Vector3<int> Vec2(2,2,2);
	Vector3<int> Vec3;
	Vector3<int> Vec4;

	//Add Vectors
	Vec4 = Vec3.Add(Vec1, Vec2);
	std::cout << "(" << Vec4.x << "," <<  Vec4.y << "," << Vec4.z << ")\n";
	//Subtract Vectors
	Vec4 = Vec3.Sub(Vec1, Vec2);
	std::cout << "(" << Vec4.x << "," << Vec4.y << "," << Vec4.z << ")\n";
	//Multiply Vectors
	Vec4 = Vec3.Multiply(Vec1, Vec2);
	std::cout << "(" << Vec4.x << "," << Vec4.y << "," << Vec4.z << ")\n";
	//Magnitude of Vector
	Mag = Vec3.Mag(Vec1);
	std::cout << "Magnitude is: " << Mag << std::endl;
	//Magnitude of Vector
	Mag = Vec3.Mag(Vec2);
	std::cout << "Magnitude is: " << Mag << std::endl;
	//Normalise Vector
	Vec4 = Vec3.Normalise(Vec1);
	std::cout << "(" << Vec4.x << "," << Vec4.y << "," << Vec4.z << ")\n";
	Dot = Vec3.Dot(Vec1, Vec2);
	std::cout << "Dot Product is: " << Dot << std::endl;
	Vec4 = Vec3.Cross(Vec1, Vec2);
	std::cout << "Cross Product is: " << "(" <<  Vec4.x << "," << Vec4.y << "," << Vec4.z << ")" << "\n";


	system("Pause");
	return 0;
}