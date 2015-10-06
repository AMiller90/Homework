#ifndef _TEMPLATE_H_
#define _TEMPLATE_H_

template<typename T, int N>
class Template
{
public:

	Template()
	{

	}
	Template(T N)
	{
		*items = new T[N];
		memset(items, 0, 0);
	}

	~Template()
	{
		delete [] items;
	}

	void add(T item)
	{
		if (items == 0)
		{
			*items = &item;
		}
		else
		{
			expand();
		}

	}
	void expand()
	{
		int *newArray = new T[N * 2];

		memcpy(newArray, items, 20);

		delete[] items;
	}
	T oper(T N)
	{
		for (int i = 0; i < N; ++i)
		{
			if (N == *items[i])
			{
				return *items[i];
			}
		}
		

	}

private:
	T *items[N];
};

#endif _TEMPLATE_H_