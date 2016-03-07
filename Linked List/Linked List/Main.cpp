#include "Grid.h"
#include "Player.h"

#include<iostream>
#include<string>

using namespace std;

void PrintStats(Player p);
void ActivateNodes(Player &p);

int main()
{
	
	bool isDone = true;

	Grid g;
	Player p("Tidus", 100, 50, 10, 15, 30);

	
	while (isDone)
	{
		g.CreateGrid();

		cout << "\nHello! What would you like to do for " << p.getName() << "?" << endl;

		//PrintStats(p);

		ActivateNodes(p);
	}
	
	

	
	system("PAUSE");

	return 0;
}

void PrintStats(Player p)
{
	cout << "\nCurrent Stats:\n";
	cout << "HP: " << p.getHp() << endl;
	cout << "MP: " << p.getMp() << endl;
	cout << "Atk: " << p.getatk() << endl;
	cout << "Def: " << p.getdef() << endl;
	cout << "Spd: " << p.getspd() << endl << endl;
}

void ActivateNodes(Player &p)
{
	int input;

	cout << "Enter Node Number 1 - 5 or 0 to Quit: " << endl;
	cin >> input;


	switch (input)
	{
	case 0:
		break;

	case 1:
		system("cls");
		p.setHp(p.getHp() + 100);
		cout << "Hp Up!" << endl;
		PrintStats(p);
		break;

	case 2:
		p.setMp(p.getMp() + 100);
		cout << "Mp Up!" << endl;
		PrintStats(p);
		break;

	case 3:
		p.setatk(p.getatk() + 5);
		cout << "Atk Up!" << endl;
		PrintStats(p);
		break;

	case 4:
		p.setdef(p.getdef() + 5);
		cout << "Def Up!" << endl;
		PrintStats(p);
		break;

	case 5:
		p.setspd(p.getspd() + 5);
		cout << "Spd Up!" << endl;
		PrintStats(p);
		break;

	default:
		break;
	}
}