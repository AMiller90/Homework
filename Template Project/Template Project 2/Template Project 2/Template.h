#ifndef _TEMPLATE_H_
#define _TEMPLATE_H_

template<typename T, int N>
class Template
{
public:

	Template<T, N>();
	Template<T, N>(T,int N);

	~Template<T, N>();
	void add(T item);
	void expand();
	T oper(int N);
	
private:
	T *items[N];
};

#endif _TEMPLATE_H_

template<typename T, int N>
Template<T, N>::Template()
{

}
template<typename T, int N>
Template<T, N>::Template(T, int N)
{
	*items = new [N];
	memset(items, 0, 0);
}

template<typename T, int N>
Template<T, N>::~Template()
{
	delete[] items;
}

template<typename T, int N>
void Template<T, N>::add(T item)
{
	if (items == 0)
	{
		*items = &item;
	}
	else
	{
		expand();
		*items = &item;
	}

}

template<typename T, int N>
void Template<T, N>::expand()
{
	T *newArray = new T[N * 2];

	memcpy(newArray, items, 20);

	//delete[] items;
}

template<typename T, int N>
T Template<T, N>::oper(int iN)
{
	for (int i = 0; i < N; ++i)
	{
		if (iN == *items[i])
		{
			return *items[i];
		}
	}
}