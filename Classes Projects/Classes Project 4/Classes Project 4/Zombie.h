//Preprocessor Directives - If Not Defined Then Define 
#ifndef _PLAYER_H_
#define _PLAYER_H_

#include<iostream>
#include<string>
#include<random>
#include<ctime>

using namespace std;

class Zombie
{
public:

	//Function Declarations
	//Constructor
	Zombie();
	//Destructor
	~Zombie();
	//Overload Constructor
	Zombie(string job, int h, int a, bool l);

	

	//Get Zombie Job
	std::string getJob();
	//Get Zombie Health
	int getHealth();
	//Get Zombie Attack
    int getAttack();
	//Get Zombie Life
	bool getlife();
	//Set Zombie Job
	void setJob(std::string j);
	//Set Zombie Health
	void setHealth(int h);
	//Set Zombie Attack
	void setAttack(int a);
	//Set Zombie Life
	void setlife(bool l);
	//Random Generate Zombie Attack And Health
	void RandomGen(Zombie z[]);
	
	
	

private:

	//Privbate Variables
	std::string _occupation;
	int _health;
	int _attack;
	bool _life;

};
//Ends The Inclusion Of This Class
#endif _PLAYER_H_