//includes input/output stream
#include<iostream>
//includes the stack class
#include "TheStack.h"

//uses namespace std
using namespace std;

//Stack Implementation
//1) It Does Not Need To Be A Template - done
//2) It Only Needs To Be Able To Push Elements "Add" Them To The Stack - done
//3) Pop Elements "Remove" Them From The Stack - done
//4) Peek The Top Of The Stack "Look At The Last Element Pushed Onto It" - done
//5) Check If Its Empty - done
//6) Keep Track Of The Size - done

int main()
{
	
	//Create instance of class TheStack
	TheStack<char> sStack;

	//Creates instances of 3 nodes called temp, temp2, and temp3
	Node<char> Temp;
	Node<char> Temp2;
	Node<char> Temp3;
	//Creates instance of node called Node1 and Sets it to address of temp
	Node<char> *Node1 = &Temp;
	//Creates instance of node called Node2 and Sets it to address of temp2
	Node<char> *Node2 = &Temp2;
	//Creates instance of node called Node3 and Sets it to address of temp3
	Node<char> *Node3 = &Temp3;

	//node1 num is set to 1
	Node1->num = 'A';
	//mode 1 points to next node and it is set to node2
	Node1->next = Node2;
	//node2 num is set to 2
	Node2->num = 'B';
	//mode 2 points to next node and it is set to node3
	Node2->next = Node3;
	//node3 num is set to 5
	Node3->num = 'C';


	//calls the push function
	sStack.Push(Node1);
	//calls the top function
	sStack.Top();
	//calls the push function
	sStack.Push(Node2);
	//calls the top function
	sStack.Top();
	//calls the push function
	sStack.Push(Node3);
	//calls the top function
	sStack.Top();
	//calls the pop function
	sStack.Pop();

	cout << endl;

	system("PAUSE");
	return 0;
}