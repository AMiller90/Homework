#pragma once

#include<iostream>


int main() {

	//Problem 5
	//Consider The Following Code Segment
    int i = 0;
	float f = 0;
	char ch = 'a';
	std::cin >> i >> ch >> f;
	std::cout << "i: " << i << "\nch: " << ch << "\nf: " << f << std::endl;
    
	//What Will Be The Output When The Input is:
	Answers
	a) i: 1 ch: A f: 45 //a) 1 A 45
	b) i: 1 ch: A f: 45 //b) 1A45
	c) i: 1 ch: 9 f: 45 //c) 1 9 45
	d) i: 1 ch: 9 f: 45 //d) 1 945
	e) i: 0 ch: a f: 0 //e) B 45.6
	f) i: 1 ch: B f: 0 //f) 1BC5.6


	system("PAUSE");
	return 0;
}