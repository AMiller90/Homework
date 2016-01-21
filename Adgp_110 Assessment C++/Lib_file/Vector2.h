#ifndef _VECTOR2_H_
#define _VECTOR2_H_


template<typename T>
class Vector2
{

public:
	//Constructor
	Vector2();
	//Overloaded Constructor
	Vector2(T x, T y);
	//Destructor
	~Vector2();
	//Magnitude of Vectors
	float Mag(Vector2<T> &a);
	//Normalise Vectors
	Vector2 Normalise(Vector2<T> &a);
	//Dot Product Vector
	T Dot(Vector2<T> &a, Vector2<T> &b);
	
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
{
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
{
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
{
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
{
	Vector2<T> c;
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
{
	Vector2<T> c;
	//Divide each x coordinate of 2 passed in vectors then store remainder value into x value of new vector
	c.x = a.x % b.x;
	//Divide each y coordinate of 2 passed in vectors then store remainder value into y value of new vector
	c.y = a.y % b.y;

	//Return new vector
	return c;
}

//Magnitude of Vectors
template<typename T>
float Vector2<T>::Mag(Vector2<T> &a)
{//Variable used to store squared values of passed in vector values
	T Asquared;
	//Variable to hold square root value
	float Asqrt;
	//Square each coordinate and all together then store into new variable
	Asquared = (a.x * a.x) + (a.y * a.y);
	//Get the square root of the variable and store into a new variable
	Asqrt = sqrt(Asquared);

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
	float Asqrt;

	//Square each coordinate and all together then store into new variable
	Asquared = (a.x * a.x) + (a.y * a.y);

	//Get the square root of the variable and store into a new variable
	Asqrt = sqrt(Asquared);
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
