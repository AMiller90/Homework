//Preprocessor Directives - If Not Defined Then Define 
#ifndef _THESTACK_H_
#define _THESTACK_H_

//includes the input/output stream
#include<iostream>
#include<string>
//uses namepspace std 
using namespace std;
template<typename N>
//create a node class
class Node
{
public:
	//will contain a T variable
	N num;
	//will contain a Node Pointer called next
	Node<N>* next;
};

template<typename T>
//Create TheStack Class
class TheStack
{
public:
	//constructor
	TheStack<T>();
	//deconstructor
	~TheStack<T>();

	//top function
	void Top();
	//push function
	void Push(Node<T>* n);
	//pop function
	void Pop();
	//getsize function
	int getsize();
	//setsize function
	void setsize(int& N);

private:
	//private node pointer
	Node<T>* top;
	//int variable used to tell the size of the stack
	int size;
};

//Ends The Inclusion Of This Class
#endif

template<typename T>
//constructor
TheStack<T>::TheStack()
{

}
template<typename T>
//deconstructor
TheStack<T>::~TheStack()
{
	
}
template<typename T>
//top function
void TheStack<T>::Top()
{

	//if top is equal to 0
	if (top == 0)
	{//print the stack is empty
		cout << "Stack Is Empty\n";
	}
	else {
		//else print out the stack size
		cout << "Stack size is: " << getsize() << endl;
		//print the top node to screen
		cout << "Top Node: " << top->num  << endl;
	}

}
template<typename T>
//push function
void TheStack<T>::Push(Node<T>* n)
{
	cout << "Added Node:\n";
	//if top is not equal to 0
	if (top != 0)
	{   //take the node passed in and set it to top node
		top = n;
	}
	else
	{  //else the node passed in points to top node
		n->next = top;
		//set top node to passed in node
		top = n;
	}
	//increase size of stack
	size++;
	//set new size of stack
	setsize(size);
}

template<typename T>
//pop function
void TheStack<T>::Pop()
{
	//subtract one from the size of the stack
	size--;
	//set the size of stack to new size
	setsize(size);
	//the top node points to the next node
	top = top->next;
	//print out popped node 
	cout << "Popped Node:\n";
	//Print out the stack size
	cout << "Stack size is now: " << getsize() << endl;
}
template<typename T>
//getsize function
int TheStack<T>::getsize()
{//returns stack size
	return size;

}
template<typename T>
//setsize function
void TheStack<T>::setsize(int& s)
{
	//passes in new stack size and sets it to size variable
	size = s;
}