#include "Grid.h"
#include<iostream>

Grid::Grid()
{
    //Make sure the root pointer is not pointing to anything when created
	Root = NULL;

}

Grid::~Grid()
{


}


void Grid::Add(int NumofNode)
{
	Addnext(NumofNode, Root);
}


void Grid::PrintInOrder()
{
	for (int i = 0; i < 4; i++)
	{
		Add(index[i]);
	}

	//Print in order
	print(Root);

}

node* Grid::ReturnNode(int NumofNode)
{
	return Return(NumofNode, Root);

}

void Grid::ReturnRoot()
{
	if (Root != NULL)
	{
		cout << "Root Node is: " << Root->NumofNode;
	}
	else
	{
		cout << "No Root Node!";
	}
}

void Grid::PrintChildren(int NumofNode)
{
	node* ptr = ReturnNode(NumofNode);

	if (ptr != NULL)
	{
		cout << "Node = " << ptr->NumofNode << endl;

		ptr->Left == NULL ?
		cout << "Left Child = Null\n":
		cout << "Left Child = " << ptr->Left->NumofNode << endl;

		ptr->Right == NULL ?
			cout << "Right Child = Null\n" :
			cout << "Right Child = " << ptr->Right->NumofNode << endl;
	}
	else
	{
		cout << "Node is not in the tree\n";
	}
}


//This will create a new node
node* Grid::Create(int NumofNode)
{
	//Create the new node that is going to be created 
	node* n = new node;
	n->NumofNode = NumofNode;
	n->soaName = "HP Node: ";
	//Make sure the new pointers are set to null
	n->Left = NULL;
	n->Right = NULL;

	return n;

}

node* Grid::Return(int NumofNode, node* n)
{
	if (n != NULL)
	{
		if (n->NumofNode == NumofNode)
		{
			return n;
		}
		else
		{
			if (NumofNode < n->NumofNode)
			{
				return Return(NumofNode, n->Left);
			}
			else
			{
			    return Return(NumofNode, n->Right);
		
			}

		}
	}
	else
	{
		return NULL;
	}
}

void Grid::print(node* ptr)
{
	//If Grid is not empty
	if (Root != NULL)
	{
		//If its possible to go left
		if (ptr->Left != NULL)
		{
			print(ptr->Left);
		}
		
		cout << ptr->soaName;
		cout << ptr->NumofNode << "\n";

		//If its possible to go right
		if (ptr->Right != NULL)
		{
			print(ptr->Right);
		}

		
	}
	//else if grid is empty
	else
	{
		cout << "No Grid Created!\n";
	}
}

void Grid::Addnext(int NumofNode, node* n)
{
	//If empty
	if (Root == NULL)
	{//Create node and set it to root
		Root = Create(NumofNode);
	}
	//else if the next node i want to add is less than the current nodes number
	else if (NumofNode < n->NumofNode)
	{//then we go left
		if (n->Left != NULL)
		{//Move to 
			Addnext(NumofNode, n->Left);
		}
		else
		{
			n->Left = Create(NumofNode);
		}
	}
	//else if the next node i want to add is greater than the current nodes number
	else if (NumofNode > n->NumofNode)
	{//then we go right
		if (n->Right != NULL)
		{//Move to 
			Addnext(NumofNode, n->Right);
		}
		else
		{
			n->Right = Create(NumofNode);
		}
	}
	else
	{
		cout << "The Number " << NumofNode << "has already been added to the tree\n";
	}

}