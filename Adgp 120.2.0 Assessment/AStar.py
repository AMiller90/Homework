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
        self.searchSpace[index].setColor((0,255,0))

        #At the end of the checking then we are done with the current node
        #Remove it from open list
        self.open.remove(self.searchSpace[index])
        #Add it to the closed list
        self.closed.append(self.searchSpace[index])

       #Right check
        if(not index == 99):
        #If right node is traversable and right node is not in the open list and not in the closed list and Does exist
            if(self.searchSpace[index + 1].traversable == True and self.searchSpace[index + 1] not in self.open and self.searchSpace[index + 1] not in self.closed and not self.searchSpace[index + 1] == None and not index % 10 == 9):
            #self.searchSpace[index + 1].setColor((0,255,0))
            #Set the G Score 
                self.searchSpace[index + 1].setG(self.searchSpace[index].getG() + 10)
                #Add to open list because it is traversable
                self.open.append(self.searchSpace[index + 1])
                #Set adjacent nodes parent to the current node comparing
                self.searchSpace[index + 1].parent = self.searchSpace[index]
                print self.searchSpace[index + 1].yPos, ",", self.searchSpace[index + 1].xPos , " Right"
       
       #Left Check
        if(not index == 0):
           #If left node is traversable and left node is not in the open list and not in the closed list and Does exist
            if(self.searchSpace[index - 1].traversable == True and self.searchSpace[index - 1] not in self.open and self.searchSpace[index - 1] not in self.closed and not self.searchSpace[index - 1] == None and not index % 10 == 0):
                 #self.searchSpace[index - 1].setColor((0,255,0))
                 #Set the G Score 
                 self.searchSpace[index - 1].setG(self.searchSpace[index].getG() + 10)
                 #Add to open list because it is traversable
                 self.open.append(self.searchSpace[index - 1])
                 #Set adjacent nodes parent to the current node comparing
                 self.searchSpace[index - 1].parent = self.searchSpace[index]
                 print self.searchSpace[index - 1].yPos, ",", self.searchSpace[index - 1].xPos, " Left"
       
       #Bottom Check
        if(not index >= 90):
       #If node below current node is traversable and next node is not in the open list and not in the closed list and Does exist
            if(self.searchSpace[index + 10].traversable == True and self.searchSpace[index + 10] not in self.open and self.searchSpace[index + 10] not in self.closed and not self.searchSpace[index + 10] == None):        
             #self.searchSpace[index + 10].setColor((0,255,0))
             #Set the G Score 
             self.searchSpace[index + 10].setG(self.searchSpace[index].getG() + 10)
             #Add to open list because it is traversable
             self.open.append(self.searchSpace[index + 10])
             #Set adjacent nodes parent to the current node comparing
             self.searchSpace[index + 10].parent = self.searchSpace[index]
             print self.searchSpace[index + 10].yPos, ",", self.searchSpace[index + 10].xPos, " Bottom"
       
       #Top Check
        if(index > 9):
        #If node above current node is traversable and next node is not in the open list and not in the closed list and Does exist
            if(self.searchSpace[index - 10].traversable == True and self.searchSpace[index - 10] not in self.open and self.searchSpace[index - 10] not in self.closed and not self.searchSpace[index - 10] == None):
             #self.searchSpace[index - 10].setColor((0,255,0))
             #Set the G Score 
             self.searchSpace[index - 10].setG(self.searchSpace[index].getG() + 10)
             #Add to open list because it is traversable
             self.open.append(self.searchSpace[index - 10])
             #Set adjacent nodes parent to the current node comparing
             self.searchSpace[index - 10].parent = self.searchSpace[index]
             print self.searchSpace[index - 10].yPos, ",", self.searchSpace[index - 10].xPos, " Top"
         
       #Top Right Check
        if(not index <= 9 and not index > 98 and not index % 10 == 9):
       #If node to the top right of current node is traversable and next node is not in the open list and not in the closed list and Does exist
            if(self.searchSpace[index - 9].traversable == True and self.searchSpace[index - 9] not in self.open and self.searchSpace[index - 9] not in self.closed and not self.searchSpace[index - 9] == None):
             #self.searchSpace[index - 9].setColor((0,255,0))
             #Set the G Score 
             self.searchSpace[index - 9].setG(self.searchSpace[index].getG() + 14)
             #Add to open list because it is traversable
             self.open.append(self.searchSpace[index - 9])
             #Set adjacent nodes parent to the current node comparing
             self.searchSpace[index - 9].parent = self.searchSpace[index]
             print self.searchSpace[index - 9].yPos, ",", self.searchSpace[index - 9].xPos, " Top Right"
         
       #Top Left Check
        if(not index <= 11 and not index > 99 and not index % 10 == 0):
       #If node to the top left of current node is traversable and next node is not in the open list and not in the closed list and Does exist
            if(self.searchSpace[index - 11].traversable == True and self.searchSpace[index - 11] not in self.open and self.searchSpace[index - 11] not in self.closed and not self.searchSpace[index - 11] == None):
             #self.searchSpace[index - 11].setColor((0,255,0))
             #Set the G Score 
             self.searchSpace[index - 11].setG(self.searchSpace[index].getG() + 14)
             #Add to open list because it is traversable
             self.open.append(self.searchSpace[index - 11])
             #Set adjacent nodes parent to the current node comparing
             self.searchSpace[index - 11].parent = self.searchSpace[index]
             print self.searchSpace[index - 11].yPos, ",", self.searchSpace[index - 11].xPos, " Top Left"
       
       #Bottom Right Check
        if(not index >= 89 and not index % 10 == 9):
            #If node to the bottom right of current node is traversable and next node is not in the open list and not in the closed list and Does exist
            if(self.searchSpace[index + 11].traversable == True and self.searchSpace[index + 11] not in self.open and self.searchSpace[index + 11] not in self.closed and not self.searchSpace[index + 11] == None):
             #self.searchSpace[index + 11].setColor((0,255,0))
             #Set the G Score 
             self.searchSpace[index + 11].setG(self.searchSpace[index].getG() + 14)
             #Add to open list because it is traversable
             self.open.append(self.searchSpace[index + 11])
             #Set adjacent nodes parent to the current node comparing
             self.searchSpace[index + 11].parent = self.searchSpace[index]
             print self.searchSpace[index + 11].yPos, ",", self.searchSpace[index + 11].xPos, " Bottom Right"
       
       #Bottom Left Check
        if(not index % 10 == 0 and not index > 89):
           #If node to the bottom left of current node is traversable and next node is not in the open list and not in the closed list and Does exist
            if(self.searchSpace[index + 9].traversable == True and self.searchSpace[index + 9] not in self.open and self.searchSpace[index + 9] not in self.closed and not self.searchSpace[index + 9] == None):
             #self.searchSpace[index + 9].setColor((0,255,0))
             #Set the G Score 
             self.searchSpace[index + 9].setG(self.searchSpace[index].getG() + 14)
             #Add to open list because it is traversable
             self.open.append(self.searchSpace[index + 9])
             #Set adjacent nodes parent to the current node comparing
             self.searchSpace[index + 9].parent = self.searchSpace[index]
             print self.searchSpace[index + 9].yPos, ",", self.searchSpace[index + 9].xPos, " Bottom Left"          
     
  #Going to sorting the list by F value
    def Sort(self,artosort):
        return sorted(artosort, key=lambda Node: Node.F)
    
     #Going to sorting the list by F value
    def SortG(self,artosort):
        return sorted(artosort, key=lambda Node: Node.G)

   #Get LowestF Node currently in the self.open list
    def getLowestF(self):
          
        self.searchSpace[self.index].setColor((0,255,0))
        #Create empty list
        lowflist = []
        #Set the empty list to the sorted list
        lowflist = self.Sort(self.open)

        #lowflist[0].setColor((255,255,255))
        #Return the first node in the sorted list which will have the lowest F
        return lowflist[0].getI()

   #Run the Algorithm
    def Run(self, screen):
        #start = self.Start
        #goal = self.Goal
        #self.open.append(start)
        
        
        #while self.open:
            #The lowest f node was returned and is now current node
            #current = self.getLowestF()
            #self.closed.append(current)
            
            if(self.goal in self.open):
                return False
            
            #for i in current.adjacents:
               # if i not in self.open:
                    #self.open.append(i)
                    #i.g = 
            #The lowest f node was returned and is now current node
            self.index = self.getLowestF()

            #Look at adjacent nodes
            self.getAdjacent(self.index)


            return True
        
        


        #if(self.goal in self.open):
          #return False
        
        #n = self.searchSpace[self.index]
        
        #if n.parent:
        
         #currentrect = pygame.Rect(n.xPos, n.yPos, n.width, n.height)
         #parentrect = pygame.Rect(n.parent.xPos, n.parent.yPos, n.parent.width, n.parent.height)
         
         #parentmid = (parentrect.centerx, parentrect.centery)
         #selfmid = (currentrect.centerx, currentrect.centery)
         #pygame.draw.aaline(screen, (0,255,0), selfmid, parentmid,False)
 
 
