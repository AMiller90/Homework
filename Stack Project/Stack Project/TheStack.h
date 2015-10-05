//Preprocessor Directives - If Not Defined Then Define 
#ifndef _THESTACK_H_
#define _THESTACK_H_

//includes the input/output stream
#include<iostream>

//uses namepspace std 
using namespace std;

//create a node struct
struct Node
{//will contain an int variable
	int num;
	//will contain a Node Pointer called next
	Node* next;
};

//Create TheStack Class
class TheStack
{
public:
	//constructor
	TheStack();
	//deconstructor
	~TheStack();

	//top function
	void Top();
	//push function
	void Push(Node* n);
	//pop function
	void Pop();
	//getsize function
	int getsize();
	//setsize function
	void setsize(int& s);

private:
	//private node pointer
	Node* top;
	//int variable used to tell the size of the stack
	int size;
};

//Ends The Inclusion Of This Class
#endif