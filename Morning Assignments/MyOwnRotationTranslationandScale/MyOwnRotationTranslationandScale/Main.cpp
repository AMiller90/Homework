#include <iostream>
//08/24/16
//Implement your own translation, rotation and scale functions like glm

int** CreateIdentityMatrix(int row, int height);

//vec3 Class
class vec3
{
public:
	vec3(){};

	///<summary>
	///Creates vec3 object
	///<para></para>
	///<remarks><paramref name=" a_X"></paramref> -X pos</remarks>
	///<remarks><paramref name=" a_Y"></paramref> -Y pos</remarks>
	///<remarks><paramref name=" a_Z"></paramref> -Z pos</remarks>
	///</summary>
	vec3(float a_X, float a_Y, float a_Z) 
	: x(a_X), y(a_Y), z(a_Z)
	{};

	float x;
	float y;
	float z;
};

//Static Class used to operations on matrices
class MatrixOperations
{
public:
	///<summary>
	///Builds and returns a 2D Array[4][4](Matrix4x4) that will have its translation set as the passed in vector
	///<para></para>
	///<remarks><paramref name=" a_Vector"></paramref> -The vector to translate by</remarks>
	///</summary>
	static int** Translate(vec3 a_Vector)
	{
		int** TranslationMatrix = nullptr;

		const int rows = 4;
		const int cols = 4;

		TranslationMatrix = new int*[rows];

		//Set TranslationMatrix as an identity matrix
		for (int x = 0; x < rows; x++)
		{
			TranslationMatrix[x] = new int[cols];

			for (int y = 0; y < cols; y++)
			{
				TranslationMatrix[x][y] = (x == y) ? 1 : 0;
			}
		}

		//Static set the translation column of matrix using passed in vector
		TranslationMatrix[0][3] = a_Vector.x;
		TranslationMatrix[1][3] = a_Vector.y;
		TranslationMatrix[2][3] = a_Vector.z;

		//Return the translation matrix
		return TranslationMatrix;
	}
	///<summary>
	///Builds and returns the 2D Array[4][4](Matrix4x4) that will have its translation set as the 3 numbers passed in
	///<para></para>
	///<remarks><paramref name=" a_Vector"></paramref> -The vector to translate by</remarks>
	///</summary>
	static int** Translate(int a_X, int a_Y, int a_Z)
	{
		int** TranslationMatrix = nullptr;

		const int rows = 4;
		const int cols = 4;

		TranslationMatrix = new int*[rows];

		//Set TranslationMatrix as an identity matrix
		for (int x = 0; x < rows; x++)
		{
			TranslationMatrix[x] = new int[cols];

			for (int y = 0; y < cols; y++)
			{
				TranslationMatrix[x][y] = (x == y) ? 1 : 0;
			}
		}

		//Static set the translation column of matrix using passed in vector
		TranslationMatrix[0][3] = a_X;
		TranslationMatrix[1][3] = a_Y;
		TranslationMatrix[2][3] = a_Z;

		//Return the translation matrix
		return TranslationMatrix;
	}
	///<summary>
	///Translates and returns the 2D Array[4][4](Matrix4x4) that is passed in by the vector passed in
	///<para></para>
	///<remarks><paramref name=" a_Matrix"></paramref> -The 2D Array[4][4](Matrix4x4) to translate</remarks>
	///<remarks><paramref name=" a_Vector"></paramref> -The vector to translate by</remarks>
	///</summary>
	static int** Translate(int** a_Matrix, vec3 a_Vector)
	{
		int** TranslationMatrix = nullptr;

		const int rows = 4;
		const int cols = 4;

		TranslationMatrix = new int*[rows];

		//Set TranslationMatrix as an identity matrix
		for (int x = 0; x < rows; x++)
		{
			TranslationMatrix[x] = new int[cols];

			for (int y = 0; y < cols; y++)
			{
				TranslationMatrix[x][y] = (x == y) ? 1 : 0;
			}
		}

		//Static set the translation column of matrix using passed in vector
		TranslationMatrix[0][3] = a_Vector.x;
		TranslationMatrix[1][3] = a_Vector.y;
		TranslationMatrix[2][3] = a_Vector.y;

		//Now that we have a matrix with the translation set to the passed in vector
		//We multiply them together and set the result to the passed in vector
		a_Matrix[0][0] = a_Matrix[0][0] * TranslationMatrix[0][0] + a_Matrix[0][1] * TranslationMatrix[1][0] +
			             a_Matrix[0][2] * TranslationMatrix[2][0] + a_Matrix[0][3] * TranslationMatrix[3][0];

		a_Matrix[0][1] = a_Matrix[0][0] * TranslationMatrix[0][1] + a_Matrix[0][1] * TranslationMatrix[1][1] +
			             a_Matrix[0][2] * TranslationMatrix[2][1] + a_Matrix[0][3] * TranslationMatrix[3][1];

		a_Matrix[0][2] = a_Matrix[0][0] * TranslationMatrix[0][2] + a_Matrix[0][1] * TranslationMatrix[1][2] +
			             a_Matrix[0][2] * TranslationMatrix[2][2] + a_Matrix[0][3] * TranslationMatrix[3][2];

		a_Matrix[0][3] = a_Matrix[0][0] * TranslationMatrix[0][3] + a_Matrix[0][1] * TranslationMatrix[1][3] +
			             a_Matrix[0][2] * TranslationMatrix[2][3] + a_Matrix[0][3] * TranslationMatrix[3][3];

		a_Matrix[1][0] = a_Matrix[1][0] * TranslationMatrix[0][0] + a_Matrix[1][1] * TranslationMatrix[1][0] +
			             a_Matrix[1][2] * TranslationMatrix[2][0] + a_Matrix[1][3] * TranslationMatrix[3][0];

		a_Matrix[1][1] = a_Matrix[1][0] * TranslationMatrix[0][1] + a_Matrix[1][1] * TranslationMatrix[1][1] +
			             a_Matrix[1][2] * TranslationMatrix[2][1] + a_Matrix[1][3] * TranslationMatrix[3][1];

		a_Matrix[1][2] = a_Matrix[1][0] * TranslationMatrix[0][2] + a_Matrix[1][1] * TranslationMatrix[1][2] +
			             a_Matrix[1][2] * TranslationMatrix[2][2] + a_Matrix[1][3] * TranslationMatrix[3][2];

		a_Matrix[1][3] = a_Matrix[1][0] * TranslationMatrix[0][3] + a_Matrix[1][1] * TranslationMatrix[1][3] +
			             a_Matrix[1][2] * TranslationMatrix[2][3] + a_Matrix[1][3] * TranslationMatrix[3][3];

		a_Matrix[2][0] = a_Matrix[2][0] * TranslationMatrix[0][0] + a_Matrix[2][1] * TranslationMatrix[1][0] +
			             a_Matrix[2][2] * TranslationMatrix[2][0] + a_Matrix[2][3] * TranslationMatrix[3][0];

		a_Matrix[2][1] = a_Matrix[2][0] * TranslationMatrix[0][1] + a_Matrix[2][1] * TranslationMatrix[1][1] +
			             a_Matrix[2][2] * TranslationMatrix[2][1] + a_Matrix[2][3] * TranslationMatrix[3][1];

		a_Matrix[2][2] = a_Matrix[2][0] * TranslationMatrix[0][2] + a_Matrix[2][1] * TranslationMatrix[1][2] +
			             a_Matrix[2][2] * TranslationMatrix[2][2] + a_Matrix[2][3] * TranslationMatrix[3][2];

		a_Matrix[2][3] = a_Matrix[2][0] * TranslationMatrix[0][3] + a_Matrix[2][1] * TranslationMatrix[1][3] +
			             a_Matrix[2][2] * TranslationMatrix[2][3] + a_Matrix[2][3] * TranslationMatrix[3][3];

		a_Matrix[3][0] = a_Matrix[3][0] * TranslationMatrix[0][0] + a_Matrix[3][1] * TranslationMatrix[1][0] +
			             a_Matrix[3][2] * TranslationMatrix[2][0] + a_Matrix[3][3] * TranslationMatrix[3][0];

		a_Matrix[3][1] = a_Matrix[3][0] * TranslationMatrix[0][1] + a_Matrix[3][1] * TranslationMatrix[1][1] +
			             a_Matrix[3][2] * TranslationMatrix[2][1] + a_Matrix[3][3] * TranslationMatrix[3][1];

		a_Matrix[3][2] = a_Matrix[3][0] * TranslationMatrix[0][2] + a_Matrix[3][1] * TranslationMatrix[1][2] +
			             a_Matrix[3][2] * TranslationMatrix[2][2] + a_Matrix[3][3] * TranslationMatrix[3][2];

		a_Matrix[3][3] = a_Matrix[3][0] * TranslationMatrix[0][3] + a_Matrix[3][1] * TranslationMatrix[1][3] +
			             a_Matrix[3][2] * TranslationMatrix[2][3] + a_Matrix[3][3] * TranslationMatrix[3][3];


		//Return the matrix now that it has been translated
		return a_Matrix;
	}

	///<summary>
	///Builds and returns a rotation 2D Array[4][4](Matrix4x4) created from a vector and an angle expressed in degrees.
	///<para></para>
	///<remarks><paramref name=" a_Vector"></paramref> -The vector to rotate by</remarks>
	///<remarks><paramref name=" a_Degrees"></paramref> -The degree to rotate by</remarks>
	///</summary>
	static int** Rotate(vec3 a_Vector, float a_Degrees)
	{
		int** RotationMatrix = nullptr;

		const int rows = 4;
		const int cols = 4;

		//Convert degrees to radians for the cos and sin functions to use
		float radians = (a_Degrees * 3.1415) / 180;

		RotationMatrix = new int*[rows];

		//Set RotationMatrix as an identity matrix
		for (int x = 0; x < rows; x++)
		{
			RotationMatrix[x] = new int[cols];
			for (int y = 0; y < cols; y++)
			{
				RotationMatrix[x][y] = (x == y) ? 1 : 0;

			}
		}

		//Check if x is not 0, if it is then we will use this rotation formula
		//This means we rotate on the x axis
		/* | 1  0       0       0 |
		| 0  cos(A) -sin(A)  0 |
		| 0  sin(A)  cos(A)  0 |
		| 0  0       0       1 |*/
		if (a_Vector.x > 0 || a_Vector.x < 0)
		{
			RotationMatrix[1][1] = cos(radians);
			RotationMatrix[1][2] = -sin(radians);
			RotationMatrix[2][1] = sin(radians);
			RotationMatrix[2][2] = cos(radians);
		}

		//Check if y is not 0, if it is then we will use this rotation formula
		//This means we rotate on the y axis
		/*| cos(A)  0  sin(A)  0 |
		| 0       1  0       0 |
		|-sin(A)  0  cos(A)  0 |
		| 0       0  0       1 |*/
		if (a_Vector.y > 0 || a_Vector.y < 0)
		{
			RotationMatrix[0][0] = cos(radians);
			RotationMatrix[2][0] = -sin(radians);
			RotationMatrix[0][2] = sin(radians);
			RotationMatrix[2][2] = cos(radians);
		}

		//Check if z is not 0, if it is then we will use this rotation formula
		//This means we rotate on the z axis
		/*| cos(A) -sin(A)   0   0 |
		| sin(A)  cos(A)   1   0 |
		| 0       0        0   0 |
		| 0       0        0   0 |*/
		if (a_Vector.z > 0 || a_Vector.z < 0)
		{
			RotationMatrix[0][0] = cos(radians);
			RotationMatrix[0][1] = -sin(radians);
			RotationMatrix[1][0] = sin(radians);
			RotationMatrix[1][1] = cos(radians);
		}

		return RotationMatrix;
	}

	///<summary>
	///Rotates and returns the passed in 2D Array[4][4](Matrix4x4) by the passed in degrees on the axis from the vector.
	///<para></para>
	///<remarks><paramref name=" a_Matrix"></paramref> -The matrix to rotate</remarks>
	///<remarks><paramref name=" a_Vector"></paramref> -The vector to rotate by</remarks>
	///<remarks><paramref name=" a_Degrees"></paramref> -The degree to rotate by</remarks>
	///</summary>
	static int** Rotate(int** a_Matrix, vec3 a_Vector, float a_Degrees)
	{
		//Convert degrees to radians for the cos and sin functions to use
		float radians = (a_Degrees * 3.1415) / 180;

		//Check if x is not 0, if it is then we will use this rotation formula
		//This means we rotate on the x axis
	/*  | 1  0       0       0 |
		| 0  cos(A) -sin(A)  0 |
		| 0  sin(A)  cos(A)  0 |
		| 0  0       0       1 |*/
		if (a_Vector.x > 0 || a_Vector.x < 0)
		{
			a_Matrix[1][1] = cos(radians);
			a_Matrix[1][2] = -sin(radians);
			a_Matrix[2][1] = sin(radians);
			a_Matrix[2][2] = cos(radians);
		}

		//Check if y is not 0, if it is then we will use this rotation formula
		//This means we rotate on the y axis
		/*| cos(A)  0  sin(A)  0 |
		| 0       1  0       0 |
		|-sin(A)  0  cos(A)  0 |
		| 0       0  0       1 |*/
		if (a_Vector.y > 0 || a_Vector.y < 0)
		{
			a_Matrix[0][0] = cos(radians);
			a_Matrix[2][0] = -sin(radians);
			a_Matrix[0][2] = sin(radians);
			a_Matrix[2][2] = cos(radians);
		}

		//Check if z is not 0, if it is then we will use this rotation formula
		//This means we rotate on the z axis
		/*| cos(A) -sin(A)   0   0 |
		| sin(A)  cos(A)   1   0 |
		| 0       0        0   0 |
		| 0       0        0   0 |*/
		if (a_Vector.z > 0 || a_Vector.z < 0)
		{
			a_Matrix[0][0] = cos(radians);
			a_Matrix[0][1] = -sin(radians);
			a_Matrix[1][0] = sin(radians);
			a_Matrix[1][1] = cos(radians);
		}

		return a_Matrix;
	}

	///<summary>
	///Builds and returns a 2D Array[4][4](Matrix4x4) that will be scaled according to the passed in vector
	///<para></para>
	///<remarks><paramref name=" a_Vector"></paramref> -The vector to scale by</remarks>
	///</summary>
	static int** Scale(vec3 a_Vector)
	{
		int** ScaleMatrix = nullptr;

		const int rows = 4;
		const int cols = 4;

		ScaleMatrix = new int*[rows];

		//Set ScaleMatrix as an identity matrix
		for (int x = 0; x < rows; x++)
		{
			ScaleMatrix[x] = new int[cols];

			for (int y = 0; y < cols; y++)
			{
				ScaleMatrix[x][y] = (x == y) ? 1 : 0;
			}
		}

		//Static set the main diagonal of matrix using passed in vector
		//The main diagonal is use for scaling a matrix when changing the values
		ScaleMatrix[0][0] = a_Vector.x;
		ScaleMatrix[1][1] = a_Vector.y;
		ScaleMatrix[2][2] = a_Vector.z;

		//Return the Scale matrix
		return ScaleMatrix;
	}

	///<summary>
	///Scales and returns the 2D Array[4][4](Matrix4x4) according to the passed in vector
	///<para></para>
	///<remarks><paramref name=" a_Matrix"></paramref> -The 2D Array[4][4](Matrix4x4) to scale</remarks>
	///<remarks><paramref name=" a_Vector"></paramref> -The vector to scale by</remarks>
	///</summary>
	static int** Scale(int** a_Matrix, vec3 a_Vector)
	{
		//int** ScaleMatrix = nullptr;

		//const int rows = 4;
		//const int cols = 4;

		//ScaleMatrix = new int*[rows];

		////Set ScaleMatrix as an identity matrix
		//for (int x = 0; x < rows; x++)
		//{
		//	ScaleMatrix[x] = new int[cols];

		//	for (int y = 0; y < cols; y++)
		//	{
		//		ScaleMatrix[x][y] = (x == y) ? 1 : 0;
		//	}
		//}

		//Static set the translation column of matrix using passed in vector
		a_Matrix[0][0] = a_Vector.x * a_Matrix[0][0];
		a_Matrix[1][1] = a_Vector.y * a_Matrix[1][1];
		a_Matrix[2][2] = a_Vector.y * a_Matrix[2][2];

		//Return the matrix now that it has been translated
		return a_Matrix;
	}

	///<summary>
	///Prints out the data of a 2D Array(Matrix4x4)
	///<para></para>
	///<remarks><paramref name=" a_Matrix"></paramref> -The 2D Array[4][4](Matrix4x4) to print</remarks>
	///</summary>
	static void Display4x4Matrix(int** a_Matrix)
	{
		double offset = sqrt(4 * 4) - 1;

		for (int x = 0; x < 4; x++)
		{
			std::cout << "| ";
			for (int y = 0; y < 4; y++)
			{
				std::cout << a_Matrix[x][y] << " | ";
				if (y == offset)
					std::cout << "\n";
			}
		}
	}
};

int main()
{
	int** yup = CreateIdentityMatrix(4, 4);

	int** RotMatrix = MatrixOperations::Rotate(yup, vec3(0.f, 1.f, 0.0f), 90.0f);
	
	MatrixOperations::Display4x4Matrix(RotMatrix);

	int tmp;
	std::cin >> tmp;

	return 0;

}

int** CreateIdentityMatrix(int rows, int columns)
{
	int** identityMatrix = nullptr;

	identityMatrix = new int*[rows];

	for (int x = 0; x < rows; x++)
	{
		identityMatrix[x] = new int[columns];

		for (int y = 0; y < columns; y++)
		{
			identityMatrix[x][y] = (x == y) ? 1 : 0;
		}
	}

	identityMatrix[0][3] = 2;
	identityMatrix[1][3] = 2;
	identityMatrix[2][3] = 2;

	return identityMatrix;
}
