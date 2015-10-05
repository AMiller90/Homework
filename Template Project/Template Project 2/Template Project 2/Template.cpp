#include "Template.h"

template<typename T>
Template<T>::Template(T N)
{
	items = new T[N];
	memset(items, 0, 0);
}

template<typename T>
Template<T>::~Template<T>()
{
	delete[] items;
}

template<typename T>
void Template<T>::add(T item)
{
	if (items[i] == 0))
	{
		items[i] = item;
	}
	else
	{
		expand();
	}
		
	
}

template<typename T>
void Template<T>::expand()
{

}

template<typename T>
T Template<T>::oper(int N int& item)
{



}