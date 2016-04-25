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
       
       currX = self.searchSpace[index].xPos
       currY = self.searchSpace[index].yPos
       right = self.searchSpace[index].xPos + 25
       left = self.searchSpace[index].xPos - 25
       top = self.searchSpace[index].yPos - 25
       bot = self.searchSpace[index].yPos + 25
       
       topright = None
       topleft = None
       botleft = None
       botright = None
       
       for n in self.searchSpace:
          if n.xPos == right and n.yPos == currY:
            right = n           
          if n.xPos == left and n.yPos == currY:
           left = n
          if n.yPos == top and n.xPos == currX:
           top = n
          if n.yPos == bot and n.xPos == currX:
           bot = n
          if n.xPos == right and n.yPos == top:
           topright = n
          if n.xPos == right and n.yPos == bot:
           botright = n
          if n.yPos == top and n.xPos == left:
           topleft = n
          if n.yPos == bot and n.xPos == left:
           botleft = n
       
       self.searchSpace[index].setColor((255,255,255))
       #At the end of the checking then we are done with the current node
	   #Remove it from open list
       self.open.remove(self.searchSpace[index])
	   #Add it to the closed list
       self.closed.append(self.searchSpace[index])
       
       
       #If next node is traversable and next node is not in the open list and not in the closed list and Does exist
       #if(right.traversable == True and right not in self.open and right not in self.closed and not right == None and not index % 10 == 9):
		#Set the G Score 
        #right.setG(10)
		#Add to open list because it is traversable
        #self.open.append(right)
        #Set adjacent nodes parent to the current node comparing
        #right.parent = self.searchSpace[index]
        #print self.searchSpace[index + 1].yPos, ",", self.searchSpace[index + 1].xPos , " Right"
        
        
       #If next node is traversable and next node is not in the open list and not in the closed list and Does exist
       if(self.searchSpace[index + 1].traversable == True and self.searchSpace[index + 1] not in self.open and self.searchSpace[index + 1] not in self.closed and not self.searchSpace[index + 1] == None and not index % 10 == 9):
		#Set the G Score 
        self.searchSpace[index + 1].setG(10)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index + 1])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index + 1].parent = self.searchSpace[index]
        #print self.searchSpace[index + 1].yPos, ",", self.searchSpace[index + 1].xPos , " Right"
                
	   #If previous node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index - 1].traversable == True and self.searchSpace[index - 1] not in self.open and self.searchSpace[index - 1] not in self.closed and not self.searchSpace[index - 1] == None and not index % 10 == 0):
		#Set the G Score 
        self.searchSpace[index - 1].setG(10)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index - 1])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index - 1].parent = self.searchSpace[index]
        print self.searchSpace[index - 1].yPos, ",", self.searchSpace[index - 1].xPos, " Left"
        
	   #If node below current node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index + 10].traversable == True and self.searchSpace[index + 10] not in self.open and self.searchSpace[index + 10] not in self.closed and not self.searchSpace[index + 10] == None):        
		#Set the G Score 
        self.searchSpace[index + 10].setG(10)
        self.searchSpace[index + 10].setColor((255,0,0))
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index + 10])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index + 10].parent = self.searchSpace[index]
        print self.searchSpace[index + 10].yPos, ",", self.searchSpace[index + 10].xPos, " Top"
		
	   #If node above current node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index - 10].traversable == True and self.searchSpace[index - 10] not in self.open and self.searchSpace[index - 10] not in self.closed and not self.searchSpace[index - 10] == None):
		#Set the G Score 
        self.searchSpace[index - 10].setG(10)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index - 10])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index - 10].parent = self.searchSpace[index]
        print self.searchSpace[index - 10].yPos, ",", self.searchSpace[index - 10].xPos, " Bot"
		
	   #If node to the top right of current node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index - 9].traversable == True and self.searchSpace[index - 9] not in self.open and self.searchSpace[index - 9] not in self.closed and not self.searchSpace[index - 9] == None):
		#Set the G Score 
        self.searchSpace[index - 9].setG(14)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index - 9])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index - 9].parent = self.searchSpace[index]
        print self.searchSpace[index - 9].yPos, ",", self.searchSpace[index - 9].xPos
                
	   #If node to the top left of current node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index - 11].traversable == True and self.searchSpace[index - 11] not in self.open and self.searchSpace[index - 11] not in self.closed and not self.searchSpace[index - 11] == None):
		#Set the G Score 
        self.searchSpace[index - 11].setG(14)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index - 11])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index - 11].parent = self.searchSpace[index]
        print self.searchSpace[index - 11].yPos, ",", self.searchSpace[index - 11].xPos
		
	   #If node to the bottom right of current node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index + 11].traversable == True and self.searchSpace[index + 11] not in self.open and self.searchSpace[index + 11] not in self.closed and not self.searchSpace[index + 11] == None):
		#Set the G Score 
        self.searchSpace[index + 11].setG(14)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index + 11])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index + 11].parent = self.searchSpace[index]
        print self.searchSpace[index + 11].yPos, ",", self.searchSpace[index + 11].xPos
        
	   #If node to the bottom left of current node is traversable and next node is not in the open list and not in the closed list and Does exist
       elif(self.searchSpace[index + 9].traversable == True and self.searchSpace[index + 9] not in self.open and self.searchSpace[index + 9] not in self.closed and not self.searchSpace[index + 9] == None):
		#Set the G Score 
        self.searchSpace[index + 9].setG(14)
		#Add to open list because it is traversable
        self.open.append(self.searchSpace[index + 9])
        #Set adjacent nodes parent to the current node comparing
        self.searchSpace[index + 9].parent = self.searchSpace[index]
        print self.searchSpace[index + 9].yPos, ",", self.searchSpace[index + 9].xPos    
        
       '''
	   #If node is in the open list
       #elif(self.searchSpace[index + 1] in self.open):
         #If the next nodes G is greater than current nodes G 
        # if(self.searchSpace[index + 1].getG() < self.searchSpace[index].getG()):
         # self.searchSpace[index + 1].parent = self.searchSpace[index]
          
       #If node is in the open list
       #elif(self.searchSpace[index - 1] in self.open):
         #If the next nodes G is greater than current nodes G 
         #if(self.searchSpace[index - 1].getG() < self.searchSpace[index].getG()):
             #self.searchSpace[index - 1].parent = self.searchSpace[index]
          
       #If node is in the open list
       #elif(self.searchSpace[index + 10] in self.open):
         #If the next nodes G is greater than current nodes G 
         #if(self.searchSpace[index + 10].getG() < self.searchSpace[index].getG()):
          #self.searchSpace[index + 10].parent = self.searchSpace[index]
          
       #If node is in the open list
       #elif(self.searchSpace[index - 10] in self.open):
         #If the next nodes G is greater than current nodes G 
         #if(self.searchSpace[index - 10].getG() < self.searchSpace[index].getG()):
          #self.searchSpace[index - 10].parent = self.searchSpace[index]
          
       #If node is in the open list
       #elif(self.searchSpace[index - 9] in self.open):
         #If the next nodes G is greater than current nodes G 
         #if(self.searchSpace[index - 9].getG() < self.searchSpace[index].getG()):
          #self.searchSpace[index - 9].parent = self.searchSpace[index]
          
       #If node is in the open list
       #elif(self.searchSpace[index - 11] in self.open):
         #If the next nodes G is greater than current nodes G 
         #if(self.searchSpace[index - 11].getG() < self.searchSpace[index].getG()):
          #self.searchSpace[index - 11].parent = self.searchSpace[index]
          
       #If node is in the open list
       #elif(self.searchSpace[index + 11] in self.open):
         #If the next nodes G is greater than current nodes G 
         #if(self.searchSpace[index + 11].getG() < self.searchSpace[index].getG()):
          #self.searchSpace[index + 11].parent = self.searchSpace[index]
          
       #If node is in the open list
       #elif(self.searchSpace[index + 9] in self.open):
         #If the next nodes G is greater than current nodes G 
         #if(self.searchSpace[index + 9].getG() < self.searchSpace[index].getG()):
          #self.searchSpace[index + 9].parent = self.searchSpace[index]       
          
	   '''
    
  #Going to sorting the list by F value
   def Sort(self,artosort):
    return sorted(artosort, key=lambda Node: Node.F)

   #Get LowestF Node currently in the self.open list
   def getLowestF(self,openlist):
        #Create empty list
        lowflist = []
		#Set the empty list to the sorted list
        lowflist = self.Sort(openlist)

        #self.open.remove(lowflist[0])
        #self.closed.append(lowflist[0])
        
        lowflist[0].setColor((0,255,0))
		#Return the first node in the sorted list which will have the lowest F
        return lowflist[0].getI()
    
   #Run the Algorithm
   def Run(self, screen):
   
    if(self.index != self.goal):
    
        n = self.searchSpace[self.index]
        
        if n.parent:
        
         currentrect = pygame.Rect(n.xPos, n.yPos, n.width, n.height)
         parentrect = pygame.Rect(n.parent.xPos, n.parent.yPos, n.parent.width, n.parent.height)
         
         parentmid = (parentrect.centerx, parentrect.centery)
         selfmid = (currentrect.centerx, currentrect.centery)
         pygame.draw.aaline(screen, (0,255,0), selfmid, parentmid,False)

	    #Look at adjacent nodes
        self.getAdjacent(self.index)
		#The lowest f node was returned and is now current node
        self.index = self.getLowestF(self.open)
        
        
    else:
	#print("Goal Reached")
	return False
	
		
	 
		
	
