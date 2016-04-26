import Node
from Node import *
count = 0
grid = []
rows = 5
cols = 5
for i in range(rows):
    for j in range(cols):
        n = Node(i,j,False, (255,255,255), count)
        count = count + 1
        grid.append(n)
def setAdjacents(n):
    left = n.I - rows
    right = n.I + rows
    top = n.I - 1
    bot = n.I + 1
    tl = left -1
    bl = left + 1
    tr = right -1
    br = right + 1
    n.adjacents = [grid[left], grid[right], grid[top], grid[bot], grid[tl], grid[bl],grid[tr], grid[br]]
    

