#pragma once
#include<iostream>



class Date {


public:
	//sets up all function decalarations
	
	Date(int d, int m, int y);
	
	void printDate();


private:
	//Private Variables

	int day;
	int month;
	int year;




};