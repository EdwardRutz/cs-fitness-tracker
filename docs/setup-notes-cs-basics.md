C# Basics

A basic review of C#. 
See code in program.cs

## OVERVIEW & CONCEPTS

- Build a simple console application
- Write/reading to/from the console
- Variables, conditionals, loops, and exceptions

## NOTES
### C# Program Structure
- A computer program is a collection of files, classes and methods.
- All code is contained in a class which organizes the code.
- C# code files have the .cs extension
- C# ends a code statment with a semicolon ";"
- Each class is contained in its own file.
- Classes can contain many methods, small chunks of code that do one thing. Similiar to a function.
- Methods have four parts: name, body, parameters, return type 
- Parameters are the information a method needs to run
- Methods can call other methods which runs them and then gives them the results.
- Return type is the type of information a method will return
- The Main method is the first method to run and determines the order other methods are run
- A program must contain a method named "Main" with a capital "M". Classes start with a capital letter
- The .Net library contains classes and methods to use.
- Variable Names are typically written in CamelCase

### Prepare & Plan

#### The Four Ps

1. Prepare - understand and diagnose the problem to solve
- Plan the steps by breaking large problems into smaller problems and then again into even smaller problems that are more manageable
2. Plan - Organize the steps to the solutions.
3. Perform - execut, put the plan into action.
4. Perfect - Confirm and reviw, did the plan solve the problem? Repeat the four P's again to make improvements.
- Read More about the [Four Ps to Problem Solving](https://medium.com/@MatHelme/the-four-ps-of-problem-solving-6e15a39a0712)

- Simple planning can be done using comments in the code:

```
class Program
{
    static void Main()
    {
        // Prompt the user for minutes exercised
        // Add minutes exercised to total
        // Display total minutes exercised to the screen
        // repeat until the user quits
    }

}
```

### Console I/O

#### Writing To the Console

```C#
    System.Console.Write("How many minutes did you exercise?  ");
```

- Compiling:  mono is a popular compiler for C#
- To comple run: ```mcs Program.cs```
- To run the program: ```mono Program.exe```

#### Reading From the Console

- The .NET framework provides the this method as well
- When called, this method records user input until the return key is pressed
- The return key marks the end of a line.
- The "System.Console.ReadLine()" method doesn't take any parameters and it returns what the user types back to the program. It returns a string.

```cs
    System.Console.ReadLine();
```
##### Variables
- Variable names can't have spaces and are typically written in CamelCase
- Next, declare a variable then assign a value to it. 
- Variable declaration...declare a variable by giving it a name and type
- Variable assignment, give the variable a value
- Initializing the variable is assigning a name to the variable at the same time it is declared
- String Literal is a string that litterally contains the text value given, eg ```string entry = "25"```

### Perform
Execute the plan and code.

### Perfect
Improve app through refactoring, input validations, etc..

------------------------------------------------------------------------------
## REVIEW




## REFERENCES
- [TreeHouse: C# Basics](https://teamtreehouse.com/library/c-basics)
- [C# Keywords](https://msdn.microsoft.com/en-us/library/x53a06bb.aspx)
- [Four Ps to Problem Solving](https://medium.com/@MatHelme/the-four-ps-of-problem-solving-6e15a39a0712)


