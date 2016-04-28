#Import pygame so we can use it
import pygame

class Node():
    #Initialize a node
    def __init__(self, x, y, id):
        #List of adjacents to given node
        self.adjacents = []
        #Parent of node
        self.parent = None
        #Traversable value
        self.traversable = True
        #Width size of node
        self.width = 20
        #Height size of node
        self.height = 20
        #xPos of node
        self.xPos = (5 + self.width) * x
        #yPos of node
        self.yPos = (5 + self.height) * y
        #Id of the node
        self.id = id
        #F Score
        self.F = 0
        #G Score
        self.G = 0
        #H Score
        self.H = 0
    
    #Draw nodes to screen
    def draw(self, screen):
     #If this is the current position then its the start node
     if self.xPos == 25 and self.yPos == 25:
        #Set the color to green representing starting node
        startingNodeColor = (0,255,0)
        #Draw the node
        pygame.draw.rect(screen, startingNodeColor,(self.xPos, self.yPos, self.width, self.height))
     #If this is the current position then its the goal node
     elif self.xPos == 225 and self.yPos == 225:
        #Set the color to green representing starting node
        goalNodeColor = (255,0,0)
        #Draw the node
        pygame.draw.rect(screen, goalNodeColor,(self.xPos, self.yPos, self.width, self.height))
     #If any other position
     else:
        #If the node is traverable set it to white else set it to blue
        color = (255,255,255) if (self.traversable) else (0,0,255)
        #Draw the node
        pygame.draw.rect(screen, color,(self.xPos, self.yPos, self.width, self.height))
    
    #Can we walk through a node
    def passable(self):
        #Return self.traversable variable value
        return self.traversable
        
    #Set the traversable variable
    def walk(self, traverse):
        #Set whether node can be traversable or not
        self.traversable = traverse
    
    #Get the ID
    def getID(self):
        #Return the Id
        return self.id
        
    #Get the value of F
    def getF(self):
        #Return the F Value
        return self.F 
    
    #Get the G Value
    def getG(self):
        #Return the G value
        return self.G
        
    #Get the H Value
    def getH(self):
        #Return the H Value
        return self.H
    
    #Set the G Value
    def setG(self, value):
        #Set the G Value
        self.G = value
        #Set the F Score based on current H and G Values
        self.F = self.G + self.H
    
    #Set the H Value
    def setH(self, value):
        #Set the H Value
        self.H = value
        #Set the F value based on the G and H Value
        self.F = self.G + self.H

    #Set the Color of node
    def setColor(self, value):
        #Set color based on value
        self.color = value