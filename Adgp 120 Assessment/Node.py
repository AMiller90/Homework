import pygame

class Node:
    #Initialize a node
    def __init__(self, x, y):
        self.color = (255,255,255)
        self.parent = None
        self.traversable = True
        self.width = 20
        self.height = 20
        self.xPos = x
        self.yPos = y
        self.F = None
        self.G = None
        self.H = None
        self.row = x / 25
        self.col = y / 25
    
    #Draw nodes to screen
    def draw(self, screen):
     if self.xPos == 0 and self.yPos == 0:
        #Set the color to green representing starting node
        startingNodeColor = (0,255,0)
        pygame.draw.rect(screen, startingNodeColor,(self.xPos, self.yPos, self.width, self.height))
     else:
        color = (255,255,255) if (self.traversable) else (0,0,255)
        pygame.draw.rect(screen, color,(self.xPos, self.yPos, self.width, self.height))

    #Set the traversable variable
    def walk(self, traverse):
        self.traversable = traverse
    
    #Get the value of F
    def getF(self):
     self.F = self.H + self.G
     return self.F 
     
    #Set the value of G
    def setG(self, g):
      self.G = g
      
    #Set the value of H
    def setH(self, h):
      self.H = h