#include<iostream>
#include "Vector.h"


//Assignment : Math...
//	1. Create a templated class that supports 2D Vector addition and subtraction.
//	2. Add support for 3D vectors.
//	3. Add support for magnitude of a vector.
//	4. Add support for normalizing a vector.
//	5. Add support for dot and cross product. (you have not learned this yet)

int main()
{
	Vector3<int> Vec1(1,1,1);
	Vector3<int> Vec2(2,2,2);
	Vector3<int> Vec3;
	Vector3<int> Vec4;
	Vec4 = Vec3.Add(Vec1, Vec2);
	std::cout << "(" << Vec4.x << "," <<  Vec4.y << "," << Vec4.z << ")\n";
	Vec4 = Vec3.Sub(Vec1, Vec2);
	std::cout << "(" << Vec4.x << "," << Vec4.y << "," << Vec4.z << ")\n";
	Vec4 = Vec3.Multiply(Vec1, Vec2);
	std::cout << "(" << Vec4.x << "," << Vec4.y << "," << Vec4.z << ")\n";
	Vec3.Mag(Vec1, Vec2);
	//Vec3.Normalise(Vec1, Vec2);
	




	system("Pause");
	return 0;
}