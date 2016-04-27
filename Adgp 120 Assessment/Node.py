import pygame

class Node(object):
    #Initialize a node
    def __init__(self, x, y, id):
        self.adjacents = []
        self.color = (255,255,255)
        self.parent = None
        self.traversable = True
        self.width = 20
        self.height = 20
        self.xPos = (5 + self.width) * x
        self.yPos = (5 + self.height) * y
        self.id = id
        self.index = (x,y)
        self.F = 0
        self.G = 0
        self.H = 0
    
    #Draw nodes to screen
    def draw(self, screen):
     if self.xPos == 25 and self.yPos == 25:
        #Set the color to green representing starting node
        startingNodeColor = (0,255,0)
        pygame.draw.rect(screen, startingNodeColor,(self.xPos, self.yPos, self.width, self.height))
     elif self.xPos == 225 and self.yPos == 225:
        #Set the color to green representing starting node
        goalNodeColor = (255,0,0)
        pygame.draw.rect(screen, goalNodeColor,(self.xPos, self.yPos, self.width, self.height))
     else:
        color = (255,255,255) if (self.traversable) else (0,0,255)
        pygame.draw.rect(screen, color,(self.xPos, self.yPos, self.width, self.height))

    def passable(self):
        return self.traversable
        
    #Set the traversable variable
    def walk(self, traverse):
        self.traversable = traverse
    
    def getID(self):
        return self.id
        
    #Get the value of F
    def getF(self):
        return self.F 
    
    def getG(self):
        return self.G
        
    def getH(self):
        return self.H
        
    def setF(self, value):
        self.F = value
        
    def setG(self, value):
        self.G = value
        self.F = self.G + self.H
        
    def setH(self, value):
        self.H = value
        self.F = self.G + self.H

    def setColor(self, value):
        self.color = value