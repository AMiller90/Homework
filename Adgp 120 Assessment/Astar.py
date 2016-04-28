#Import pygame to reference it
import pygame
#Import everything from Node
from Node import *

#Set title of screen
pygame.display.set_caption("Adgp 120 Assessment")

#Set the dimensions of the game window
size = width, height = 640, 360

#Set the Size Of The Game Window
screen = pygame.display.set_mode(size)

class Astar:
   #Initialize the Object
   def __init__(self, SearchSpace, Start, Goal, Rows, Cols):
             #Create an Open List
             self.Open = []
             #Create a Closed List
             self.Closed = []
             #Create a PATH List
             self.PATH = []
             #Set grid to searchSpace
             self.grid = SearchSpace
             #Set start to Start
             self.start = Start
             #Set goal to Goal
             self.goal = Goal
             #Set current to start
             self.current = self.start
             #Set rows to Rows
             self.rows = Rows
             #Set cols to Cols
             self.cols = Cols
   
   #Get the current node
   def getCurrent(self):
     #Return the current node
     return self.current
   
   #Set the current node
   def setCurrent(self,value):
       #Set the current node to value
       self.current = value
   
   #Function for getting the path from start to goal
   def getPath(self, node):
       #Create a new path list 
       path = []
       #Set the current node to the passed in node
       self.setCurrent(node)
       #While the current node is not the start node
       while(self.current != self.start):
           #Append the current nodes parent to the path list
           path.append(self.getCurrent().parent)
           #Set the current node to the current nodes parent
           self.setCurrent(self.getCurrent().parent)
       #Return the path
       return path
           
   #Set the adjacents of the current node
   def setAdjacents(self, node):  
        #If the adjacents count is not equal to 0
        if node.adjacents.count != 0:
            #Create bot node set to current node id + number of rows
            bot = node.getID() + self.rows
            #Create top node set to current node id - number of cols
            top = node.getID() - self.cols
            #Create right node set to current node id + 1
            right = node.getID() + 1
            #Create left node set to current node id - 1
            left = node.getID()  - 1
            #Create topright node set to right - rows
            topright = right - self.rows
            #Create topleft node set to top - 1
            topleft = top - 1
            #Create botright node set to bot + 1
            botright = bot + 1
            #Create botleft node set to bot - 1
            botleft = bot - 1
            #Create a surroundingNodes list varaiable and set its value to the multiple adjacents
            surroundingNodes = [bot, top, right, left, topright, topleft, botright, botleft]
        
        #Loop through the adjacents
        for i in surroundingNodes:
            #Check if the i is less than or equal to the length of the grid minus 1
            if i <= len(self.grid) - 1:
                #If the current node is traversable
                if self.grid[i].passable() == True:
                    #Append the node to the adjacents list for this specific node
                    node.adjacents.append(self.grid[i])
                    #print(self.grid[i].getID(), "Current Index ", node.getID())

   #Function for sorting a list
   def Sort(self, artosort):
     #Sort the list by F Value
     sorted(artosort, key=lambda Node: Node.F)   
   
   #Function to set the H Scores
   def setHScores(self, node):
    #If the node is traversable
    if node.passable() == True:
        #Divide the xPos by 25
        Sx = node.xPos / 25
        #Divide the yPos by 25
        Sy = node.yPos / 25
        #Divde the goal nodes xPos by 25
        Gx = self.goal.xPos / 25
        #Divde the goal nodes yPos by 25
        Gy = self.goal.yPos / 25
        
        #Subtract the Start nodes x from the Goal nodes x and store in a new variable
        num1 = Gx - Sx
        #Subtract the Start nodes y from the Goal nodes y and store in a new variable
        num2 = Gy - Sy
        #Add the 2 values together
        sum = num1 + num2
        #Set the H Score According to the sum value multiplied by 10
        node.setH(sum * 10)
        #print(node.getH())
   
   #Function used to setUp the nodes with adjacents and H Scores
   def setUp(self):
        #Loop through the grid
        for n in self.grid:
            #Store the current node in a new variable
            node = self.grid[n.getID()]
            #Pass the node in to check for adjacents to that node
            self.setAdjacents(node)
            #Set the H score for that node
            self.setHScores(self.grid[n.getID()])
            
   #Run the Algorithm
   def Run(self):
   
    #Loop through the grid
    for n in self.grid:
     #Draw the nodes to the screen
     n.draw(screen)
            
    #Call the setUp Function
    self.setUp()
    #Append the Start node to the open list
    self.Open.append(self.start)
    
    #While the open list is not empty
    while self.Open.count != 0:
        #Sort the open list by the F Value for each node
        self.Sort(self.Open)
        #Grab the first node in the list and set it as the current node
        self.setCurrent(self.Open[0])
        #If the goal node is in the open list
        if(self.goal in self.Open):
            #Set the PATH List with the returned list 
            self.PATH = self.getPath(self.goal)
            #Loop through the List 
            for n in self.PATH:
                #Print the Id for each node to show the algorithm works
                #The result should print the path from the goal node back to the starting node
                print(n.getID())
            return False;
        
        #Remove the current node from the open list
        self.Open.remove(self.getCurrent())
        #Append the current node to the closed list
        self.Closed.append(self.getCurrent())
        
        #Create an i variable and set it 0
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
                    a.parent = self.getCurrent()
                    #The first 4 nodes in the adjacents list will be either left,right,top or bottom. They will all have 10 as a g score
                    #The rest of the nodes are diagonals and there g score is 14
                    #Set Gnum variable accordingly
                    Gnum = 10 if i < 4 else 14
                    #Set the nodes G score
                    a.setG(Gnum)
                #If the current adjacent node is already in the open list
                else:
                    #Find out how much it will be to move to each of the nodes in the adjacent list
                    #If the current index i less than 4 then move will be set to 10 else it will be set to 14
                    move = 10 if i < 4 else 14
                    #Add the move and current units g score to get the total move cost
                    cost = move + self.getCurrent().getG()
                    #If the total move cost is less than the current adjacents g score
                    if cost < a.getG():
                        #Set the adjacents parent to the current node
                        a.parent = self.getCurrent()
                        #Set the adjacent nodes g score to the total move cost
                        a.setG(cost)
                        
            #Increment by one so we can loop through the adjacent nodes         
            i+=1
        
        
    
        
            
            
                    
