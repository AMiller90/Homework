#include<iostream>

//08/17/16 
//write a program that multiplies two 4x4 matrices and returns 1 matrix

using namespace std;


int** Multiply4x4Matrices(int a[][4], int b[][4])
{

	int** cMatrix = 0;

	cMatrix = new int*[4];

	for (int i = 0; i < 4; i++)
	{
		cMatrix[i] = new int[4];
	}


	cMatrix[0][0] = a[0][0] * b[0][0] + a[0][1] * b[1][0] +
		a[0][2] * b[2][0] + a[0][3] * b[3][0];

	cMatrix[0][1] = a[0][0] * b[0][1] + a[0][1] * b[1][1] +
		a[0][2] * b[2][1] + a[0][3] * b[3][1];

	cMatrix[0][2] = a[0][0] * b[0][2] + a[0][1] * b[1][2] +
		a[0][2] * b[2][2] + a[0][3] * b[3][2];

	cMatrix[0][3] = a[0][0] * b[0][3] + a[0][1] * b[1][3] +
		a[0][2] * b[2][3] + a[0][3] * b[3][3];

	cMatrix[1][0] = a[1][0] * b[0][0] + a[1][1] * b[1][0] +
		a[1][2] * b[2][0] + a[1][3] * b[3][0];

	cMatrix[1][1] = a[1][0] * b[0][1] + a[1][1] * b[1][1] +
		a[1][2] * b[2][1] + a[1][3] * b[3][1];

	cMatrix[1][2] = a[1][0] * b[0][2] + a[1][1] * b[1][2] +
		a[1][2] * b[2][2] + a[1][3] * b[3][2];

	cMatrix[1][3] = a[1][0] * b[0][3] + a[1][1] * b[1][3] +
		a[1][2] * b[2][3] + a[1][3] * b[3][3];

	cMatrix[2][0] = a[2][0] * b[0][0] + a[2][1] * b[1][0] +
		a[2][2] * b[2][0] + a[2][3] * b[3][0];

	cMatrix[2][1] = a[2][0] * b[0][1] + a[2][1] * b[1][1] +
		a[2][2] * b[2][1] + a[2][3] * b[3][1];

	cMatrix[2][2] = a[2][0] * b[0][2] + a[2][1] * b[1][2] +
		a[2][2] * b[2][2] + a[2][3] * b[3][2];

	cMatrix[2][3] = a[2][0] * b[0][3] + a[2][1] * b[1][3] +
		a[2][2] * b[2][3] + a[2][3] * b[3][3];

	cMatrix[3][0] = a[3][0] * b[0][0] + a[3][1] * b[1][0] +
		a[3][2] * b[2][0] + a[3][3] * b[3][0];

	cMatrix[3][1] = a[3][0] * b[0][1] + a[3][1] * b[1][1] +
		a[3][2] * b[2][1] + a[3][3] * b[3][1];

	cMatrix[3][2] = a[3][0] * b[0][2] + a[3][1] * b[1][2] +
		a[3][2] * b[2][2] + a[3][3] * b[3][2];

	cMatrix[3][3] = a[3][0] * b[0][3] + a[3][1] * b[1][3] +
		a[3][2] * b[2][3] + a[3][3] * b[3][3];

	return cMatrix;
}

int main()
{

	int a[4][4];
	int b[4][4];

	for (int x = 0; x < 4; x++)
	{
		for (int y = 0; y < 4; y++)
		{
			a[x][y] = (x == y) ? 10 : 0;
		}
	}

	for (int x = 0; x < 4; x++)
	{
		for (int y = 0; y < 4; y++)
		{
			b[x][y] = (x == y) ? 20 : 0;
		}
	}

	int** matrix = Multiply4x4Matrices(a, b);

	for (int x = 0; x < 4; x++)
	{
		std::cout << "| ";
		for (int y = 0; y < 4; y++)
		{
			std::cout << matrix[x][y] << " | ";
			if (y == 3)
				std::cout << "\n";
		}
	}

	int tmp;
	cin >> tmp;

	return 0;
}