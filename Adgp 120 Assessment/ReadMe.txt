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


Test Case 1:		Test Case 2:		Test Case 3:		Test Case 4:		Test Case 5:		Test Case 6:
Start Node: 12		Start Node: 20		Start Node: 45		Start Node: 56		Start Node: 0		Start Node: 0
Goal Node: 108		Goal Node: 100		Goal Node: 83		Goal Node: 64		Goal Node: 97		Goal Node: 120
	
Expected Result:	Expected Result:	Expected Result:	Expected Result:	Expected Result:	Expected Result:
108 - Goal	        100 - Goal		83 - Goal		64 - Goal		97 - Goal		Path Not Available
97			101			73			52			85
73			102			61			40			73			Actual Result:
61			103			49			28			61			Path Not Available
49			104			37			16			49			
37			105			25			15			37
25			106			13			14			25			Test Case 7:
13			107			23			13			13			Start Node: 12
12 - Start  		97			34			23			12			Goal Node: 110
			86			45 - Start		34			0 - Start 
Actual Result:		75						45						Expected Result:
108 - Goal		64						56 - Start 					Path Not Available
97			53												
85			42												Actual Result:
73			31												Path Not Available
61			20 - Start
49			
37			Actual Result:		Actual Result:		Actual Result:		Actual Result:		Test Case 8:
25			100 - Goal		83 - Goal		64 - Goal		97 - Goal		Start Node: -1
13			101			73			52			85			Goal Node: 120
12 - Start		103			61			40			73			
			104			49			28			61			Expected Result:
			105			37			16			49			Start Node:Number Does Not Exist
			106			25			15			37
			107			13			14			25			Actual Result:
			97			23			13			13			Start Node:Number Does Not Exist
			86			34			23			12	
			75			45 - Start		34			0 - Start
			64						45						Test Case 9:
			53						56 - Start					Start Node: 120
			42												Goal Node: 130
			31
			20 - Start											Expected Result:
															Goal Node:Number Does Not Exist

															Actual Result:
															Goal Node:Number Does Not Exist