#pragma once


#include<iostream>
#include<string>



struct Items
{
	std::string Name;
	int Cost;
	int Quantity;




};


struct Shop
{

	int gold = { 1000 };
	Items inventory[5] = { {"Sword", 20, 5 } , {"Bow", 20, 5}, {"Axe", 20, 5}, {"Staff", 20, 5}, {"Gun", 20, 5} };


};


struct Player
{

	std::string name;
	int gold;
	Items inventory[5];


};



void printShop()
{

	Player user;
	Shop shop;
	Items item;

	

	
	
	std::cout << "Gold: " <<  shop.gold << std::endl;
	std::cout << std::endl;

	for (int i = 0; i < 5; i++)
	{
		std::cout << shop.inventory[i].Name <<":";
		//std::cout << std::endl;
		std::cout << shop.inventory[i].Cost << " gold x ";
		//std::cout << std::endl;
		std::cout << shop.inventory[i].Quantity << " ";
		std::cout << std::endl;
		std::cout << std::endl;
	}
	


}

int main()
{


	Player user;
	Shop shop;
	Items item;


	std::cout << "Hello! Welcome To My Item Shop\n" << std::endl;

	printShop();












	system("PAUSE");
	return 0;
}