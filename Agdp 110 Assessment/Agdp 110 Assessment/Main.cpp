#include "Vector2.h"
#include "Vector3.h"


#include <iostream>



int main()
{
	Vector2<int> vec2(12,24);
	Vector2<int> vec3(12,24);
	Vector2<int> storage;

	storage = vec3 + vec2;
	
	std::cout << "Add:" << "(" << storage.x << "," << storage.y << ")\n" << std::endl;

	storage = vec3 - vec2;

	std::cout << "Subtract:" << "(" << storage.x << "," << storage.y << ")\n" << std::endl;

	Vector3<int> vec1(12, 12, 12);
	Vector3<int> vec4(12, 12, 12);
	Vector3<int> storage2;
	
	storage2 = vec1 / vec4;

	std::cout << "Divide:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")\n" << std::endl; 

	storage2 = vec1 * vec4;

	std::cout << "Multiply:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")\n" << std::endl;

	system("PAUSE");
	return 0;

}