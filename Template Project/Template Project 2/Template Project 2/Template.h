#ifndef _TEMPLATE_H_
#define _TEMPLATE_H_

template<typename T>
class Template
{
public:
	Template<T>(T N);

	~Template();

	void add(T item);
	void expand();
	T oper(int N int &item);

private:
	T *items[N];
};

#endif _TEMPLATE_H_