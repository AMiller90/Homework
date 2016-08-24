#include<iostream>
//08/22/16
void CreateIdentityMatrix();

int main()
{

	CreateIdentityMatrix();

	int tmp;
	std::cin >> tmp;

	return 0;
}

void CreateIdentityMatrix()
{
	int identitymMatrix[3][3];

	for (int x = 0; x < 3; x++)
	{
		for (int y = 0; y < 3; y++)
		{
			identitymMatrix[x][y] = (x == y) ? 1 : 0;
		}
	}

	for (int x = 0; x < 3; x++)
	{
		std::cout << "| ";
		for (int y = 0; y < 3; y++)
		{
			std::cout << identitymMatrix[x][y] << " | ";
			if (y == 2)
				std::cout << "\n";
		}
	}
}
