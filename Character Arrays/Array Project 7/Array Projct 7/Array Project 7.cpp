#pragma once

#include<iostream>

int main() {

	//Problem 7

	a).The user is trying to create a character array called name with 4 elements and is wanting to set the value to "John".
		The Bug here is that the total elements should be 5 not 4. Reason is because it is a string literal and has a null terminator character. 4 doesnt count the null character. 5 does.
		I would correct it to look like so:

	char name[5] = "John";

	b).The User is trying to print out the char name[32] array.
		The bug is that nothing will print because the array wasnt intitialized to anything.
		I would correct it like so:
	
	char name[32] = "John"; std::cout << name;
      
	c).The user is trying to concatenate the surname to the name.
		The bug is that there would not be enough space in elements at the end of the name array to fit the concatenated value of surname,
		I would correct it like so:

	char name[15] = "Donald"; 
	char surname[7] = "Knuth"; 
    std::cout << strcat(name, surname);
	   
	 d).The User is trying to printout the length of the string stored in the variable errorMsg with an added ! character
		  The Bug is putting the strlen function into the error message element brackets and also not having enough elements.It should be 6 not 5.
	      This is How I Would Have Fixed it:

	 char errorMsg[6] = "Stop!";
	 std::cout << strlen("Stop!");

	system("PAUSE");
	return 0;
}