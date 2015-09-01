#include<iostream>

#include<string>


class Zombie
{
public:

	
	Zombie();
	int getHealth();
    int getAttack(int a);
	
	void setAttack(int a);
	void setHealth(int h);


	std::string Job(std::string job);
	void Battle();
	

private:

	std::string _occupation;
	int _health;
	int _attack;
	

};