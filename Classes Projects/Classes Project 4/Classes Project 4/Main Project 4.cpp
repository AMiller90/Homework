#include<iostream>
#include<string>


//includes the header file in order for this .cpp file to know what class this data belongs to
#include"Zombie.h"

//Simulates Battle
void StartBattle()
{
	//Instance of zombie objects
	Zombie z[5];
	//Instance of zombie to use for calling functions
	Zombie zombie;
	//Calls Function to randomly generate attack, and health of zombies
	
	zombie.RandomGen(z);

	//Number of zombies
	int numZ = 5;
	do {
		//Loop through number of zombies
		for (int i = 0; i < 5; i++)
		{
			//Loop through index of zombies
			for (int j = 1; j < 5; j++)
			{
				//If current zombie attack is greater than or equal to the next zombies health and the zombie is alive
				if ((z[i].getAttack() >= z[j].getHealth()) && (z[i].getlife() == true) && (z[j].getlife() == true) && z[i].getJob() != z[j].getJob())
				{
					cout << z[i].getJob() << " Zombie Attacked And Killed The " << z[j].getJob() << " Zombie\n\n";

					//Set zombies life to false meaning it died
					z[j].setlife(false);

					//Subtract 1 from number of zombies
					numZ--;
				}
				//If current zombie attack is less than to the next zombies health
				if (z[i].getAttack() < z[j].getHealth())
				{//Set the next zombies health to the current zombies health minus the previous zombies attack value
					z[j].setHealth(z[j].getHealth() - z[i].getAttack());
					std::cout << "Zombie " << z[j].getJob() << " took " << z[i].getAttack() << " damage!\n\n";
				}

			}
			
		}
	

		//while loop
	} while (numZ > 1);
	//Loop through zombies
	for (int i = 0; i < 5; ++i)
	{//if there is one zombie left alive
		if (numZ == 1 && z[i].getlife() == true)
		{//Print to screen the zombie that is alive
			std::cout << "Last Zombie Standing:\n";
			std::cout << z[i].getJob();
		}
	}
		
	
		
}


/* Problem 4
Create a class representing a zombie.Each zombie should have a health and attack value,
and a previous occupation.Ensure that the zombie’s variables are private and there are
functions to access and modify the zombie’s data.
a.Using the zombie class, create a game in which a small number of zombies attack
each other until only one remains!*/

int main()
{
	char cInput;
	bool bIsDone = true;

	//Prompt user to play game 
	std::cout << "Zombie Battle Simulator:\n";
	std::cout << "Press P To Play:\n";
	std::cin >> cInput;

	//Game Loop
	while (bIsDone == true)
	{
		if (cInput == 'P' || cInput == 'p')
		{
			std::cout << "\nBattle Starts!\n\n";
			//Calls Function
			StartBattle();
			//Break out of loop
			bIsDone = false;
		}
		else
		{
			std::cout << "You Chose Not To Play!\n";
			//Break out of loop
			bIsDone = false;
		}
		
		
	}
	

	std::cout << std::endl;
	

	


	

	system("PAUSE");
	return 0;
}