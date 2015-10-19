#ifndef _VECTOR_H_
#define _VECTOR_H_


template<typename T>
class Vector3
{

public: 

	Vector3<T>();
	Vector3<T>(T x, T y, T z);
	~Vector3<T>();

	Vector3 Add(Vector3 &a, Vector3 &b);
	Vector3 Sub(Vector3 &a, Vector3 &b);
	Vector3 Multiply(Vector3 &a, Vector3 &b);
	void Mag(Vector3 &a, Vector3 &b);
	//Vector3 Normalise(Vector3 &a, Vector3 &b);
	

	int x;
	int y;
	int z;
	

private:


};




#endif _VECTOR_H_

template<typename T>
Vector3<T>::Vector3()
{


}

template<typename T>
Vector3<T>::Vector3(T X, T Y, T Z)
{
	x = X;
	y = Y;
	z = Z;


}

template<typename T>
Vector3<T>::~Vector3()
{


}

template<typename T>
Vector3<T> Vector3<T>::Add(Vector3 &a,Vector3 &b)
{
	Vector3<int> c;
	c.x = a.x + b.x;
	c.y = a.y + b.y;
	c.z = a.z + b.z;

	return c;
}

template<typename T>
Vector3<T> Vector3<T>::Sub(Vector3 &a, Vector3 &b)
{
	Vector3<int> c;
	c.x = a.x - b.x;
	c.y = a.y - b.y;
	c.z = a.z - b.z;

	return c;
}

template<typename T>
void Vector3<T>::Mag(Vector3 &a, Vector3 &b)
{
	T Asquared;
	T Bsquared;
	float Asqrt;
	float Bsqrt;

	Asquared = (a.x * a.x) + (a.y * a.y) + (a.z * a.z);
	Bsquared = (b.x * b.x) + (b.y * b.y) + (b.z * b.z);

	Asqrt = sqrt(Asquared);
	Bsqrt = sqrt(Bsquared);

	std::cout << "Magnitude of a is: " << Asqrt << " and Magnitude of b is: " << Bsqrt << std::endl;
}

//template<typename T>
//Vector3<T> Vector3<T>::Normalise(Vector3 &a, Vector3 &b)
//{
// 
//
//
//}

template<typename T>
Vector3<T> Vector3<T>::Multiply(Vector3 &a, Vector3 &b)
{
	Vector3<int> c;
	c.x = a.x * b.x;
	c.y = a.y * b.y;
	c.z = a.z * b.z;

	return c;

}