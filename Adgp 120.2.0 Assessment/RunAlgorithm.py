#Imports proper libraries - sys allows system to be used, math allows sqrt function and random allows
#random number generator
import sys, pygame, math, random
#From the Node File import everything
from Node import *
#From the AStar File import everything
from AStar import *

def setHScores(grid):
#row 1
 grid[0].setH(180)
 grid[1].setH(170)
 grid[2].setH(160)
 grid[3].setH(150)
 grid[4].setH(140)
 grid[5].setH(130)
 grid[6].setH(120)
 grid[7].setH(110)
 grid[8].setH(100)
 grid[9].setH(90)
 
 #row 2
 grid[10].setH(170)
 grid[11].setH(160)
 grid[12].setH(150)
 grid[13].setH(140)
 grid[14].setH(130)
 grid[15].setH(120)
 grid[16].setH(110)
 grid[17].setH(100)
 grid[18].setH(90)
 grid[19].setH(80)
 
 #row 3
 grid[20].setH(160)
 grid[21].setH(150)
 grid[22].setH(140)
 grid[23].setH(130)
 grid[24].setH(120)
 grid[25].setH(110)
 grid[26].setH(100)
 grid[27].setH(90)
 grid[28].setH(80)
 grid[29].setH(70)
 
 #row 4
 grid[30].setH(150)
 grid[31].setH(140)
 grid[32].setH(130)
 grid[33].setH(120)
 grid[34].setH(110)
 grid[35].setH(100)
 grid[36].setH(90)
 grid[37].setH(80)
 grid[38].setH(70)
 grid[39].setH(60)
 
 #row 5
 grid[40].setH(140)
 grid[41].setH(130)
 grid[42].setH(120)
 grid[43].setH(110)
 grid[44].setH(100)
 grid[45].setH(90)
 grid[46].setH(80)
 grid[47].setH(70)
 grid[48].setH(60)
 grid[49].setH(50)
 
 #row 6
 grid[50].setH(130)
 grid[51].setH(120)
 grid[52].setH(110)
 grid[53].setH(100)
 grid[54].setH(90)
 grid[55].setH(80)
 grid[56].setH(70)
 grid[57].setH(60)
 grid[58].setH(50)
 grid[59].setH(40)
 
 #row 7
 grid[60].setH(120)
 grid[61].setH(110)
 grid[62].setH(100)
 grid[63].setH(90)
 grid[64].setH(80)
 grid[65].setH(70)
 grid[66].setH(60)
 grid[67].setH(50)
 grid[68].setH(40)
 grid[69].setH(30)
 
 #row 8
 grid[70].setH(110)
 grid[71].setH(100)
 grid[72].setH(90)
 grid[73].setH(80)
 grid[74].setH(70)
 grid[75].setH(60)
 grid[76].setH(50)
 grid[77].setH(40)
 grid[78].setH(30)
 grid[79].setH(20)
 
 #row 9
 grid[80].setH(100)
 grid[81].setH(90)
 grid[82].setH(80)
 grid[83].setH(70)
 grid[84].setH(60)
 grid[85].setH(50)
 grid[86].setH(40)
 grid[87].setH(30)
 grid[88].setH(20)
 grid[89].setH(10)
 
 #row 10
 grid[90].setH(90)
 grid[91].setH(80)
 grid[92].setH(70)
 grid[93].setH(60)
 grid[94].setH(50)
 grid[95].setH(40)
 grid[96].setH(30)
 grid[97].setH(20)
 grid[98].setH(10)
 grid[99].setH(0)
 
#Sets up Grid
def init_grid(width, height, walls):
 
  #searchSpace able to search and determine movement
  searchSpace = [] 
  
  index = 0 - 1
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
  
  for n in searchSpace:
    index += 1
    n.setI(index)
    
  setHScores(searchSpace)
  
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
   if event.type == pygame.QUIT:
    bIsDone = False
                  
  #Loop through searchSpace
  for i in searchSpace:
  #Draw the nodes to screen
   i.draw(screen) 
  
  a.Run(screen)

  #Displays the changes to the screen
  pygame.display.update()
  #Quit Game
  pygame.quit 
 
main()