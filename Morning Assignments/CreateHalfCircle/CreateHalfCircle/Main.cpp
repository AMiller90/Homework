#include<iostream>
#include<vector>

//09/13/16
//Write a function that takes arguments to create a half circle.
//Parameters should be radius, number of points and the return value should be the half circle

struct Vertex
{
	float X;
	float Y;
	float Z;
	float W;

};

Vertex* GenerateHalfCircle(const int& radius, const int& np, Vertex* vertices)
{
	int pieces = np - 1;

	for (int i = 0; i < np; i++)
	{
		float theta = 3.14159265359 * i / pieces;
		double X = radius * cos(theta);
		double Y = radius * sin(theta);

		vertices[i].X = X;
		vertices[i].Y = Y;
		vertices[i].Z = 0;

	}

	return vertices;
}

int main()
{
	Vertex verts[5];

	GenerateHalfCircle(5, 5, verts);

	for (int i = 0; i < 4; i++)
	{
		std::cout << "Vert index: " << i << " " << verts[i].X << "," << verts[i].Y << "," << verts[i].Z << "\n";
	}

	int tmp;
	std::cin >> tmp;
	return 0;
}