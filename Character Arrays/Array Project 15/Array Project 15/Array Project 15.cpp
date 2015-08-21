#pragma once


#include<iostream>

#include<string>





int main() {


	char a = 'A';
	char b = 'n';
	char c = 'd';
	char d = 'r';
	char e = 'e';
	char f = 'w';

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

	std::cout << u << std::endl;
	std::cout << v << std::endl;
	std::cout << w << std::endl;
	std::cout << x << std::endl;
	std::cout << y << std::endl;
	std::cout << z << std::endl;

	system("PAUSE");
	return 0;
}