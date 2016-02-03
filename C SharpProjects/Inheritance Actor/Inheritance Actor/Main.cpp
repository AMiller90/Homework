#include "Enemy.h"
#include "Player.h"

#include <conio.h>

using namespace std;

int main()
{
	system("color b");
	

	Player p;
	Enemy e;
	Actor a;

	a.Update();
	p.Update();
	e.Update();

	
	cout << "hi" << endl;
	int tmp;

	cin >> tmp;
	return 0;
}