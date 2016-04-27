import pygame
from Node import *

class Astar:
   #Initialize the Object
   def __init__(self, SearchSpace, Start, Goal, Rows, Cols):
   #Create a List
             self.Open = []
             self.Closed = []
             self.PATH = []
             self.grid = SearchSpace
             self.start = Start
             self.goal = Goal
             self.current = self.start
             self.rows = Rows
             self.cols = Cols
             
             #self.setUp()
             
   def getCurrent(self):
     return self.current
        
   def setCurrent(self,value):
       self.current = value
        
   def getPath(self, node):
       path = []
       self.setCurrent(node)
       node.setColor((0,255,0))
       while(self.current != self.start):
           path.append(self.current)
           self.setCurrent(self.current.parent)
           return path
           
   def setAdjacents(self, node):  
        if node.adjacents.count != 0:
            node.adjacents = []
            r = self.rows
            c = self.cols
            bot = node.getID() + r
            top = node.getID() - c
            right = node.getID() + 1
            left = node.getID()  - 1
            topright = right - r
            topleft = top - 1
            botright = bot + 1
            botleft = bot - 1
            
            surroundingNodes = [bot, top, right, left, topright, topleft, botright, botleft]
        
        for i in surroundingNodes:
            if i <= len(self.grid) - 1:
                if self.grid[i].passable() == True:
                    node.adjacents.append(self.grid[i])
                    #print(self.grid[i].getID(), "Current Index ", node.getID())

   #Going to sorting the list by F value
   def Sort(artosort):
     sorted(artosort, key=lambda Node: Node.F)   
   
   def setHScores(self, node):
    #Divide position by 25 to get the 0 - 9
    if node.passable() == True:
        Sx = node.xPos / 25
        Sy = node.yPos / 25
    
        Gx = self.goal.xPos / 25
        Gy = self.goal.yPos / 25
    
        num1 = Gx - Sx
        num2 = Gy - Sy

        node.setH((num1 + num2) * 10)
        #print(node.getH())
    
   def setUp(self):
   
        for n in self.grid:
            num = n.getID()   
            node = self.grid[num]
            self.setAdjacents(node)
            self.setHScores(self.grid[num])
            
   #Run the Algorithm
   def Run(self):
   
    self.setUp()
    self.Open.append(self.start)

    while self.Open:
        sorted(self.Open, key=lambda Node: Node.F)
        self.current = self.Open[0]
        self.current.setColor((0,255,0))
        
        if(self.goal in self.Open):
            self.PATH = self.getPath(self.goal)
            return False;
            
        self.Open.remove(self.current)
        self.Closed.append(self.current)
        
        i = 0
        #Loop through the nodes in the current nodes adjacents list
        for a in self.current.adjacents:
            #If the current adjacent node is passable and not in the closed list
            if a.passable() and a not in self.Closed:
                #If the current adjacent node is not in the open list
                if a not in self.Open:
                    #Add to the open list
                    self.Open.append(a)
                    #Set the parent to the current node
                    a.parent = self.current
                    #The first 4 nodes in the adjacents list will be either left,right,top or bottom. They will all have 10 as a g score
                    #The rest of the nodes are diagonals and there g score is 14
                    Gnum = 10 if i < 4 else 14
                    a.setG(Gnum)
                #If the current adjacent node is already in the open list
                else:
                    #Find out how much it will be to move to each of the nodes in the adjacent list
                    move = 10 if i < 4 else 14
                    #Add the move and current units g score to get the total move cost
                    cost = move + self.current.getG()
                    #If the total move cost is less than the adjacents g score
                    if cost < a.getG():
                        #Set the adjacents parent to the current node
                        a.parent = self.current
                        #Set the adjacent nodes g score to the total move cost
                        a.setG(cost)
                        
            #Increment by one so we can loop through the adjacent nodes         
            i+=1
        
            
            
                    
