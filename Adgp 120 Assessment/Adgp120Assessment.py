#From the Node File import everything
from Node import *
#From the Astar File import everything
from Astar import *

#Function to create a grid
def initGrid(walls, r, c):
    #SearchSpace
    searchSpace = []
    
    #Set the id
    id = 0
    #Number of rows in grid
    rows = r
    #Number of columns in grid
    cols = c
    
    #Loop through the columns
    for x in range(cols):
        #Loop through the rows
        for y in range(rows):
            #Create the node with x, y, and id 
            n = Node(x,y,id)
            
            #Create a Left wall for each x value that equals 0
            LWall = True if x % cols == 0 else False
            #Create a Right wall for each x value that equals cols - 1
            RWall = True if x % cols == cols - 1 else False
            #Create a Top wall for each y value that equals 0
            TWall = True if y % rows == 0 else False
            #Create a Bottom wall for each y value that equals rows - 1
            BWall = True if y % rows == rows - 1 else False
            
            #If any of these walls are true
            if(LWall or RWall or TWall or BWall):
               #Set the node to False
               n.walk(False)
            
            #If the coordinates exist in the list called walls
            if(x,y) in walls:
                #Set the node to False
                n.walk(False)
                #Append to searchSpace
                searchSpace.append(n)
            #If the corrdinates do not exist then
            else:
                #Append to searchSpace
                searchSpace.append(n)
                
            #Increment id
            id += 1
    #Return the searchSpace
    return searchSpace
              
#Function that sets up and runs the game
def main(): 

 #Walls that will not be traversable
 walls = ((2,2),(3,2),(4,2),(5,2),(6,2),(7,2),(8,2),(8,3),(8,4),(8,5),(8,6),(8,7),(3,3), (4,4), (5, 5), (6,6), (7,7),(8,8))
 #Number of rows
 rows = 11
 #Number of Columns
 columns = 11
 #Set grid variable to returned list
 grid = initGrid(walls,11,11)
 
 #Loop Control
 Begin = True
 
 #While True
 while(Begin):
  
  #Print the number options for user to choose from
  print("Node Index: 0 - 120")
  #Print to the user how to quit the application
  print("\nEnter 123 to Quit")
  #Get the start node number and store into start
  start = input("Enter A Start Node: ")
  #Check if user wants to quit
  if(start == 123):
    break
    
  #Get the goal node number and store into goal
  goal = input("Enter A Goal Node: ")
  #Check if user wants to quit
  if(goal == 123):
    break
  
  #Error checking - make sure user doesnt put in values less than 0 or greater than 120
  if(start >= 0 and start <= 120):
    if(goal >= 0 and goal <=120):
        #Create instance of Astar Object
        a = Astar(grid, grid[start], grid[goal], rows, columns)
        #Run algorithm and return the Path if available
        path = a.Run()
        
        #If path has values
        if(path):
            #Print to the screen letting the user know this will be the path returned
            print("\nThe Returned Path From The Goal Node To Start Node:")
            #Print the Goal Node ID
            print grid[goal].getID(),
            #Loop through them
            for n in path:
                #Print the Id for each node to show the algorithm works
                #The -> helps show the flow 
                print "-> " + str(n.getID()),
        #Print newline to help format 
            print("\n")
        #Else a path could not be found
        else:
            print("\nPath Not Available\n")

    #If user puts in the wrong number for a goal node
    else:
        print("\nGoal Node:Number Does Not Exist\n")
  #If user puts in the wrong number for a start node
  else:
    print("\nStart Node:Number Does Not Exist\n")
  
 

#Call main function
main()
