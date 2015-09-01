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
	Items inventory[5] = { { "Sword", 20, 5 }, { "Bow", 20, 5 }, { "Axe", 20, 5 }, { "Staff", 20, 5 }, { "Gun", 20, 5 } };


};


struct Player
{

	std::string name;
	int gold;
	Items inventory[5];


};



void printShop(Player user)
{

	
	Shop shop;
	Items item;

	

	
	
	
	std::cout << "Shop Inventory: \n";

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
	
	std::cout << "Shop Gold: " << shop.gold << std::endl;
	std::cout << std::endl;


	std::cout << user.name << "'s Inventory: \n";


}

int main()
{


	Player user;
	Shop shop;
	Items item;


	std::cout << "What Is Your Name?" << std::endl;
	std::cin >> user.name;
	std::cout << std::endl;

	std::cout << "Hello! Welcome To My Item Shop\n" << std::endl;

	


	printShop(user);












	system("PAUSE");
	return 0;
}