//Includes the stack class
#include "TheStack.h"

//constructor not used
TheStack::TheStack()
{
	
}

//deconstructor not used
TheStack::~TheStack()
{
}
//get the size of the stack
int TheStack::getsize()
{//returns stack size
	return size;
}
//set the size of the stack
void TheStack::setsize(int& s)
{
	//passes in new stack size and sets it to size variable
	size = s;

}
//pushes node into the stack
void TheStack::Push(Node* n)
{
	cout << "Added Node:\n";
	//if top is not equal to 0
		if (top != 0)
		{   //take the node passed in and set it to top node
			top = n;
		}
		else
		{  //else the node passed in points to top node
			n->next = top;
			//set top node to passed in node
			top = n;
		}
		//increase size of stack
		size++;
		//set new size of stack
		setsize(size);
}
//looks at top node of the stack
void TheStack::Top()
{
	
	//if top is equal to 0
	if (top == 0)
	{//print the stack is empty
		cout << "Stack Is Empty\n";
	}
	else{
		//else print out the stack size
		cout << "Stack size is: " << getsize() << endl;
		//print the top node to screen
		cout << "Top Node: " << top->num << endl;
	}
		

}
//pops top node off stack
void TheStack::Pop()
{
	//subtract one from the size of the stack
	size--;
	//set the size of stack to new size
	setsize(size);
	//the top node points to the next node
	top = top->next;
	//print out popped node 
	cout << "Popped Node:\n";
	//Print out the stack size
	cout << "Stack size is now: " << getsize() << endl;
}