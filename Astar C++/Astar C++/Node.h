#ifndef _NODE_H_
#define _NODE_H_

#include<vector>
#include <iostream>
using namespace std;

class Node
{

public:
	///<summary>
	///Default Constructor
	///</summary>
	Node();

	///<summary>
	///Constructor
	///<para></para>
	///<remarks><paramref name=" a_X"></paramref> -X position</remarks>
	///<para></para>
	///<remarks><paramref name=" a_Y"></paramref> -Y position</remarks>
	///<para></para>
	///<remarks><paramref name=" a_Id"></paramref> -Node Id</remarks>
	///<para></para>
	///</summary>
	Node(int a_X, int a_Y, int a_Id);

	///<summary>
	///Function used to return the Parent node of a node
	///</summary>
	Node* getParent();
	
	///<summary>
	///Function used to set the parent node of another node
	///<para></para>
	///<remarks><paramref name=" a_Parent"></paramref> - Node to set as a parent</remarks>
	///<para></para>
	///</summary>
	void setParent(Node* a_Parent);

	///<summary>
	///Function used to return the vector of adjacent node pointers for a node
	///</summary>
	vector<Node*> getAdjacents();

	///<summary>
	///Function used to set the adjacents of a node pointer
	///<para></para>
	///<remarks><paramref name=" a_Node"></paramref> - Node to set adjacents to</remarks>
	///<para></para>
	///</summary>
	void setAdjacents(Node* a_Node);

	///<summary>
	///Function used to get the X Position of a node
	///</summary>
	int getX();

	///<summary>
	///Function used to get the Y position of a node
	///</summary>
	int getY();

	///<summary>
	///Function used to get the Id of a Node
	///</summary>
	int getID();

	///<summary>
	///Function used to get the G Score of a node
	///</summary>
	int getGScore();

	///<summary>
	///Function used to get the H Score of a node
	///</summary>
	int getHScore();

	///<summary>
	///Function used to get the F Score of a node
	///</summary>
	int getFScore();

	///<summary>
	///Function used to determine whether a node is traversable or not
	///</summary>
	bool walkable();
	
	///<summary>
	///Function used to set true or false to whether a node is walkable or not
	///<para></para>
	///<remarks><paramref name=" a_Walkable"></paramref> - true or false value</remarks>
	///<para></para>
	///</summary>
	void setWalkable(bool a_Walkable);

	///<summary>
	///Function used to set the G Score of a node
	///<para></para>
	///<remarks><paramref name=" a_GScore"></paramref> - number to set to the G score of a node</remarks>
	///<para></para>
	///</summary>
	void setGScore(int a_GScore);

	///<summary>
	///Function used to set the H score of a node
	///<para></para>
	///<remarks><paramref name=" a_Parent"></paramref> - number to set to the H Score of a node</remarks>
	///<para></para>
	///</summary>
	void setHScore(int a_HScore);

	
private:
	//Vector used to store adjacent node pointers of a node
	vector<Node*> m_AdjacentNodes;
	//Reference to the Node pointer that will be a parent of another node
	Node* m_Parent;
	//Reference to true or false value
	bool m_Traversable;
	//Reference to a node Id
	int m_Id;
	//Reference to a Node F Score
	int m_FScore;
	//Reference to a Node G Score
	int m_GScore;
	//Reference to a Node H Score
	int m_HScore;
	//Reference to a Node X Position
	int m_Xpos;
	//Reference to a Node Y Position
	int m_Ypos;

};
#endif
