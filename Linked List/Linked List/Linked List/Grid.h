#ifndef GRID_H_
#define GRID_H_

#include<iostream>
#include<string>

using namespace std;

class Grid
{

public:


	Grid();
	~Grid();

	//Create the grid
	void CreateGrid();

private:

	//Noone else can construct more nodes
	struct Node
	{
		//Index of node to keep track
		int index;
		//Stat to increase
		int stat;
		//Name of stat/ability
		string name;
		//Pointer to next node
		Node* next;

	};

};



#endif
