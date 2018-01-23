C# Basics

A basic review of C#. 
See code in program.cs

## OVERVIEW & CONCEPTS

- Build a simple console application
- Write/reading to/from the console
- Variables, conditionals, loops, and exceptions

## NOTES
### Program Structure
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

##### Writing to the Console and Receiving Input

- Writing to the console:

```C#
    System.Console.Write("How many minutes did you exercise?  ");
```

- Compiling:  mono is a popular compiler for C#
- To comple run: ```mcs Program.cs```
- To run the program: ```mono Program.exe```









------------------------------------------------------------------------------
## REVIEW




## REFERENCES
- [TreeHouse: C# Basics](https://teamtreehouse.com/library/c-basics)
- [C# Keywords](https://msdn.microsoft.com/en-us/library/x53a06bb.aspx)
- [Four Ps to Problem Solving](https://medium.com/@MatHelme/the-four-ps-of-problem-solving-6e15a39a0712)


