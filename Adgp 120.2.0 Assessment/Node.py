import pygame

class Node:
    #Initialize a node
    def __init__(self, x, y, t, c):    
        self.adjacents = []    
        self.parent = None
        self.traversable = t
        self.width = 20
        self.height = 20
        self.xPos = x
        self.yPos = y
        self.color = c
        self.F = 0
        self.G = 0
        self.H = 0
        self.I = None
    

    #Draw nodes to screen
    def draw(self, screen):
     #if self.xPos == 0 and self.yPos == 0:
        #Set the color to green representing starting node
        #self.Color = (0,255,0)
        #pygame.draw.rect(screen, self.Color,(self.xPos, self.yPos, self.width, self.height))
        if self.xPos == 225 and self.yPos == 225: 
            self.color = (255,0,0)
            pygame.draw.rect(screen, self.color,(self.xPos, self.yPos, self.width, self.height))
        else:
            pygame.draw.rect(screen, self.color,(self.xPos, self.yPos, self.width, self.height))
      
    #Get the value of F
    def getF(self):
        self.F = self.H + self.G
        return self.F 

    #Set the value of G
    def setG(self, g):
        self.G = g

    #Get the value of G
    def getG(self):
        return self.G

    #Set the value of H
    def setH(self, h):
        self.H = h

    #Get the value of H
    def getH(self):
        return self.H

    #Set the the nodes index
    def setI(self, i):
        self.I = i

    #Set the nodes index
    def getI(self):
        return self.I

    #Set the node color allowing visualization of node moving from start to goal
    def setColor(self, c):
        self.color = c
     
