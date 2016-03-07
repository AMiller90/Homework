#ifndef QUACK_H_
#define QUACK_H_

#include<iostream>

class Node
{
public:
	int data;
	Node* next;

};

template<typename T>
class Quack
{


public:

	Quack();
	~Quack();

	//Add a new element in front of first
	void push(T element);
	//Add a new element in front of first
	void enqueuer(T element);
	//Remove and return the first element
	T pop();
	//Remove and return the last element
	T dequeue();
	//Check if Quack is empty
	bool isEmpty();
	//Print the contents of the Quack from first to last
	void print();
	//Return the size of the quack
	int getSize();



private:
	//A pointer to the first node in the Quack
	Node* _first;
	//A pointer to the last node in the Quack
	Node* _last;
	//The number of elements currently in the stack
	int _size;

};


#endif

template<typename T>
Quack<T>::Quack()
{	
	_first = NULL;
	_last = NULL;
	
}

template<typename T>
Quack<T>::~Quack()
{

}

//Add a new element in front of first
template<typename T>
void Quack<T>::push(T element)
{
	if (_first == NULL)
	{
		_size += 1;
		_first = new Node;
		_first->data = element;
		cout << "Added: " << element << endl;
	}
	else
	{
		_first->data = element;
		cout << "Added: " << element << endl;
		_size += 1;
	}

}

//Add a new element in front of first
template<typename T>
void Quack<T>::enqueuer(T element)
{
	if (_last == NULL)
	{
		_size += 1;
		_last = new Node;
		_last->data = element;
		cout << "Added: " << element << endl;
	}
	else
	{
		_last->data = element;
		cout << "Added: " << element << endl;
		_size += 1;
	}
}

//Remove and return the first element
template<typename T>
T Quack<T>::pop()
{
	if (_size != NULL)
	{
		_size -= 1;
		cout << "Popped the first element: "<< _first->data << endl;
		_first->data = NULL;

		return _first->data;
		
	}
	else
	{
		cout << "Quack is Empty!\n";
	}
}

//Remove and return the last element
template<typename T>
T Quack<T>::dequeue()
{
	if (_size != NULL)
	{
		_size -= 1;
		cout << "Dequeued the last element: " << _last->data << endl;
		_last->data = NULL;

		return _last->data;
	}
	else
	{
		cout << "Quack is Empty!\n";
	}
}

//Check if Quack is empty
template<typename T>
bool Quack<T>::isEmpty()
{
	if (getSize() == NULL)
	{
		cout << "Quack is empty!\n";
		return true;
	}
	else
	{
		cout << "Quack is not empty!\n";
		return false;
	}
}

//Print the contents of the Quack from first to last
template<typename T>
void Quack<T>::print()
{
	if (_first != NULL)
	{
		cout << "First Element Is: " << _first->data << endl;
	}
	else
	{
		cout << "First Element Is Empty" << endl;
	}

	if (_last != NULL)
	{
		cout << "Last Element Is: " << _last->data << endl;
	}
	else
	{
		cout << "Last Element Is Empty" << endl;
	}
}

//Return the size of the quack
template<typename T>
int Quack<T>::getSize()
{
	return _size;
}


