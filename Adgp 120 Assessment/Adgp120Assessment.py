#Imports pygame so it can be referenced
import pygame
#From the Node File import everything
from Node import *
#From the Astar File import everything
from Astar import *

#Function to create a grid
def initGrid(walls, r, c):
    #SearchSpace
    searchSpace = []
    
    #Set the id
    id = 0
    #Number of rows in grid
    rows = r
    #Number of columns in grid
    cols = c
    
    #Loop through the columns
    for x in range(cols):
        #Loop through the rows
        for y in range(rows):
            #Create the node with y, x, and id 
            n = Node(y,x,id)
            
            #Create a Left wall for each x value that equals 0
            LWall = True if x % cols == 0 else False
            #Create a Right wall for each x value that equals cols - 1
            RWall = True if x % cols == cols - 1 else False
            #Create a Top wall for each y value that equals 0
            TWall = True if y % rows == 0 else False
            #Create a Bottom wall for each y value that equals rows - 1
            BWall = True if y % rows == rows - 1 else False
            
            #If any of these walls are true
            if(LWall or RWall or TWall or BWall):
               #Set the node to False
               n.walk(False)
            
            #If the coordinates exist in the list called walls
            if(y,x) in walls:
                #Set the node to False
                n.walk(False)
                #Append to searchSpace
                searchSpace.append(n)
            #If the corrdinates do not exist then
            else:
                #Append to searchSpace
                searchSpace.append(n)
                
            #Increment id
            id += 1
    #Return the searchSpace
    return searchSpace
              
#Function that sets up and runs the game
def main(): 

 #Inits all pygame modules 
 pygame.init()

 #Create a clock variable
 clock = pygame.time.Clock()
 
 #Loop control
 bIsDone = True

 #Walls that will not be traversable
 walls = ((2,2),(2,3),(2,4),(2,5),(2,6),(2,7),(2,8),(3,8),(4,8),(5,8),(6,8),(7,8 ),(3,3), (4,4), (5, 5), (6,6), (7,7),(8,8))
 #Number of rows
 rows = 11
 #Number of Columns
 columns = 11
 #Set grid variable to returned list
 grid = initGrid(walls,11,11)
 
 #Create instance of Astar Object
 a = Astar(grid, grid[12], grid[108], rows, columns)
 
 
 
 while(bIsDone):
 
 
  #Loop through the grid
    for n in grid:
     #Draw the nodes to the screen
        n.draw(screen)
     
    
    
    bIsDone = a.Run()
    
    #Displays the changes to the screen
    pygame.display.update()
    #Quit Game
    pygame.quit 
     

#Call main function
main()
