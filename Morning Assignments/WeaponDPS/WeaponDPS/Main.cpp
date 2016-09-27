#include<iostream>

//Question: Weapon DPS
//We expect this question to take approximately 30 - 45 minutes.
//Write a function that calculates the damage per second of a given weapon.
//Requirements : Function must take a parameter of type that inherits from Weapon.
//Return value must be to the nearest second decimal place.Ex : 35.6

//Weapon class
class Weapon
{
public:
	Weapon()
	{

	}

	//get the dps of the weapon object
	float GetDps(const Weapon* w);

protected:
	float dps;
	float speed;
	float damage;

};


float Weapon::GetDps(const Weapon* w)
{//Check if the speed is less than or equal to 0
	if (this->speed <= 0)
		return;

	return this->dps;
}

class RocketLauncher : public Weapon
{
public:
	RocketLauncher()
	{

	}

	RocketLauncher(const float &dmg , const float &spd)
	{
			damage = dmg;
			speed = spd;
			dps = damage * speed;
	}

private:

};



int main()
{

	Weapon* rangedWeapon = new RocketLauncher(15.0f,0.0f);

	std::cout << rangedWeapon->GetDps(rangedWeapon);


	int tmp;
	std::cin >> tmp;

	return 0;
}