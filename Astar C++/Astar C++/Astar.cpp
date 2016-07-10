#include "Astar.h"
#include <windows.h>

Astar::Astar()
{
}

Astar::Astar(int a_Start, int a_Goal, int a_Rows, int a_Columns)
{
	SetGrid(a_Rows, a_Columns);
	m_StartNode = m_Grid[a_Start];
	m_GoalNode = m_Grid[a_Goal];
	m_CurrentNode = m_Grid[a_Start];
	m_Rows = a_Rows;
	m_Columns = a_Columns;
	SetUp();
	
}

Astar::~Astar()
{
	CleanUp();
	cout << "deleted";
}

vector<Node*> Astar::getPath(Node* a_Node)
{
	m_CurrentNode = a_Node;

	while(m_CurrentNode != m_StartNode)
	{
		m_ReturnedPath.push_back(m_CurrentNode->getParent());
		m_CurrentNode = m_CurrentNode->getParent();
	}

	return m_ReturnedPath;
}

void Astar::setAdjacents(Node* a_Node)
{
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

		vector<int> surroundingNodes;
		surroundingNodes.push_back(bot);
		surroundingNodes.push_back(top);
		surroundingNodes.push_back(right);
		surroundingNodes.push_back(left);
		surroundingNodes.push_back(topRight);
		surroundingNodes.push_back(topLeft);
		surroundingNodes.push_back(botRight);
		surroundingNodes.push_back(botLeft);

		for (int i = 0; i < surroundingNodes.size(); i++)
		{
			int index = surroundingNodes[i];
			if (index <= m_Grid.size() - 1 && index >= 0)
			{
				if (m_Grid[index]->walkable())
					a_Node->setAdjacents(m_Grid[index]);
			}
		}
			}
}

void Astar::setHScores(Node* a_Node)
{
	//Create an XDifference variable to store the difference between the Passed in Node XPos and Goal Node XPos
	int XDifference = a_Node->getX() - m_GoalNode->getX();
	//Create an XDifference variable to store the difference between the Passed in Node YPos and Goal Node YPos
	int YDifference = a_Node->getY() - m_GoalNode->getY();
	//Set the H Score of the current node equal to the absolute values of the XDifference and YDifference Values added together then multiplied by 10
	a_Node->setHScore((abs(XDifference) + abs(YDifference)) * 10);
}

void Astar::SetUp()
{
	for (int i = 0; i < m_Grid.size(); i++)
	{
		setHScores(m_Grid[i]);
		setAdjacents(m_Grid[i]);
	}
}

Node* Astar::Sort(vector<Node*> a_Vector)
{
	vector<int> fscoresvector;
	Node* lowestF = nullptr;

	for (int i = 0; i < a_Vector.size(); i++)
	{
		fscoresvector.push_back(a_Vector[i]->getFScore());
	}

	sort(fscoresvector.begin(), fscoresvector.end());

	for (int i = 0; i < a_Vector.size(); i++)
	{
		if (fscoresvector[0] == a_Vector[i]->getFScore())
			lowestF = a_Vector[i];
	}

	return lowestF;
}

bool Astar::Run()
{
	m_OpenList.push_back(m_StartNode);

	while (m_OpenList.size() != 0)
	{
		m_CurrentNode = Sort(m_OpenList);

		if(find(m_OpenList.begin(), m_OpenList.end(), m_GoalNode) != m_OpenList.end())
		{
			m_ReturnedPath = getPath(m_GoalNode);
			cout << endl;
			HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
			SetConsoleTextAttribute(hConsole, 12);
			cout << "This is your Path!\n";
			for (int i = m_ReturnedPath.size() - 1; i >= 0; i--)
			{
				if(m_ReturnedPath[i]->getParent() != nullptr)
					cout << m_ReturnedPath[i]->getParent()->getID() << "->";
			}
			cout << m_GoalNode->getParent()->getID() << "->" << m_GoalNode->getID();
			return false;
		}

		std::vector<Node*>::iterator currentNode = std::find(m_OpenList.begin(), m_OpenList.end(), m_CurrentNode);
		if(currentNode != m_OpenList.end())
			m_OpenList.erase(currentNode);
		
		m_ClosedList.push_back(m_CurrentNode);

		int index = 0;

		int size = m_CurrentNode->getAdjacents().size();

		for (int i = 0; i < size; i++)
		{
			Node* node = m_CurrentNode->getAdjacents()[i];

			if (node->walkable() && find(m_ClosedList.begin(), m_ClosedList.end(), node) != m_ClosedList.end() == false)
			{
				if (find(m_OpenList.begin(), m_OpenList.end(), node) != m_OpenList.end() == false)
				{
					m_OpenList.push_back(node);

					node->setParent(m_CurrentNode);
					int gscore = index < 4 ? 10 : 14;
					node->setGScore(gscore);
				}
				else
				{
					int move = index < 4 ? 10 : 14;
					int cost = move + m_CurrentNode->getGScore();

					if (cost < node->getGScore())
					{
						node->setParent(m_CurrentNode);
						node->setGScore(cost);
					}
				}
			}

			index += 1;
		}

	}
	return true;
}

void Astar::CleanUp()
{
	//Delete the Node pointers in the grid vector
	for (int i = 0; i < m_Grid.size(); i++)
	{
		delete m_Grid[i];
	}
}

void Astar::SetGrid(int r, int c)
{
	int id = 0;
	int rows = r;
	int columns = c;
	int walls[15] = { 21,31,41,51,61,71,81,13,23,33,43,53,63,73,82 };
	for (int x = 0; x < columns; x++)
	{
		for (int y = 0; y < rows; y++)
		{
			Node* node;
			node = new Node(x, y, id);

			bool LWall = x % columns == 0 ? true : false;
			bool RWall = x % columns == columns - 1 ? true : false;
			bool TWall = y % rows == 0 ? true : false;
			bool BWall = y % rows == rows - 1 ? true : false;

			if (LWall || RWall || TWall || BWall)
				node->setWalkable(false);

			for (int i = 0; i < walls[i]; i++)
			{
				if (node->getID() == walls[i])
				{
					node->setWalkable(false);
				}
			}

			m_Grid.push_back(node);
			id += 1;
		}
	}

	int temp = sqrt(m_Grid.size() - 1);

	cout << "T Means Traversable\n";
	cout << "W Means It Is A Wall\n";

	for (int i = 0; i < m_Grid.size(); i++)
	{
		char w = 'T';
		HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 7);
		if (!m_Grid[i]->walkable())
		{
			HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
			SetConsoleTextAttribute(hConsole, 9);
			w = 'W';
		}

		cout << "[" << m_Grid[i]->getID() << w << "]";
		if (m_Grid[i]->getY() == temp)
		{
			cout << endl;
		}
	}
}
