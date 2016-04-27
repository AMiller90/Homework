#Imports proper libraries - sys allows system to be used, math allows sqrt function and random allows
#random number generator
import sys, pygame, math, random
#From the Node File import everything
from Node import *
from Astar import *

def initGrid(walls, r, c):
    #SearchSpace
    searchSpace = []
 
    id = 0
    rows = r
    cols = c
    
    for x in range(cols):
        for y in range(rows):
            
            n = Node(x,y,id)
             
            LWall = True if x % cols == 0 else False
            RWall = True if x % cols == cols - 1 else False
            TWall = True if y % rows == 0 else False
            BWall = True if y % rows == rows - 1 else False
              
            if(LWall or RWall or TWall or BWall):
               n.walk(False)
            

            if(y,x) in walls:
                n.walk(False)
                searchSpace.append(n)
            else:
                searchSpace.append(n)
                

            id += 1
            
    return searchSpace
              
#Function that sets up and runs the game
def main(): 

 #Inits all pygame modules 
 pygame.init()

 clock = pygame.time.Clock()
 
 #Set title of screen
 pygame.display.set_caption("Adgp 120 Assessment")
    
 #Set the dimensions of the game window
 size = width, height = 640, 360

 #Set the Size Of The Game Window
 screen = pygame.display.set_mode(size)
 
 #Loop control
 bIsDone = True

 walls = ((2,2),(3,2),(4,2),(5,2),(6,2),(7,2),(8,2),(8,3),(8,4),(8,5),(8,6),(8,7),(3,3), (4,4), (5, 5), (6,6), (7,7))
 rows = 11
 columns = 11
 grid = initGrid(walls,11,11)
 
 a = Astar(grid, grid[12], grid[108], rows, columns)
 
#Game Loop
 while(bIsDone):

        clock.tick(10)
    
        for event in pygame.event.get():
            if event.type == pygame.QUIT: bIsDone = False
                  
 
        for n in grid:
            n.draw(screen)
    

  
        #bIsDone = a.Run()
  
        #Displays the changes to the screen
        pygame.display.update()
        #Quit Game
        pygame.quit 
  
main()
