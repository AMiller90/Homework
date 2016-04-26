#Imports proper libraries - sys allows system to be used, math allows sqrt function and random allows
#random number generator
import sys, pygame, math, random
#From the Node File import everything
from Node import *
#From the AStar File import everything
from AStar import *

def setHScores(grid, i, goal):
    #Divide position by 25 to get the 0 - 9
    Sx = grid[i].xPos / 25
    Sy = grid[i].yPos / 25
    
    Gx = goal.xPos / 25
    Gy = goal.yPos / 25
    
    num1 = Gx - Sx
    num2 = Gy - Sy

    grid[i].setH((num1 + num2) * 10)
    #print grid[i].getH()
 
#Sets up Grid
def init_grid(width, height, walls):
 
  #searchSpace able to search and determine movement
    searchSpace = [] 
  
  
#Loop through the width of grid
    for x in range(width):
    #Create a variable to help space out the x nodes
        a = x * 25
        #Loop through the height of grid
        for y in range(height):
            #Create a variable to help space out the y nodes
            b = y * 25
            #If the coordinates are found in the walls list
            if(a,b) in walls:
                #Set the color to blue
                color = (0,0,255)
                #Cannot be traversed
                traversable = False
                #Add to searchSpace
                searchSpace.append(Node(b,a, traversable, color))
                #If coordinates are not founs in the walls list
            else:
                #It is traversable
                traversable = True
                #Set the color to white
                color = (255,255,255)
                #Add to searchSpace
                searchSpace.append(Node(b,a,traversable, color))
    
    index = 0
    
    for n in searchSpace:
        
        setHScores(searchSpace, index, searchSpace[99])

        n.setI(index)
        index += 1
  
  #Return the grid
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

    #Set Walls
    #
    walls = ((25,25),(50,50), (75,75), (100,100), (125, 125), (150,150), (175,175))

    #Store returned list in searchSpace
    searchSpace = init_grid(10, 10, walls)

    #variable to control game loop
    bIsDone = True

    #Create instance of AStar
    a = Astar(0, searchSpace, 99) 
 
#Game Loop
    while(bIsDone):

        clock.tick(10)

        for event in pygame.event.get(): 
            if event.type == pygame.QUIT: bIsDone = False
        
                      
        #Loop through searchSpace
        for i in searchSpace:
        #Draw the nodes to screen
            i.draw(screen) 

        bIsDone = a.Run(screen)

        #Displays the changes to the screen
        pygame.display.update()
        #Quit Game
        pygame.quit 


main()