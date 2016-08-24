#include <iostream>
//08/23/16

int** CreateIdentityMatrix(int row, int height);
void MultiplyByIdentity(int** identity);

//The number of columns in the first matrix has to match the
//number of rows in the second

int main()
{
	int rows = 4;
	int cols = 4;

	int** identityMatrix = CreateIdentityMatrix(rows,cols);

	MultiplyByIdentity(identityMatrix);

	int tmp;
	std::cin >> tmp;

	return 0;

}

int** CreateIdentityMatrix(int rows, int columns)
{
	int** identityMatrix = 0;

	identityMatrix = new int*[rows];

	for (int x = 0; x < rows; x++)
	{
		identityMatrix[x] = new int[columns];

		for (int y = 0; y < columns; y++)
		{
			identityMatrix[x][y] = (x == y) ? 1 : 0;
		}
	}

	double offset = sqrt(rows * columns) - 1;

	std::cout << "Identity Matrix:\n";
	for (int x = 0; x < rows; x++)
	{
		std::cout << "| ";
		for (int y = 0; y < columns; y++)
		{
			std::cout << identityMatrix[x][y] << " | ";
			if (y == offset)
				std::cout << "\n";
		}
	}

	return identityMatrix;
}

void MultiplyByIdentity(int** identity)
{
	std::cout << "\nTransformation: [5,3,2,1] \n";

	std::cout << "\nMultiply the 2 and you get this: \n\n";

	int anotherMatrix[4] = { 5,3,2,1 };
	int translatedMatrix[4][1];

	translatedMatrix[0][0] = identity[0][0] * anotherMatrix[0] + identity[0][1] * anotherMatrix[1] + identity[0][2] * anotherMatrix[2] + identity[0][3] * anotherMatrix[3];
	translatedMatrix[1][0] = identity[1][0] * anotherMatrix[0] + identity[1][1] * anotherMatrix[1] + identity[1][2] * anotherMatrix[2] + identity[1][3] * anotherMatrix[3];
	translatedMatrix[2][0] = identity[2][0] * anotherMatrix[0] + identity[2][1] * anotherMatrix[1] + identity[2][2] * anotherMatrix[2] + identity[2][3] * anotherMatrix[3];
	translatedMatrix[3][0] = identity[3][0] * anotherMatrix[0] + identity[3][1] * anotherMatrix[1] + identity[3][2] * anotherMatrix[2] + identity[3][3] * anotherMatrix[3];

	std::cout << "[";

	for (int i = 0; i < 4; i++)
	{
		std::cout << *translatedMatrix[i] << " ";
	}
	
	std::cout << "]";

	std::cout << "\nAny matrix multiplied by the identity matrix doesn't change!";
}
