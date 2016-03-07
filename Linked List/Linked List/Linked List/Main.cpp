#include "Grid.h"
#include "Player.h"

#include<iostream>
#include<string>

using namespace std;

int main()
{
	int input;

	Grid g;
	Player p("Tidus", 100, 50, 10, 15, 30);

	g.CreateGrid();

	cout << "\nHello! What would you like to do for " << p.getName() << "?" << endl;
	
	cout << "\nCurrent Stats:\n";
	cout << "HP: " << p.getHp() << endl;
	cout << "MP: " << p.getMp() << endl;
	cout << "Atk: " << p.getatk() << endl;
	cout << "Def: " << p.getdef() << endl;
	cout << "Spd: " << p.getspd() << endl << endl;

	cout << "Enter Node Number 1 - 5: " << endl;
	cin >> input;

	switch (input)
	{
	case 1:
		p.setHp(p.getHp() + 100);
		cout << "Hp is Now: " << p.getHp() << endl;
		break;

	case 2:
		p.setMp(p.getMp() + 100);
		cout << "Mp is Now: " << p.getMp() << endl;
		break;

	case 3:
		p.setatk(p.getatk() + 5);
		cout << "Atk is Now: " << p.getatk() << endl;
		break;

	case 4:
		p.setdef(p.getdef() + 5);
		cout << "Def is Now: " << p.getdef() << endl;
		break;

	case 5:
		p.setspd(p.getspd() + 5);
		cout << "Spd is Now: " << p.getspd() << endl;
		break;

	default:
		break;
	}

	
	system("PAUSE");

	return 0;
}