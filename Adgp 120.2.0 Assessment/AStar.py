import pygame
from Node import *

class Astar:
   #Initialize the Object
   def __init__(self, Start, Grid, Goal):
             #Create a List
             self.open = []
             #Visited Nodes
             self.closed = []
             #Setup Starting node
             self.start = Start
             #Setup Current node
             self.currentNode = Start
             #Setup goal node
             self.goal = Goal
             #Setup list to grid
             self.searchSpace = Grid
             #Add the first node to the list
             self.open.append(Start) 
             
   #Run the Algorithm
   def Run(self):
       #Index of List
       index = 0
       
       #If next node is traversable and next node is not in the open list and not in the closed list and Does exist
       if(self.searchSpace[index + 1].traversable == True and self.searchSpace[index + 1] not in self.open and self.searchSpace[index + 1] not in self.closed and not self.searchSpace[index + 1] == None):
        #Add to open list because it is traversable
        self.open.append(self.searchSpace[index + 1])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index + 1].parent = self.searchSpace[index]
         
       #Test print
       print(self.searchSpace[index + 1].traversable)
         
   #Get Adjacent Nodes from the current passed in node
   def getAdjacent(cNode):
   #Check all surrounding nodes
    print("Checking Adjacents")
   
   #Get LowestF Node currently in the self.open list
   def getLowestF(openlist):
    #Check all open list nodes
    print("Checking LowestF")
    
   #Going to sorting the list by F value
   def Sort(artosort):
    return sorted(artosort, key=lambda Node: Node.F)