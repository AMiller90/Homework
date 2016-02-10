#include "Vector2.h"
#include "Vector3.h"
#include "Color.h"

#include <iostream>

int main()
{

	Vector2<int> vec2(12,25);
	Vector2<int> vec3(13,24);
	Vector2<int> storage;

	std::cout << "Vector2: \n\n";

	storage = vec3 + vec2;
	
	std::cout << "Add:" << "(" << storage.x << "," << storage.y << ")" << std::endl;

	storage = vec3 - vec2;

	std::cout << "Subtract:" << "(" << storage.x << "," << storage.y << ")" << std::endl;

	storage = vec3 / vec2;

	std::cout << "Divide:" << "(" << storage.x << "," << storage.y  << ")" << std::endl; 

	storage = vec3 * vec2;

	std::cout << "Multiply:" << "(" << storage.x << "," << storage.y << ")" << std::endl;

	storage = vec3 % vec2;

	std::cout << "Modulus:" << "(" << storage.x << "," << storage.y << "," << ")" << std::endl;

	int sto = storage.Dot(vec2, vec3);
	std::cout << "Dot product: " << sto << std::endl;

	int mg = storage.Mag(vec2);
	std::cout << "Magnitude: " << mg << std::endl;

	Vector2<int> norm = storage.Normalise(vec2);
	std::cout << "Normalize:" << "(" << norm.x << "," << norm.y << "," << ")\n\n" << std::endl;


	Vector3<int> vec1(12, 12, 12);
	Vector3<int> vec4(12, 12, 12);
	Vector3<int> storage2;
	
	std::cout << "Vector3: \n\n";

	storage2 = vec1 + vec4;

	std::cout << "Add:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")" << std::endl;

	storage2 = vec1 - vec4;

	std::cout << "Subtract:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")" << std::endl;

	storage2 = vec1 / vec4;

	std::cout << "Divide:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")" << std::endl; 

	storage2 = vec1 * vec4;

	std::cout << "Multiply:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")" << std::endl;

	storage2 = vec1 % vec4;

	std::cout << "Modulus:" << "(" << storage2.x << "," << storage2.y << "," << storage2.z << ")" << std::endl;

	int Dot = storage2.Dot(vec1, vec4);

	std::cout << "Dot Product is: " << Dot << std::endl;

	Vector3<int> cross = storage2.Cross(vec1, vec4);

	std::cout << "Cross Product is: " << cross.x << "," << cross.y << cross.z << std::endl;

	int Mag = storage2.Mag(vec1);

	std::cout << "Magnitude Product is: " << Mag  << std::endl;

	Vector3<int> Norm = storage2.Normalise(vec1);

	std::cout << "Normalised:" << "(" << Norm.x << "," << Norm.y << "," << Norm.z << ")\n" << std::endl;


	std::cout << "Color: \n\n";
	Color<int> color;

	Color<int> boo1(12, 12, 12, 12);
	Color<int> boo2(13, 13, 13, 13);
	Color<int> test;

	test = boo1 + boo2;

	std::cout << "Add:" << "(" << test.r << "," << test.g << "," << test.b << "," << test.a << ")" << std::endl;

	test = boo1 - boo2;

	std::cout << "Subtract:" << "(" << test.r << "," << test.g << "," << test.b << "," << test.a << ")" << std::endl;

	test = boo1 * boo2;

	std::cout << "Multiply:" << "(" << test.r << "," << test.g << "," << test.b << "," << test.a << ")" << std::endl;

	test = boo1 / boo2;

	std::cout << "Quotient:" << "(" << test.r << "," << test.g << "," << test.b << "," << test.a << ")" << std::endl;

	test = boo1 % boo2;

	std::cout << "Modulus:" << "(" << test.r << "," << test.g << "," << test.b << "," << test.a << ")" << std::endl;

	test = test.Normalise(boo1);
	
	std::cout << "Normalize:" << "(" << test.r << "," << test.g << "," << test.b << "," << test.a << ")" << std::endl;

	float mag = test.Mag(boo1);

	std::cout << "Magnitude: " << mag;

	Color<int> rgba = color.HexConv("#FFFFFF");

	std::cout << "\nRGBA Values Are : (" << rgba.r << "," << rgba.g << "," << rgba.b << "," << rgba.a << ")\n";


	system("PAUSE");
	return 0;

}