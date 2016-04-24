import pygame
from Node import *

class Astar:
   #Initialize the Object
   def __init__(self, Start, Grid, Goal):
             #Create a List
             self.open = []
             #Visited Nodes
             self.closed = []
             #Setup goal node
             self.goal = Goal
             #Setup list to grid
             self.searchSpace = Grid
			 #Index of List
             self.index = Start
			 #Put first node into open list
             self.open.append(self.searchSpace[self.index])
         
   #Get Adjacent Nodes from the current passed in node
   def getAdjacent(self,index):
       #If next node is traversable and next node is not in the open list and not in the closed list and Does exist
       if(self.searchSpace[index + 1].traversable == True and self.searchSpace[index + 1] not in self.open and self.searchSpace[index + 1] not in self.closed and not self.searchSpace[index + 1] == None):
		#Set the G Score 
        self.searchSpace[index + 1].setG(10)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index + 1])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index + 1].parent = self.searchSpace[index]
         
	   #If previous node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index - 1].traversable == True and self.searchSpace[index - 1] not in self.open and self.searchSpace[index - 1] not in self.closed and not self.searchSpace[index - 1] == None):
		#Set the G Score 
        self.searchSpace[index - 1].setG(10)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index - 1])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index - 1].parent = self.searchSpace[index]
        
	   #If node below current node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index + 10].traversable == True and self.searchSpace[index + 10] not in self.open and self.searchSpace[index + 10] not in self.closed and not self.searchSpace[index + 10] == None):        
		#Set the G Score 
        self.searchSpace[index + 10].setG(10)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index + 10])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index + 10].parent = self.searchSpace[index]
		
	   #If node above current node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index - 10].traversable == True and self.searchSpace[index - 10] not in self.open and self.searchSpace[index - 10] not in self.closed and not self.searchSpace[index - 10] == None):
		#Set the G Score 
        self.searchSpace[index - 10].setG(10)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index - 10])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index - 10].parent = self.searchSpace[index]
		
	   #If node to the top right of current node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index - 9].traversable == True and self.searchSpace[index - 9] not in self.open and self.searchSpace[index - 9] not in self.closed and not self.searchSpace[index - 9] == None):
		#Set the G Score 
        self.searchSpace[index - 9].setG(14)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index - 9])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index - 9].parent = self.searchSpace[index]
		
	   #If node to the top left of current node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index - 11].traversable == True and self.searchSpace[index - 11] not in self.open and self.searchSpace[index - 11] not in self.closed and not self.searchSpace[index - 11] == None):
		#Set the G Score 
        self.searchSpace[index - 11].setG(14)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index - 11])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index - 11].parent = self.searchSpace[index]
		
	   #If node to the bottom right of current node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index + 11].traversable == True and self.searchSpace[index + 11] not in self.open and self.searchSpace[index + 11] not in self.closed and not self.searchSpace[index + 11] == None):
		#Set the G Score 
        self.searchSpace[index + 11].setG(14)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index + 11])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index + 11].parent = self.searchSpace[index]
		
		#If node to the bottom left of current node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index + 9].traversable == True and self.searchSpace[index + 9] not in self.open and self.searchSpace[index + 9] not in self.closed and not self.searchSpace[index + 9] == None):
		#Set the G Score 
        self.searchSpace[index + 9].setG(14)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index + 9])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index + 9].parent = self.searchSpace[index]

		
	   #At the end of the checking then we are done with the current node
	   #Remove it from open list
       self.open.remove(self.searchSpace[index])
	   #Add it to the closed list
       self.closed.append(self.searchSpace[index])
    
  #Going to sorting the list by F value
   def Sort(self,artosort):
    return sorted(artosort, key=lambda Node: Node.F)

   #Get LowestF Node currently in the self.open list
   def getLowestF(self,openlist):
        #Create empty list
        lowflist = []
		#Set the empty list to the sorted list
        lowflist = self.Sort(openlist)
		#Return the first node in the sorted list which will have the lowest F
        return lowflist[0].getI()
    
   #Run the Algorithm
   def Run(self):
   
    if(self.index != self.goal):
        print(self.searchSpace[self.index].getF())
	    #Look at adjacent nodes
        self.getAdjacent(self.index)
		#Set the current node to white
        self.searchSpace[self.index].setColor = (255,255,255)
		#The lowest f node was returned and is now current node
        self.index = self.getLowestF(self.open)
		#Set new current node to green
        self.searchSpace[self.index].setColor = (0,255,0)
    else:
	#print("Goal Reached")
	return False
	
		
	 
		
	
