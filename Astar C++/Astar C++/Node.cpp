#include "Node.h"

//Default Constructor
Node::Node()
{
}

//Constructor For constructing the node
Node::Node(int a_X, int a_Y, int a_Id)
{
	//Set the parent variable to null pointer
	m_Parent = nullptr;
	//Set traversable to default to true
	m_Traversable = true;
	//Set Xpos to passed in variable
	m_Xpos = a_X;
	//Set Ypos to passed in variable
	m_Ypos = a_Y;
	//Set Id to passed in variable
	m_Id = a_Id;
	//Set default F Score to 0
	m_FScore = 0;
	//Set default G Score to 0
	m_GScore = 0;
	//Set default H Score to 0
	m_HScore = 0;
}

//Function used to return the Parent node of a node
Node* Node::getParent()
{//Return parent node
	return m_Parent;
}

//Function used to set the parent node of another node
void Node::setParent(Node* a_Node)
{//Parent node is set to the passed in variable 
	m_Parent = a_Node;
}

//Function used to return the vector of adjacent node pointers for a node
vector<Node*> Node::getAdjacents()
{//Return the adjacent nodes vector
	return m_AdjacentNodes;
}

//Function used to set the adjacents of a node pointer
void Node::setAdjacents(Node* a_Node)
{//Push the passedin node in to the adjacents vector
	m_AdjacentNodes.push_back(a_Node);
}

//Function used to determine whether a node is traversable or not
bool Node::walkable()
{//Return the true or false value of whether or not node is traversable or not
	return m_Traversable;
}

//Function used to set true or false to whether a node is walkable or not
void Node::setWalkable(bool a_walkable)
{//Set the traversable value to passed in value
	m_Traversable = a_walkable;
}

//Function used to set the G Score of a node
void Node::setGScore(int a_GScore)
{//Set the G score to the passed in variable
	m_GScore = a_GScore;
	//Set the F Score to the G Score + the H Score
	m_FScore = m_GScore + m_HScore;
}

//Function used to set the H score of a node
void Node::setHScore(int a_HScore)
{//Set the H score to the passed in variable
	m_HScore = a_HScore;
	//Set the F Score to the G Score + the H Score
	m_FScore = m_GScore + m_HScore;
}

//Function used to get the X Position of a node
int Node::getX()
{//Return the X Position
	return m_Xpos;
}

//Function used to get the Y Position of a node
int Node::getY()
{//Return the Y Position
	return m_Ypos;
}

//Function used to get the Id of a Node
int Node::getID()
{//Return the Id 
	return m_Id;
}

//Function used to get the G Score of a node
int Node::getGScore()
{//Return the G Score
	return m_GScore;
}

//Function used to get the H Score of a node
int Node::getHScore()
{//Return the H Score
	return m_HScore;
}

//Function used to get the F Score of a node
int Node::getFScore()
{//Return the F Score
	return m_FScore;
}
