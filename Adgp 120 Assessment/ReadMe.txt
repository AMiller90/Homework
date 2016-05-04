Grid generated during program execution will look like this:
W - Wall
S - Start Node
G - Goal Node
0 - 120 Index of node
_________________________________________________________
| 0W | 1W | 2W | 3W | 4W | 5W | 6W | 7W | 8W | 9W | 10W |
| 11W| 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 | 21W |
| 22W| 23 | 24W| 25 | 26 | 27 | 28 | 29 | 30 | 31 | 32W |
| 33W| 34 | 35W| 36W| 37 | 38 | 39 | 40 | 41 | 42 | 43W |
| 44W| 45 | 46W| 47 | 48W| 49 | 50 | 51 | 52 | 53 | 54W |
| 55W| 56 | 57W| 58 | 59 | 60W| 61 | 62 | 63 | 64 | 65W |
| 66W| 67 | 68W| 69 | 70 | 71 | 72W| 73 | 74 | 75 | 76W |
| 77W| 78 | 79W| 80 | 81 | 82 | 83 | 84W| 85 | 86 | 87W |
| 88W| 89 | 90W| 91W| 92W| 93W| 94W| 95W| 96W| 97 | 98W |
| 99W| 100| 101| 102| 103| 104| 105| 106| 107| 108| 109W|
|110W|111W|112W|113W|114W|115W|116W|117W|118W|119W| 120W|

The program will run the algorithm then the path from the start node to the goal node will be displayed in the console window.
Starting with the goal node first back tracking through the parent nodes in the list all the way to the start node.


Test Case 1:		Test Case 2:	
Start Node: 12		Start Node: 20
Goal Node: 108		Goal Node: 100

Expected Result:	Expected Result:
108 - Goal			100 - Goal
97			101
73			102
61			103
49			104
37			105
25			106
13			107
12 - Start  		97
			86
Actual Result:		75
108 - Goal		64
97			53
85			42
73			31
61			20 - Start
49			
37			Actual Result:
25			100 - Goal
13			101	
12 - Start		103
			104
			105
			106
			107
			97
			86
			75
			64
			53
			42
			31
			20 - Start
