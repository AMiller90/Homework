import pygame
from Node import *

class Astar:
   #Initialize the Object
   def __init__(self):
   #Create a List
             self.open = []
             self.closed = []
             
   #Run the Algorithm
   def Run(self, sSpaceList):
   
       #Get the lenght of the list
       total = len(sSpaceList)
       
       #Add the first node to the list
       self.open.append(sSpaceList[0])

         
   #Compare the nodes in alist based off of F value
   def CompareF(self, Nodelist):
      
   
   
   #Going to sorting the list by F value
   def Sort(artosort):
    return sorted(artosort, key=lambda Node: Node.F)