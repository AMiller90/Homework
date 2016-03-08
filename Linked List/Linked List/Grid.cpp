#include "Grid.h"


Grid::Grid()
{

}

Grid::~Grid()
{

}


void Grid::CreateGrid()
{

	//Number of nodes
	Node* n[5];
	//Connection between the nodes
	Node* t;
	//Starting Node
	Node* Start;

	//Node 1
	n[0] = new Node;
	n[0]->index = 1;
	n[0]->name = "HP +";
	n[0]->stat = 100;
	t = n[0];
	Start = n[0];

	//Node 2
	n[1] = new Node;
	n[1]->index = 2;
	n[1]->name = "MP +";
	n[1]->stat = 100;
	t->next = n[1];
	t = t->next;
	
	//Node 3
	n[2] = new Node;
	n[2]->index = 3;
	n[2]->name = "Strength +";
	n[2]->stat = 5;
	t->next = n[2];
	t = t->next;

	//Node 4
	n[3] = new Node;
	n[3]->index = 4;
	n[3]->name = "Defense +";
	n[3]->stat = 5;
	t->next = n[3];
	t = t->next;
	
	//Node 5
	n[4] = new Node;
	n[4]->index = 5;
	n[4]->name = "Speed +";
	n[4]->stat = 5;
	t->next = n[4];
	t = t->next;
	//This sets the current node to be back at the starting node
	n[4]->next = Start;

	for (int i = 0; i < 5; i++)
	{
		cout << "Node" << "(" << n[i]->index << ") " << n[i]->name << " " << n[i]->stat << endl;
	}

}