#include "Vector2.h"
#include "Vector3.h"


#include <iostream>



int main()
{
	Vector2<int> vec2(12,24);
	Vector2<int> vec3(12,24);
	Vector2<int> storage;

	std::cout << "Vector2: \n\n";

	storage = vec3 + vec2;
	
	std::cout << "Add:" << "(" << storage.x << "," << storage.y << ")\n" << std::endl;

	storage = vec3 - vec2;

	std::cout << "Subtract:" << "(" << storage.x << "," << storage.y << ")\n" << std::endl;

	Vector3<float> vec1(12.0, 12.0, 12.0);
	Vector3<float> vec4(12.0, 12.0, 12.0);
	Vector3<float> storage2;
	
	std::cout << "Vector3: \n\n";

	storage2 = vec1 + vec4;

	std::cout << "Add:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")\n" << std::endl;

	storage2 = vec1 - vec4;

	std::cout << "Subtract:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")\n" << std::endl;

	storage2 = vec1 / vec4;

	std::cout << "Divide:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")\n" << std::endl; 

	storage2 = vec1 * vec4;

	std::cout << "Multiply:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")\n" << std::endl;

	storage2 = vec1 % vec4;

	std::cout << "Modulus:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")\n" << std::endl;

	float Dot = storage2.Dot(vec1, vec4);

	std::cout << "Dot Product is: " << Dot << "\n" <<  std::endl;

	float Mag = storage2.Mag(vec1);

	std::cout << "Magnitude Product is: " << Mag  << "\n" << std::endl;

	Vector3<float> Norm = storage2.Normalise(vec1);

	std::cout << "Normalised:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")\n" << std::endl;

	system("PAUSE");
	return 0;

}