#ifndef ZOMBIE_H
#define ZOMBIE_H



#include<iostream>
#include<string>

using namespace std;
class Zombie
{
public:

	Zombie();	
	Zombie(string job, int h, int a, bool l);

	int getHealth();
    int getAttack();
	bool getlife();
	void setlife(bool l);

	void setAttack(int a);
	void setHealth(int h);


	std::string getJob();
	void setJob(std::string j); 
	

private:

	std::string _occupation;
	int _health;
	int _attack;
	bool _life;

};

#endif // !ZOMBIE_H