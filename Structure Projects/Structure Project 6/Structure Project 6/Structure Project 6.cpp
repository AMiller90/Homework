#pragma once
 

#include<iostream>
#include<string>



struct Items
{
	int num;
	std::string Name;
	int Cost;
	int Quantity;
	



};


struct Shop
{

	int gold = { 1000 };
	Items inventory[5] = { { 1, "knife", 10, 5 }, { 2, "Health Potion", 5, 5 }, { 3, "Mana Potion", 5, 5 }, { 4,  "Boots", 10, 5 }, { 5, "Hat", 3, 5 } };
	Items discountInventory[5] = { { 1, "knife", 10/2, 5 },{ 2, "Health Potion", 6/2, 5 },{ 3, "Mana Potion", 6/2, 5 },{ 4,  "Boots", 10/2, 5 },{ 5, "Hat", 4/2, 5 } };

};


struct Player
{

	std::string name;
	int gold = { 100 };
	Items inventory[5] = { { 1, "knife", 10, 1 }, { 2, "Health Potion", 5, 1 }, { 3, "Mana Potion", 5, 1 }, { 4, "Boots", 10, 1 }, { 5, "Hat", 3, 1 } };
};





void printShop(Player user, Shop shop)
{

	
	std::cout << "Shop Inventory: \n";
	
	for (int i = 0; i < 5; i++)
	{
		
		std::cout << shop.inventory[i].num << ". " << shop.inventory[i].Name <<":";
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
	std::cout << std::endl;

	for (int i = 0; i < 5; i++)
	{

		std::cout << user.inventory[i].num << ". " << user.inventory[i].Name << ":";
		//std::cout << std::endl;
		std::cout << user.inventory[i].Cost << " gold x ";
		//std::cout << std::endl;
		std::cout << user.inventory[i].Quantity << " ";
		std::cout << std::endl;
		std::cout << std::endl;

	}

	std::cout << "Gold:" << std::endl;
	std::cout << user.gold << std::endl;


}

void discountShop(Player user, Shop shop)
{

	std::cout << "Discount Shop Inventory: \n";

	for (int i = 0; i < 5; i++)
	{
		std::cout << shop.discountInventory[i].num << ". " << shop.discountInventory[i].Name << ":";
		//std::cout << std::endl;
		std::cout << shop.discountInventory[i].Cost << " gold x ";
		//std::cout << std::endl;
		std::cout << shop.discountInventory[i].Quantity << " ";
		std::cout << std::endl;
		std::cout << std::endl;
	}

	std::cout << "Shop Gold: " << shop.gold << std::endl;
	std::cout << std::endl;


	std::cout << user.name << "'s Inventory: \n";
	std::cout << std::endl;

	for (int i = 0; i < 5; i++)
	{

		std::cout << user.inventory[i].num << ". " << user.inventory[i].Name << ":";
		//std::cout << std::endl;
		std::cout << user.inventory[i].Cost << " gold x ";
		//std::cout << std::endl;
		std::cout << user.inventory[i].Quantity << " ";
		std::cout << std::endl;
		std::cout << std::endl;

	}

	std::cout << "Gold:" << std::endl;
	std::cout << user.gold << std::endl;



}

void discountShopping(Player user, Shop shop)
{



	char choice;
	std::cout << "Do you want to buy, sell or quit? Enter B, S or Q \n";
	std::cin >> choice;



	
	switch (choice)
	{

	case 'B':

		int num;
		std::cout << "Please Enter The Number Of The Item You Would Like To Buy:\n";
		std::cin >> num;


		for (int i = 0; i < 5; i++)
		{

			if (num == shop.discountInventory[i].num)
			{
				shop.discountInventory[i].Quantity--;
				shop.gold += user.inventory[i].Cost;
				user.gold -= shop.discountInventory[i].Cost;
				user.inventory[i].Quantity++;
				discountShop(user, shop);
				break;
			}
		}


	case 'S':


		for (int i = 0; i < 5; i++)
		{
			int num2;
			std::cout << "Please Enter The Number Of The Item You Would Like To Sell:\n";
			std::cin >> num2;


			if (num == shop.discountInventory[i].num)
			{
				shop.discountInventory[i].Quantity++;
				shop.gold -= user.inventory[i].Cost;
				user.gold += shop.discountInventory[i].Cost;
				user.inventory[i].Quantity--;
				discountShop(user, shop);
				break;
			}
		}



	case 'Q':
		std::cout << "Thanks For Shopping!\n";
		break;


	default:
		break;

	}






}
void Shopping(Player user, Shop shop)
{
	char choice;
	std::cout << "Do you want to buy, sell or quit? Enter B, S or Q \n";
	std::cin >> choice;

	

	    
		switch (choice)
		{

		case 'B':
			 
			int num;
			std::cout << "Please Enter The Number Of The Item You Would Like To Buy:\n";
			std::cin >> num;
		

			for (int i = 0; i < 5; i++)
			{
				
				if (num == shop.inventory[i].num)
				{
					shop.inventory[i].Quantity--;
					shop.gold += user.inventory[i].Cost;
					user.gold -= shop.inventory[i].Cost;
					user.inventory[i].Quantity++;
					printShop(user, shop);
					break;
				}
			}


		case 'S':
			
			
			for (int i = 0; i < 5; i++)
			{  
				int num;
				std::cout << "Please Enter The Number Of The Item You Would Like To Sell:\n";
				std::cin >> num;

				if (num == shop.inventory[i].num)
				{


					shop.inventory[i].Quantity++;
					shop.gold -= user.inventory[i].Cost;
					user.gold += shop.inventory[i].Cost;
					user.inventory[i].Quantity--;
					printShop(user, shop);
					break;
				}
			}



		case 'Q':
			std::cout << "Thanks For Shopping!\n";
			break;


		default:
			break;

		}
	


}

int main()
{


	Player user;
	Shop shop;
	Items item;


	std::cout << "What Is Your Name?" << std::endl;
	std::cin >> user.name;
	std::cout << std::endl;

	char answer;
	std::cout << "Are You New To Games? Enter y or no:" << std::endl;
	std::cin >> answer;

	if (answer == 'y')
	{
		std::cout << "Hello! Welcome To The Item Shop! Prices are lower since you are new to gaming"<< std::endl;
		discountShop(user, shop);
		discountShopping(user, shop);

	}
	else if (answer == 'n')
	{
		std::cout << "Hello! Welcome To The Item Shop\n" << std::endl;
		printShop(user, shop);
		Shopping(user, shop);

	}
	

	


	

	











	system("PAUSE");
	return 0;
}