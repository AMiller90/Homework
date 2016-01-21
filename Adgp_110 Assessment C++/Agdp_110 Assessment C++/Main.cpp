#include "Vector2.h"
#include "Vector3.h"
#include "Color.h"

#include <iostream>



int main()
{
	Vector2<int> vec2(12,24);
	Vector2<int> vec3(12,24);
	Vector2<int> storage;

	Color<float> color;
	Color<float> idf(12.0,12.0,12.0,12.0);

	std::cout << "Vector2: \n\n";

	storage = vec3 + vec2;
	
	std::cout << "Add:" << "(" << storage.x << "," << storage.y << ")\n" << std::endl;

	storage = vec3 - vec2;

	std::cout << "Subtract:" << "(" << storage.x << "," << storage.y << ")\n" << std::endl;

	Vector3<int> vec1(12, 12, 12);
	Vector3<int> vec4(12, 12, 12);
	Vector3<int> storage2;
	
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

	Vector3<int> Norm = storage2.Normalise(vec1);

	std::cout << "Normalised:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")\n" << std::endl;

	float mag = color.Mag(idf);

	std::cout << "Magnitude Product is: " << mag << "\n" << std::endl;

	Color<float> rgba = color.HexConv("#FFFFFF");

	std::cout << "(" << rgba.r << "," << rgba.g << "," << rgba.b << "," << rgba.a << ")\n";

	system("PAUSE");
	return 0;

}