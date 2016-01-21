#ifndef _COLOR_H_
#define _COLOR_H_


template<typename T>
class Color
{

public:
	//Constructor
	Color<T>();
	//Overloaded Constructor
	Color<T>(T R, T G, T B, T A);
	//Destructor
	~Color<T>();
	//Magnitude of Vectors
	float Mag(Color<T> &a);
	//Normalise Vectors
	Color Normalise(Color<T> &a);
	//Dot Product Vector
	T Dot(Color<T> &a, Color<T> &b);
	//Color Vector
	Color<T> HexConv(char[8]);

	//Variables for coordinates
	T r;
	T g;
	T b;
	T a;
};




#endif _COLOR_H_

//Constructor
template<typename T>
Color<T>::Color()
{


}

//Overloaded Constructor
template<typename T>
Color<T>::Color(T R, T G, T B, T A)
{//Initialize variables to passed in coordinates
	r = R;
	g = G;
	b = B;
	a = A;


}
//Destructor
template<typename T>
Color<T>::~Color()
{


}

//Add Vectors
template<typename T>
Color<T> operator +(Color<T> &a, Color<T> &b)
{
	//New Vector variable
	Color<T> c;
	//Add each r coordinate of 2 passed in vectors then store value into r value of new vector
	c.r = a.r + b.r;
	//Add each g coordinate of 2 passed in vectors then store value into g value of new vector
	c.g = a.g + b.g;
	//Add each b coordinate of 2 passed in vectors then store value into b value of new vector
	c.b = a.b + b.b;
	//Add each a coordinate of 2 passed in vectors then store value into a value of new vector
	c.a = a.a + b.a;
	//Return new vector
	return c;
}

//Subtract Vectors
template<typename T>
Color<T> operator -(Color<T> &a, Color<T> &b)
{
	//New Vector variable
	Color<T> c;
	//Subtract each r coordinate of 2 passed in vectors then store value into r value of new vector
	c.r = a.r - b.r;
	//Subtract each g coordinate of 2 passed in vectors then store value into g value of new vector
	c.g = a.g - b.g;
	//Subtract each b coordinate of 2 passed in vectors then store value into b value of new vector
	c.b = a.b - b.b;
	//Subtract each a coordinate of 2 passed in vectors then store value into a value of new vector
	c.a = a.a - b.a;
	//Return new vector
	return c;
}

//Multiply Vectors
template<typename T>
Color<T> operator *(Color<T> &a, Color<T> &b)
{//New Vector variable
	Color<T> c;
	//Multiply each r coordinate of 2 passed in vectors then store value into r value of new vector
	c.r = a.r * b.r;
	//Multiply each g coordinate of 2 passed in vectors then store value into g value of new vector
	c.g = a.g * b.g;
	//Multiply each b coordinate of 2 passed in vectors then store value into b value of new vector
	c.b = a.b * b.b;
	//Multiply each a coordinate of 2 passed in vectors then store value into a value of new vector
	c.a = a.a * b.a;
	//Return new vector
	return c;

}

//Divide Vectors
template<typename T>
Color<T> operator /(Color<T> &a, Color<T> &b)
{//New Vector variable
	Color<T> c;
	//Divide each r coordinate of 2 passed in vectors then store value into r value of new vector
	c.r = a.r / b.r;
	//Divideeach g coordinate of 2 passed in vectors then store value into g value of new vector
	c.g = a.g / b.g;
	//Divide each b coordinate of 2 passed in vectors then store value into b value of new vector
	c.b = a.b / b.b;
	//Divide each a coordinate of 2 passed in vectors then store value into a value of new vector
	c.a = a.a / b.a;
	//Return new vector
	return c;
}

//Modulus Vectors
template<typename T>
Color<T> operator %(Color<T> &a, Color<T> &b)
{//New Vector variable
	Color<T> c;
	//Divide each r coordinate of 2 passed in vectors then store value into r value of new vector
	c.r = a.r % b.r;
	//Divideeach g coordinate of 2 passed in vectors then store value into g value of new vector
	c.g = a.g % b.g;
	//Divide each b coordinate of 2 passed in vectors then store value into b value of new vector
	c.b = a.b % b.b;
	//Divide each a coordinate of 2 passed in vectors then store value into a value of new vector
	c.a = a.a % b.a;
	//Return new vector
	return c;
}

//Magnitude of Vectors
template<typename T>
float Color<T>::Mag(Color<T> &a)
{//Variable used to store squared values of passed in vector values
	T Asquared;
	//Variable to hold square root value
	float Asqrt;
	//Square each coordinate and all together then store into new variable
	Asquared = (a.r * a.r) + (a.g * a.g) + (a.b * a.b) + ( a.a * a.a);
	//Get the square root of the variable and store into a new variable
	Asqrt = sqrt(Asquared);

	//Return Magnitude as a float to be more precise
	return Asqrt;

}

//Normalise Vector
template<typename T>
Color<T> Color<T>::Normalise(Color<T> &a)
{//New Vector variable
	Color c;
	//Variable used to store squared values of passed in vector values
	T Asquared;
	//Variable to hold square root value
	float Asqrt;

	//Square each coordinate and all together then store into new variable
	Asquared = (a.r * a.r) + (a.g * a.g) + (a.b * a.b) + (a.a * a.a);

	//Get the square root of the variable and store into a new variable
	Asqrt = sqrt(Asquared);
	//Divide passed in r value by the square root value and get the new value and store it into r of new vector
	c.r = (a.r / Asqrt);
	//Divide passed in g value by the square root value and get the new value and store it into g of new vector
	c.g = (a.g / Asqrt);
	//Divide passed in b value by the square root value and get the new value and store it into b of new vector
	c.b = (a.b / Asqrt);
	//Divide passed in z value by the square root value and get the new value and store it into a of new vector
	c.a = (a.a / Asqrt);
	//Return the normalised vector
	return c;

}

//Dot Product Vector
template<typename T>
T Color<T>::Dot(Color<T> &a, Color<T> &b)
{//Multiply the passed in x values and the y values then add them together and return the product
	return (a.r * b.r) + (a.g * b.g) + (a.b * b.b) + (a.a * b.a);

}

//Function to convert hexadecimal to rgba values in a vector
template <typename T>
Color<T> Color<T>::HexConv(char Hex[8])
{
	//Create a temp variable for holding a number
	float temp;
	//Create an instance of a color object
	Color<float> Hexvec;

	//Checks the first index of the inputted value
	if (Hex[0] == '#')
	{//For Loop will loop through each index of the inputted array as long as its less than 7
		for (int i = 1; i < 7; i++)
		{//Checks if the current index is equal to 0
			if (Hex[i] == '0')
			{//set temp variable to 0
				temp = 0;
			}
			//Checks if the current index is equal to 1
			else if (Hex[i] == '1')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 16
					temp = 16;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 1
					temp = 1;
				}
			}
			//Checks if the current index is equal to 2
			else if (Hex[i] == '2')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 32
					temp = 32;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 2
					temp = 2;
				}
			}
			//Checks if the current index is equal to 3
			else if (Hex[i] == '3')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 48
					temp = 48;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 3
					temp = 3;
				}
			}
			//Checks if the current index is equal to 4
			else if (Hex[i] == '4')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 64
					temp = 64;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 4
					temp = 4;
				}
			}
			//Checks if the current index is equal to 5
			else if (Hex[i] == '5')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 80
					temp = 80;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 5
					temp = 5;
				}
			}
			//Checks if the current index is equal to 6
			else if (Hex[i] == '6')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 96
					temp = 96;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 6
					temp = 6;
				}
			}
			//Checks if the current index is equal to 7
			else if (Hex[i] == '7')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 112
					temp = 112;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 7
					temp = 7;
				}
			}
			//Checks if the current index is equal to 8
			else if (Hex[i] == '8')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 128
					temp = 128;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 8
					temp = 8;
				}
			}
			//Checks if the current index is equal to 9
			else if (Hex[i] == '9')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 144
					temp = 144;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 19
					temp = 9;
				}
			}
			//Checks if the current index is equal to A
			else if (Hex[i] == 'A')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 160
					temp = 160;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 10
					temp = 10;
				}
			}
			//Checks if the current index is equal to B
			else if (Hex[i] == 'B')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 176
					temp = 176;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 11
					temp = 11;
				}
			}
			//Checks if the current index is equal to C
			else if (Hex[i] == 'C')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 192
					temp = 192;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 12
					temp = 12;
				}
			}
			//Checks if the current index is equal to D
			else if (Hex[i] == 'D')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 208
					temp = 208;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 13
					temp = 13;
				}
			}
			//Checks if the current index is equal to E
			else if (Hex[i] == 'E')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 224
					temp = 224;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 14
					temp = 14;
				}
			}
			//Checks if the current index is equal to F
			else if (Hex[i] == 'F')
			{//if the current i in the loop is 1, 3, or 5
				if (i == 1 || i == 3 || i == 5)
				{//temp is set to 240
					temp = 240;
				}
				//if current i is not 1, 3, or 5
				else
				{//temp is set to 15
					temp = 15;
				}
			}
			else
			{//If inputted a value other than any of the ones above then set all values to 0 
				Hexvec.r = 0; Hexvec.g = 0; Hexvec.b = 0;
				//print out invalid code
				std::cout << "Invalid Code!\n";
				//break out statement
				break;

			}
			//if statement to check current value of i so the temp value can be assigned to the appropriate variable
			if (i == 1)
			{//r value is assigned the temp value
				Hexvec.r = temp;
			}
			//if statement to check current value of i so the temp value can be assigned to the appropriate variable
			else if (i == 2)
			{//r value is added and assigned the temp value
				Hexvec.r += temp;
			}
			//if statement to check current value of i so the temp value can be assigned to the appropriate variable
			else if (i == 3)
			{//g value is assigned the temp value
				Hexvec.g = temp;
			}
			//if statement to check current value of i so the temp value can be assigned to the appropriate variable
			else if (i == 4)
			{//g value is added and assigned the temp value
				Hexvec.g += temp;
			}
			//if statement to check current value of i so the temp value can be assigned to the appropriate variable
			else if (i == 5)
			{//b value is assigned the temp value
				Hexvec.b = temp;
			}
			//if statement to check current value of i so the temp value can be assigned to the appropriate variable
			else
			{//b value is added and assigned the temp value
				Hexvec.b += temp;
			}

			//end of for loop
		}
		//Set the a value to 255
		Hexvec.a = 255;

	}
	//If first inputted value was not a # symbol Then do this
	else
	{//Set values to 0 
		Hexvec.r = 0; Hexvec.g = 0; Hexvec.b = 0;
		//Print an error code
		std::cout << "Invalid Code!\n";
	}
	//Return The New Vector With The Converted Numbers
		return Hexvec;
	
}
