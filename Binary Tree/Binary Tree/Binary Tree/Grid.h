#ifndef GRID_H_
#define GRID_H_

#include<iostream>
#include<string>

using namespace std;

struct node
{
	string soaName;
	int NumofNode;
	string name;
	node* Left;
	node* Right;

};

class Grid
{

public:

	Grid();
	~Grid();

	void PrintInOrder();
	void ReturnRoot();
	void PrintChildren(int NumofNode);
	node* ReturnNode(int NumofNode);
	

private:

	node* Root;
	const unsigned int index[4] = { 22, 15, 1, 7 };
	node* Create(int NumofNode);
	node* Return(int NumofNode, node* n);
	void print(node* ptr);
	void Add(int NumofNode);
	void Addnext(int NumofNode, node* n);
};



#endif 
