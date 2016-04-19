import pygame

class Node:
    def __init__(self, x, y):
        self.color = (255,255,255)
        self.traversable = True
        self.width = 20
        self.height = 20
        self.xPos = x
        self.yPos = y
        self.f = None
        self.g = None
        self.h = None
        
    def draw(self, screen):
     if self.xPos == 0 and self.yPos == 0:
        #Set the color to green representing starting node
        startingNodeColor = (0,255,0)
        pygame.draw.rect(screen, startingNodeColor,(self.xPos, self.yPos, self.width, self.height))
     else:
        color = (255,255,255) if (self.traversable) else (0,0,255)
        pygame.draw.rect(screen, color,(self.xPos, self.yPos, self.width, self.height))

    def walk(self, traverse):
        self.traversable = traverse