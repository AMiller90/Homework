#include "Astar.h"
#include <windows.h>

//Default Constructor
Astar::Astar()
{
}

//Constructor for the algorithm
Astar::Astar(int a_Start, int a_Goal, int a_Rows, int a_Columns)
{//Functio used to setup the grid for the user
	SetGrid(a_Rows, a_Columns);
	//Set start node to the node at the index of the passed in start node integer
	m_StartNode = m_Grid[a_Start];
	//Set goal node to the node at the index of the passed in goal node integer
	m_GoalNode = m_Grid[a_Goal];
	//Set current node to the node at the index of the passed in start node integer
	m_CurrentNode = m_Grid[a_Start];
	//Number of rows is set
	m_Rows = a_Rows;
	//Number of columns is set
	m_Columns = a_Columns;
	//Function used to setup the nodes with H scores and adjacents nodes
	SetUp();
	
}

//Destructor
Astar::~Astar()
{//Function called that will delete the pointer nodes in the grid to clean up
	CleanUp();
}

//Function used the return the path taken from start to goal
vector<Node*> Astar::getPath(Node* a_Node)
{//Current node is set to the passed in node
	m_CurrentNode = a_Node;
	//While the current node is not equal to the start node
	while(m_CurrentNode != m_StartNode)
	{//Push the current nodes parent into the vector
		m_ReturnedPath.push_back(m_CurrentNode->getParent());
		//Set the current node to the current nodes parent
		m_CurrentNode = m_CurrentNode->getParent();
	}
	//Return the vector
	return m_ReturnedPath;
}

//Function used to check if the start node or goal node are walls
bool Astar::checkStartandEndNodes()
{
	//Create an int variable
	int wallCounter = 0;

	//If the start node is not walkable
	if (!m_StartNode->walkable())
	{//Let user know its not walkable
		cout << "ERROR: Start node is not walkable!\n";
		return false;
	}
		

	//Loop through the size of the adjacents vector of the start node
	for (int i = 0; i < m_StartNode->getAdjacents().size(); i++)
	{//The current adjacent node is not walkable
		if (!m_StartNode->getAdjacents()[i]->walkable())
			//Increment the counter
			wallCounter += 1;
	}

	//If the wallCounter is equal to the size of the adjacents vector in the start node
	//This means that all of its adjacents are walls or if the start node is not walkable
	if (wallCounter == m_StartNode->getAdjacents().size())
	{//Let user know there is an error
		cout << "\n\nERROR:ll adjacent nodes are walls\n";
		//break out of the function
		return false;
	}
	//Return true
	return true;
}

//Function used to set the H score of the passed in Node pointer
void Astar::setAdjacents(Node* a_Node)
{//If the vectors size is greater than or equal to 0
	if(a_Node->getAdjacents().size() >= 0)
	{
		//Integer that will be used as reference to bottom node from current passed in node
		int bot = a_Node->getID() + m_Rows;
		//Integer that will be used as reference to top node from current passed in node
		int top = a_Node->getID() - m_Columns;
		//Integer that will be used as reference to right node from current passed in node
		int right = a_Node->getID() + 1;
		//Integer that will be used as reference to left node from current passed in node
		int left = a_Node->getID() - 1;
		//Integer that will be used as reference to top right node from current passed in node
		int topRight = right - m_Rows;
		//Integer that will be used as reference to top left node from current passed in node
		int topLeft = top - 1;
		//Integer that will be used as reference to bottom right node from current passed in node
		int botRight = bot + 1;
		//Integer that will be used as reference to bottom left node from current passed in node
		int botLeft = bot - 1;

		//Vector integer used for the surrounding nodes
		vector<int> surroundingNodes;
		//Push all these integers into the vector
		surroundingNodes.push_back(bot);
		surroundingNodes.push_back(top);
		surroundingNodes.push_back(right);
		surroundingNodes.push_back(left);
		surroundingNodes.push_back(topRight);
		surroundingNodes.push_back(topLeft);
		surroundingNodes.push_back(botRight);
		surroundingNodes.push_back(botLeft);
		
		//Loop through the vector
		for (int i = 0; i < surroundingNodes.size(); i++)
		{//Create a variable to make code a bit cleaner
			int index = surroundingNodes[i];
			//If the current index is less than or equal to the grid size minus 1
			//and the index is greater than or equal to 0
			if (index <= m_Grid.size() - 1 && index >= 0)
			{//If the current node is walkable
				if (m_Grid[index]->walkable())
					//Set the current node as an adjacent to the passed in node
					a_Node->setAdjacents(m_Grid[index]);
			}
		}
			}
}

//Function used to set the H score of the passed in Node pointer
void Astar::setHScores(Node* a_Node)
{
	//Create an XDifference variable to store the difference between the Passed in Node XPos and Goal Node XPos
	int XDifference = a_Node->getX() - m_GoalNode->getX();
	//Create an XDifference variable to store the difference between the Passed in Node YPos and Goal Node YPos
	int YDifference = a_Node->getY() - m_GoalNode->getY();
	//Set the H Score of the current node equal to the absolute values of the XDifference and YDifference Values added together then multiplied by 10
	a_Node->setHScore((abs(XDifference) + abs(YDifference)) * 10);
}

//Function used to setup the nodes with H scores and adjacents nodes
void Astar::SetUp()
{//Loop through the grid
	for (int i = 0; i < m_Grid.size(); i++)
	{//Set the H Scores for each node
		setHScores(m_Grid[i]);
		//Set the adjacents for each node
		setAdjacents(m_Grid[i]);
	}
}

//Function used to sort the passed in vector by the F Score
Node* Astar::Sort(vector<Node*> a_Vector)
{//Create a temp vector
	vector<int> fscoresvector;
	//Initialize the pointer to null pointer
	Node* lowestF = nullptr;

	//Loop through the passed in vector
	for (int i = 0; i < a_Vector.size(); i++)
	{//Push the current node index F Score into the vector
		fscoresvector.push_back(a_Vector[i]->getFScore());
	}

	//This Function sorts the integers in Ascending order
	sort(fscoresvector.begin(), fscoresvector.end());

	//Loop through the passed in vector 
	for (int i = 0; i < a_Vector.size(); i++)
	{//If the first number of the vector(the lowest number) is equal to the
		//index of the passed in vectors F Score
		if (fscoresvector[0] == a_Vector[i]->getFScore())
			//Set the lowestF node to the current index node
			lowestF = a_Vector[i];
	}
	//Return the node
	return lowestF;
}

//Run the Algorithm
bool Astar::Run()
{	
		//Push the starting node into the openlist 
		m_OpenList.push_back(m_StartNode);
		//While the openlist is not empty
		while (m_OpenList.size() != 0)
		{//Set the current node to the returned node with the
		 //Lowest F Score
			m_CurrentNode = Sort(m_OpenList);
			//Find in the openlist the goalnode..if it is in the list
			if (find(m_OpenList.begin(), m_OpenList.end(), m_GoalNode) != m_OpenList.end())
			{//return the path from the goalnode and store the vector in the
			 //ReturnedPath vector
				m_ReturnedPath = getPath(m_GoalNode);
				cout << endl;
				//Set a handle so we can modify the console window
				HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
				//Set the console text to red
				SetConsoleTextAttribute(hConsole, 12);
				cout << "This is your Path!\n";
				//Loop through the ReturnedPath vector backwards
				for (int i = m_ReturnedPath.size() - 1; i >= 0; i--)
				{//Check if the current node is null or not
					if (m_ReturnedPath[i]->getParent() != nullptr)
						//Print out the id of the parent to show algorithm results
						cout << m_ReturnedPath[i]->getParent()->getID() << "->";
				}
				//Print out the goal nodes parent Id then the goal nodes id				
				cout << m_GoalNode->getParent()->getID() << "->" << m_GoalNode->getID();
				//Set the console text to gray
				SetConsoleTextAttribute(hConsole, 7);
				return false;
			}

			//Function returns an iterator which is used to iterate through a vector and return an iterator
			//pointing to a specific object..in this case it is the m_CurrentNode
			std::vector<Node*>::iterator currentNode = std::find(m_OpenList.begin(), m_OpenList.end(), m_CurrentNode);
			//If the current node is in the openlist
			if (currentNode != m_OpenList.end())
				//Then erase the currentnode
				m_OpenList.erase(currentNode);
			//Push the node into the closed list
			m_ClosedList.push_back(m_CurrentNode);

			int index = 0;
			//Variable to make code a bit clearer to read
			int size = m_CurrentNode->getAdjacents().size();

			//Loop through the adjacent nodes vector of the current node
			for (int i = 0; i < size; i++)
			{
				Node* node = m_CurrentNode->getAdjacents()[i];
				//The the current index node is walkable and not in the closed list
				if (node->walkable() && find(m_ClosedList.begin(), m_ClosedList.end(), node) != m_ClosedList.end() == false)
				{//If the current index node is not in the open list
					if (find(m_OpenList.begin(), m_OpenList.end(), node) != m_OpenList.end() == false)
					{//Push the node into the open list
						m_OpenList.push_back(node);
						//Set the nodes parent to the current node
						node->setParent(m_CurrentNode);
						int gscore = index < 4 ? 10 : 14;
						//Set the G score of the node
						node->setGScore(gscore);
					}
					else
					{
						int move = index < 4 ? 10 : 14;
						int cost = move + m_CurrentNode->getGScore();

						//If cost is less than the nodes G Score
						if (cost < node->getGScore())
						{//Set the nodes parent to the current node
							node->setParent(m_CurrentNode);
							//Set the nodes G Score
							node->setGScore(cost);
						}
					}
				}
				//Increment index
				index += 1;
			}

		}

	//Return true
	return true;
}

//Function called that will delete the pointer nodes in the grid to clean up
void Astar::CleanUp()
{
	//Delete the Node pointers in the grid vector
	for (int i = 0; i < m_Grid.size(); i++)
	{//Delete current node pointer
		delete m_Grid[i];
	}
}

//Functio used to setup the grid for the user
void Astar::SetGrid(int r, int c)
{//Variable for id
	int id = 0;
	//variable set to passed in r variable
	int rows = r;
	//variable set to passed in c variable
	int columns = c;
	//Set walls
	int walls[15] = { 21,31,41,51,61,71,81,13,23,33,43,53,63,73,82 };
	//Loop through the columns
	for (int x = 0; x < columns; x++)
	{//Loop through the rows
		for (int y = 0; y < rows; y++)
		{//Set up a node pointer
			Node* node;
			//Initialize node with passed in values
			node = new Node(x, y, id);

			//Create boolean values to set up wall boundaries
			bool LWall = x % columns == 0 ? true : false;
			bool RWall = x % columns == columns - 1 ? true : false;
			bool TWall = y % rows == 0 ? true : false;
			bool BWall = y % rows == rows - 1 ? true : false;

			//If any is true then set that node to be a wall
			if (LWall || RWall || TWall || BWall)
				node->setWalkable(false);

			//Loop through the walls
			for (int i = 0; i < walls[i]; i++)
			{//If the node id is the same as the index of the walls array
				if (node->getID() == walls[i])
				{//Set the node as a wall
					node->setWalkable(false);
				}
			}
			// Push the node into the grid vector
			m_Grid.push_back(node);
			//Increment the id variable
			id += 1;
		}
	}

	//Get the square root of the grid size minus 1
	int temp = sqrt(m_Grid.size() - 1);

	//Prompt user what is a wall 
	cout << "W Means It Is A Wall\n";

	//Loop through the grid
	for (int i = 0; i < m_Grid.size(); i++)
	{//Create an empty char variable
		char w = 'T';
		//Set a handle so we can modify the console window
		HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		//Set the console text to gray
		SetConsoleTextAttribute(hConsole, 7);
		if (!m_Grid[i]->walkable())
		{//Set a handle so we can modify the console window
			HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
			//Set the console text to blue
			SetConsoleTextAttribute(hConsole, 9);
			w = 'W';
		}
		//Print out the the id of each node
		cout << "[" << m_Grid[i]->getID() << w << "]";
		//If the y value of th current node is equal to the temp varable
		if (m_Grid[i]->getY() == temp)
		{//Print out a new line
			//This is to format the data like a grid to the screen
			cout << endl;
		}
	}
}
