#ifndef _VECTOR2_H_
#define _VECTOR2_H_



template<typename T>
class Vector2
{

public:
	//Constructor
	Vector2<T>();
	//Overloaded Constructor
	Vector2<T>(T x, T y);
	//Destructor
	~Vector2<T>();
	//Magnitude of Vectors
	T Mag(Vector2<T> &a);
	//Normalise Vectors
	Vector2<T>Normalise(Vector2<T> &a);
	//Dot Product Vector
	T Dot(Vector2<T> &a, Vector2<T> &b);
	//SquareRoot Function
	T SquareRoot(T &num);

	//Variables for coordinates
	T x;
	T y;
};




#endif _VECTOR2_H_

//Constructor
template<typename T>
Vector2<T>::Vector2()
{


}

//Overloaded Constructor
template<typename T>
Vector2<T>::Vector2(T X, T Y)
{
	//Initialize variables to passed in coordinates
	x = X;
	y = Y;


}

//Destructor
template<typename T>
Vector2<T>::~Vector2()
{


}

//Add Vectors
template<typename T>
Vector2<T> operator +(Vector2<T> &a, Vector2<T> &b)
{//New Vector variable
	Vector2<T> c;
	//Add each x coordinate of 2 passed in vectors then store value into x value of new vector
	c.x = a.x + b.x;
	//Add each y coordinate of 2 passed in vectors then store value into y value of new vector
	c.y = a.y + b.y;

	//Return new vector
	return c;
}

//Subtract Vectors
template<typename T>
Vector2<T> operator -(Vector2<T> &a, Vector2<T> &b)
{//New Vector variable
	Vector2<T> c;
	//Subtract each x coordinate of 2 passed in vectors then store value into x value of new vector
	c.x = a.x - b.x;
	//Subtract each y coordinate of 2 passed in vectors then store value into y value of new vector
	c.y = a.y - b.y;

	//Return new vector
	return c;
}

//Multiply Vectors
template<typename T>
Vector2<T> operator *(Vector2<T> &a, Vector2<T> &b)
{//New Vector variable
	Vector2<T> c;
	//Square each x coordinate of 2 passed in vectors then store value into x value of new vector
	c.x = a.x * b.x;
	//Square each y coordinate of 2 passed in vectors then store value into y value of new vector
	c.y = a.y * b.y;

	//Return new vector
	return c;
}

//Divide Vectors
template<typename T>
Vector2<T> operator /(Vector2<T> &a, Vector2<T> &b)
{//New Vector variable
	Vector2<T> c;

	//Check is either vector is going to have a 0 in their x or y components
	if (a.x == 0 || a.y == 0)
	{//Print Error Message
		std::cout << "Error! Can't Divide By 0\n";
		//If so then just return the vectors
		return Vector2<T>(a.x, a.y);
	}

	//Check is either vector is going to have a 0 in their x or y components
	if (b.x == 0 || b.y == 0)
	{//Print Error Message
		std::cout << "Error! Can't Divide By 0\n";
		//If so then just return the vectors
		return Vector2<T>(b.x, b.y);
	}

	//Divide each x coordinate of 2 passed in vectors then store value into x value of new vector
	c.x = a.x / b.x;
	//Divide each y coordinate of 2 passed in vectors then store value into y value of new vector
	c.y = a.y / b.y;

	//Return new vector
	return c;
}

//Modulus Vectors
template<typename T>
Vector2<T> operator %(Vector2<T> &a, Vector2<T> &b)
{//New Vector variable
	Vector2<T> c;

	//Check is either vector is going to have a 0 in their x or y components
	if (a.x == 0 || a.y == 0)
	{//Print Error Message
		std::cout << "Error! Can't Divide By 0\n";
		//If so then just return the vectors
		return Vector2<T>(a.x, a.y);
	}

	//Check is either vector is going to have a 0 in their x or y components
	if (b.x == 0 || b.y == 0)
	{//Print Error Message
		std::cout << "Error! Can't Divide By 0\n";
		//If so then just return the vectors
		return Vector2<T>(b.x, b.y);
	}
	//Divide each x coordinate of 2 passed in vectors then store remainder value into x value of new vector
	c.x = a.x % b.x;
	//Divide each y coordinate of 2 passed in vectors then store remainder value into y value of new vector
	c.y = a.y % b.y;

	//Return new vector
	return c;
}

//Magnitude of Vectors
template<typename T>
T Vector2<T>::Mag(Vector2<T> &a)
{//Variable used to store squared values of passed in vector values
	T Asquared;
	//Variable to hold square root value
	T Asqrt;
	//Square each coordinate and all together then store into new variable
	Asquared = (a.x * a.x) + (a.y * a.y);
	//Get the square root of the variable and store into a new variable
	Asqrt = SquareRoot(Asquared);

	//Return Magnitude as a float to be more precise
	return Asqrt;
}

//Normalise Vectors
template<typename T>
Vector2<T> Vector2<T>::Normalise(Vector2<T> &a)
{//New Vector variable
	Vector2 c;
	//Variable used to store squared values of passed in vector values
	T Asquared;
	//Variable to hold square root value
	T Asqrt;

	//Square each coordinate and all together then store into new variable
	Asquared = (a.x * a.x) + (a.y * a.y);

	//Get the square root of the variable and store into a new variable
	Asqrt = SquareRoot(Asquared);
	//Divide passed in x value by the square root value and get the new value and store it into x of new vector
	c.x = (a.x / Asqrt);
	//Divide passed in y value by the square root value and get the new value and store it into y of new vector
	c.y = (a.y / Asqrt);

	//Return the normalised vector
	return c;

}


//Dot Product Vector
template<typename T>
T Vector2<T>::Dot(Vector2<T> &a, Vector2<T> &b)
{//Multiply the passed in x values and the y values then add them together and return the product
	return (a.x * b.x) + (a.y * b.y);

}

template<typename T>
//Function used to calculate the square root of passed in variable
 T Vector2<T>::SquareRoot(T &num)
{//Dynamic Checks At Runtime for data type
	T d_a = num;
	//if num entered is greater than or equal to 0
	if (d_a >= 0)
	{//set variable to num
		T d_x = num;
		//create a new variable
		int i;
		//Each time i is incremented
		for (i = 0; i < 20; i++)
		{//run this math equation
			d_x = (((d_x * d_x) + num) / (2 * d_x));
		}
		//returns the new x value
		return d_x;
	}
	//returns num
	return num;
}