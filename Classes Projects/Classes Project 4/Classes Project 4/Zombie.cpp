//includes the header file in order for this .cpp file to know what class this data belongs too
#include"Zombie.h"

using namespace std;

//Constructor
Zombie::Zombie()
{
	
}
//Deconstructor
Zombie::~Zombie()
{

}
//Initializes Zombie in constructor
Zombie::Zombie(string job, int h, int a, bool l)
{
	_occupation = job;
	_health = h;
	_attack = a;
	_life = l;


}
//Random generate zombie attack and health
void Zombie::RandomGen(Zombie z[])
{

	//sets random generator
	std::mt19937 randomGen(time(0));

	//distributes random numbers that are between the numbers set in parenthesis
	std::uniform_int_distribution<int> Health(100, 200);
	std::uniform_int_distribution<int> Attack(25, 50);

	//Zombie Objects initialized to Occupation, health, attack, and life.
	z[0] = Zombie("Programmer", Health(randomGen), Attack(randomGen), true);
	z[1] = Zombie("Construction Worker", Health(randomGen), Attack(randomGen), true);
	z[2] = Zombie("Babysitter", Health(randomGen), Attack(randomGen), true);
	z[3] = Zombie("Salesman", Health(randomGen), Attack(randomGen), true);
	z[4] = Zombie("Bodybuilding", Health(randomGen), Attack(randomGen), true);


}

//Get Zombie Health
int Zombie::getHealth()
{
	return _health;
}

//Get Zombie Attack
int Zombie::getAttack()
{
	return _attack;
}

//Get Zombie Life
bool Zombie::getlife()
{
	return _life;
}

//Get Zombie Job
std::string Zombie::getJob()
{
	return _occupation;
}

//Set Zombie Life
void Zombie::setlife(bool l)
{
	_life = l;
}

//Set Zombie Attack
void Zombie::setAttack(int a)
{
	_attack = a;
}

//Set Zombie Health
void Zombie::setHealth(int h)
{
	_health = h;
}

//Set Zombie Job
void Zombie::setJob(std::string j)
{
	_occupation = j;
}

