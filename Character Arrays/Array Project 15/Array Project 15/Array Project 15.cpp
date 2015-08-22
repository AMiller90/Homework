#pragma once


#include<iostream>

#include<string>





int main() {


	char a = 'M';
	char b = 'I';
	char c = 'L';
	char d = 'L';
	char e = 'E';
	char f = 'R';

	std::cout << a << " " << b << " "  << c << " " << d << " " << e << " " << f << std::endl;

	float g = (float)a;
	float h = (float)b;
	float i = (float)c;
	float j = (float)d;
	float k = (float)e;
	float l = (float)f;

	g = g + 5;
	h = h + 5;
	i = i + 5;
	j = j + 5;
	k = k + 5;
	l = l + 5;


	char u = (char)g;
	char v = (char)h;
	char w = (char)i;
	char x = (char)j;
	char y = (char)k;
	char z = (char)l;

	std::cout << u << " ";
	std::cout << v << " ";
	std::cout << w << " "; 
	std::cout << x << " "; 
	std::cout << y << " ";
	std::cout << z << " ";

	std::cout << std::endl;

	system("PAUSE");
	return 0;
}