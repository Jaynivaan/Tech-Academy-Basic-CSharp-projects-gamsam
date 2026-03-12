# Tech-Academy-Basic-CSharp-projects-gamsam
Projects and assignments for  c# and .NET Framework Part1( Tech Academy).

This repository contains my course projects  and assignments for C# and .NET Framework(Part-1).
Each folder represents a practice project or assignment from the module.

programs included

#################

#1 
SampleApplication.cs
____________________

A simple C# console program compiled using the C# compiler.
This program demonstrates basic program structure and console output.

learning concepts:

-   using System; 
-   static void Main(){}
-   Console.WriteLine("");

#2
AcmeWelcome.cs
______________

A Console application that simulates a welcome screen for the fictional ACME Accounting System.
The Program displays formatted text in the console.

learning concepts:

-   escape character syntax application using backslash"\"

#3
DailyReport.cs
_______________

A console application that collects a students daily study report.
The Program asks the user several questions and stores the answers using the appropriate C# data types.

learning concepts: 
*   Console input and output
*   Using console.ReadLine() for input oppurtunity.
*   Data Types(string, int and boolean)
*   Casting concept as the RealLine() can only pull string data type .. 
*   crafting structured  program

#4
ConsoleMathApp.cs
_________________

A console application that performs several mathematical operations based on user input..
The program ask the user to enter number and ther performs different calculations such as multiplication, addition, division, comparison and modulus.

learning concepts:
*   casting
*   Arithmatic Operations
*   defining data types

#5
AnonymousIncomeComparison.cs
___________________________

A console app that compares the annual income of two people.
The program ask for the hourly rate and hours worked per week for 2 individuals. It calculates their annual salaries and  determines whether Person1 earns more than Person2.

learning concepts:
*   Arithmatic operations
*   Comparison operations
*   Boolean applications
*   casting instances.

#6
BooleanLogic.cs
________________

A Console application that determines whether an applicant qualifies for car insurance utilizing the wisdom capabilities of Boolean Logic.

learning concepts:
*   Boolean datatype (bool)
*   Logical AND (&&) operators
*   Logical || operator(or)
*   Logical ^ operator(XOR)
*   Comparison Operators(>, <=)

#7
PackageExpress.cs
_________________

A console application that calculates a shipping quote based on the package weight and dimensions.

learning concepts:
*   conditional statement if(){}else{};
*   Nested conditions
*   Ternary Operators(?:)
*   Arthmatic operations
*   User input with Console.ReadLine("");
*   Type conversion with  Convert.ToDecimal().

#8
ConsoleAppAssignment.cs
_______________________

A console application that showcased loops and switch cases.

learning concepts:
*   Boolean comparisons
*   while loops
*   do-while loops
*   switch statements
*   user input using Console.Readline();
*   break;

#9
StringOperations.cs
___________________
A console application that utilizes various string methods .. this app is an assignment from module    12.

learning concepts:
*   String Concatenation
*   Stirng methods(ToUpper)
*   StringBuilder class
*   Namespaces(system.Text)



####################################################################################################################
c# part 2 course 
the files inside the directory C#PART 2
#############################################

#10
ConsoleAppArrayAssignment

a consonle app crafted  to learn about the application of array and list on c# .. 

learning concept: 
*   array
*   list

#11
ConsoleApp6partassignment.cs
________________________________

a console app crafted to complete 6 part assignment 

+++part1: 
    1.one dimentional string array.
    2.ask user to enter text.
    3.A loop that iteerates through each string in the array and adds the users textinput to the end  of each string. This step will not outputanything but will update each array item by appendeing the userinput text. 
    4. then second loop that prints each string one at a time.
    5. save and compile..

+++Part2:
    1.add and infinite loop 
    2.fix the infininte loop
    3. add comments to reveal how infinite loop was fixed.
    
+++Part3: 
    1.A loop where teh comparison operator used to determine whether to continue iteration is a "<" operator.
    2. save and run 
    3. Add another loop  where the comparison that is used is "<="Operator.
    4 save and run 

+++Part4: 
    1. a list of strings where each item inthe  list is unique.
    2. ask the user to input text to search for the list.
    3. a loop that iterates through the list  and then displays the index of the list item  that contains matching text on the screen.
    4. add code to check if the user put in text that isn't on the list and , if they did, tell the user their input  is not on the list.
    5. add code  that stops the loop from executing once a match has been found.
    6. save and run.

+++Part5:
    1. a list of strings with atleast two identical strings in the list. Ask the user to select to search for in the list.
    2. create a loop that iterates through the list and then display the indices of list that contain matching text on the screen. Ensure to remove any breaking statements that may prevent your code from returning multiple  matches.
    3. add code to the loop to check if the user put in text that  isn't on the list and if they they did tell the user their input is not on the list.
    (no need to provide any additional chances for the user to enter text)
    4. save and exit

+++Part6: 
    1. create a list of string with atleast two identical strings
    2.create a for each loop that evaluates each item in the list, and displays a message showing the stringa nd whether or not it has  already appeared in the list.
    3. save and execute the code make sure if it is displaying result as unique or duplicate tag with each string on list.



#12
ConsoleAppstrings&integersAssignment.cs
_______________________________________

a console app crafted for the assignment in module 3.
requirements : 
1.a  create a list of integers.
1.b Ask the user for a number to divide each number in the list by. 
1.c Write a loop that takes each integer in the list and divides it with the given number and displays hte result onthe screen.

2.a run code
2.b enter non zero as the nunbr from user and note any error that get displayed.

3.a run code
3.b enter zero as entry and note the error if any displayed.

4.a run code once again 
4.b enter a string as entry note the error if you receive any.

5.a now put the loop in try catch block
5.b below and outside the trycatch block make the programme print a message" to display to let you know the program has emerged form the try catch block. 
5.c in the catch block display the errror message to the screeen
5.d try various combi nations of user input. (validnumbers, zero and string)
5.e ensure appropriate error message is displayed in message. and code after the try catch block is executed..

#13
CallingMethodsAssignment(directory)
________________________
this directory consist of two files Mathmethods.cs and Program.cs 
this assignment part of module 4 for c# part2 course fullfulls the following requirements;

1.a  create a class
1.b  In that class create three methods.
1.c  Each method s will take one integer parameter in  and return an integer.
1.d The methods should do some math operations on the  received parameter.
1.e Put the class in a separate .cs file in the application.

2.a In the Main() program  ask the user what number they want to do the math operations on 
2.b Call each method in turn passing the user input to the method and  display the returned integer to the screen.

3.comment the code generously.
