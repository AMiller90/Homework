#include<iostream>

void PerspectiveMatrix(float fieldOfView, float aspectRatio, float near, float far);
void OrthographicMatrix(float top, float bot, float right, float left, float near, float far);



int main()
{

	PerspectiveMatrix(1.f, (float)1080 / 720, 1.f, 1.f);

	OrthographicMatrix(0.f, 720.f, 1080.f, 0.0f, 1.f, 1.f);

	int tmp;
	std::cin >> tmp;

	return 0;
}

void PerspectiveMatrix(float fieldOfView, float aspectRatio, float near, float far)
{
	//Convert degrees to radians for the cos and sin functions to use
	float radians = (fieldOfView * 3.1415) / 180;

	int perspective[4][4];

	//perspective = new int*[4];
	for (int x = 0; x < 4; x++)
	{
		//perspective[x] = new int[4];

		for (int y = 0; y < 4; y++)
		{
			perspective[x][y] = (x == y) ? 1 : 0;
		}
	}

	perspective[3][2] = -1;
	perspective[3][3] = 0;


	perspective[0][0] = aspectRatio * 1 / tan(fieldOfView / 2);
	perspective[1][1] = 1 / tan(fieldOfView / 2);

	perspective[2][2] = -(far + near / far - near);
	perspective[2][3] = -(2 * far * near / far - near);

	for (int x = 0; x < 4; x++)
	{
		std::cout << "| ";
		for (int y = 0; y < 4; y++)
		{
			std::cout << perspective[x][y] << " | ";
			if (y == 3)
				std::cout << "\n";
		}
	}

	std::cout << std::endl;

}

void OrthographicMatrix(float top, float bot, float right, float left, float near, float far)
{
	int orthographic[4][4];

	for (int x = 0; x < 4; x++)
	{
		for (int y = 0; y < 4; y++)
		{
			orthographic[x][y] = (x == y) ? 1 : 0;
		}
	}

	orthographic[0][0] = 2 / right - left;
	orthographic[1][1] = 2 / top - bot;
	orthographic[2][2] = -2 / far - near;

	orthographic[0][3] = -(right + left / right - left);
	orthographic[1][3] = -(top + bot / top - bot);
	orthographic[2][3] = -(far + near / far - near);

	for (int x = 0; x < 4; x++)
	{
		std::cout << "| ";
		for (int y = 0; y < 4; y++)
		{
			std::cout << orthographic[x][y] << " | ";
			if (y == 3)
				std::cout << "\n";
		}
	}
}