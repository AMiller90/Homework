#include "Vector2.h"
#include "Vector3.h"

#include <iostream>



int main()
{

	Vector2<int> vec2(12,24);
	Vector2<int> vec3(12,24);
	Vector2<int> storage;

	storage = vec3 + vec2;


	std::cout << "(" << storage.x << "," << storage.y << ")" << std::endl;


	system("PAUSE");
	return 0;

}