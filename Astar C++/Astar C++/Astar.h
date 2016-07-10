#ifndef _ASTAR_H_
#define _ASTAR_H_

#include "Node.h"
#include "vector"
//Used to call the sort function
#include <algorithm>
#include <iostream>

class Astar
{
public:

	///<summary>
	///Default Constructor
	///</summary>
	Astar();

	///<summary>
	///Constructor
	///<para></para>
	///<remarks><paramref name=" a_Start"></paramref> -Node To Start At</remarks>
	///<para></para>
	///<remarks><paramref name=" a_Goal"></paramref> -Node To Reach</remarks>
	///<para></para>
	///<remarks><paramref name=" a_Rows"></paramref> -Number Of Rows In Grid</remarks>
	///<para></para>
	///<remarks><paramref name=" a_Columns"></paramref> -Number Of Columns In Grid</remarks>
	///</summary>
	Astar(int a_Start, int a_Goal, int a_Rows, int a_Columns);

	///<summary>
	///Destructor
	///</summary>
	~Astar();

	///<summary>
	///Run the Algorithm
	///</summary>
	bool Run();

private:
	//Vector to reference node pointers in the openlist
	vector<Node*> m_OpenList;
	//Vector to reference node pointers in the closedlist
	vector<Node*> m_ClosedList;
	//Vector to reference node pointers in the grid
	vector<Node*> m_Grid;
	//Vector to reference node pointers in the returned path
	vector<Node*> m_ReturnedPath;
	//Reference to rows in grid
	int m_Rows;
	//Reference to columns in grid
	int m_Columns;
	//Reference to the starting node
	Node* m_StartNode;
	//Reference to the goal node
	Node* m_GoalNode;
	//Reference to the current node
	Node* m_CurrentNode;

	///<summary>
	///Function used to set the adjacents of a passed in node pointer
	///</summary>
	void setAdjacents(Node* a_Node);

	///<summary>
	///Function used to set the H score of the passed in Node pointer
	///</summary>
	void setHScores(Node* a_Node);

	///<summary>
	///Function used to setup the nodes with H scores and adjacents nodes
	///</summary>
	void SetUp();

	///<summary>
	///Function called that will delete the pointer nodes in the grid to clean up
	///</summary>
	void CleanUp();

	///<summary>
	///Functio used to setup the grid for the user
	///</summary>
	void SetGrid(int r, int c);

	///<summary>
	///Function used to sort the passed in vector by the F Score
	///</summary>
	Node* Sort(vector<Node*> a_Vector);

	///<summary>
	///Function used the return the path taken from start to goal
	///</summary>
	vector<Node*> getPath(Node* a_Node);
};
#endif

