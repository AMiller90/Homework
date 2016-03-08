#include "Grid.h"
#include "Player.h"

#include<iostream>
#include<string>

using namespace std;

void PrintStats(Player p);
bool ActivateNodes(Player &p, bool b);

int main()
{
	
	bool isDone = true;

	Grid g;
	Player p("Tidus", 100, 50, 10, 15, 30);

	
	while (isDone)
	{
		g.CreateGrid();

		cout << "\nHello! What would you like to do for " << p.getName() << "?" << endl << endl;

		isDone = ActivateNodes(p,isDone);

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

bool ActivateNodes(Player &p, bool b)
{
	int input;

	cout << "Enter Node Number 1 - 5 or 0 to Quit: " << endl;
	cin >> input;


	switch (input)
	{
	case 0:
		b = false;
		return b;

	case 1:
		system("cls");
		p.setHp(p.getHp() + 100);
		cout << "Hp Up!" << endl;
		PrintStats(p);
		break;

	case 2:
		system("cls");
		p.setMp(p.getMp() + 100);
		cout << "Mp Up!" << endl;
		PrintStats(p);
		break;

	case 3:
		system("cls");
		p.setatk(p.getatk() + 5);
		cout << "Atk Up!" << endl;
		PrintStats(p);
		break;

	case 4:
		system("cls");
		p.setdef(p.getdef() + 5);
		cout << "Def Up!" << endl;
		PrintStats(p);
		break;

	case 5:
		system("cls");
		p.setspd(p.getspd() + 5);
		cout << "Spd Up!" << endl;
		PrintStats(p);
		break;

	default:
		break;
	}
}