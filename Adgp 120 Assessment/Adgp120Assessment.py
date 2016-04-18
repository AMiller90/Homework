#Imports proper libraries
import sys, pygame, math
from Node import *
#Inits all pygame modules 
pygame.init()

#Rectangle color
white = (255,255,255)

#Set the dimensions of the game window
size = width, height = 640, 360

#Set the Size Of The Game Window
screen = pygame.display.set_mode(size)

#Size of grid
Grid = 16

#y coordinate of rectangle
y = 0

#Draw a rect (x,y,width height)
for i in range(Grid):

    root = math.sqrt(Grid)
    z = i % root
    x = z * 25 
	
    pygame.draw.rect(screen,white,(x,y,20,20))
	
    if z == root - 1:
     y += 25 
	 
    
	
     
 
	
   
#Displays the changes to the screen
pygame.display.update()

#Wait for input
input()

#Closes window
pygame.display.quit