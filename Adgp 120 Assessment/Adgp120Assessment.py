#Imports proper libraries - sys allows system to be used, math allows sqrt function and random allows
#random number generator
import sys, pygame, math, random
#From the Node File import everything
from Node import *

#Function that sets up and runs the game
def main(): 

 #Inits all pygame modules 
 pygame.init()

 #Set title of screen
 pygame.display.set_caption("Adgp 120 Assessment")
    
 #Set the dimensions of the game window
 size = width, height = 640, 360

 #Set the Size Of The Game Window
 screen = pygame.display.set_mode(size)

 #Size of grid
 Grid = 100

 #y coordinate of rectangle
 y = 0

 #searchSpace able to search and determine movement
 searchSpace = [] 

 #Loop control
 bIsDone = True

#Draw a rect (x,y,width height)
 for i in range(Grid):

    #Generate a random number
    index = random.randrange(0, Grid)
    #Get the square root of the Grid
    root = math.sqrt(Grid)
    #Store the result of the i % root in a new variable
    z = i % root
    #Set x to the z value * 25
    x = z * 25 
    
    #Create Nodes
    n = Node(x,y)

    #Determine whether the node is traversable or not
    #If the index number is less than or equal to 1 and a half the size of the grid then true else false
    unpassable = True if (index <= Grid / 1.5) else False
    
    #Set whether the node is traversable or not
    n.walk(unpassable)
    
    #Append Nodes to searchSpace
    searchSpace.append(n)
    
    #if z is equal to the root number minus 1
    if z == root - 1:
    #y is set to current y plus 25
     y += 25
    

#Game Loop
 while(bIsDone):

  for event in pygame.event.get():
   if event.type == pygame.QUIT:
    bIsDone = False
                  
  #Loop through searchSpace
  for i in searchSpace:
  #Draw the nodes to screen
   i.draw(screen) 
  
   
  #Displays the changes to the screen
  pygame.display.update()
  #Quit Game
  pygame.quit 
 
main()
