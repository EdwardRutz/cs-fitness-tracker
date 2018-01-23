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

- Two methods, Write and Read
- Write prints to the console
- Read gets text and passes it to the method

#### Writing To the Console

- System.Console.write displays text to the user
- It only takes a single paramenter

```C#
    System.Console.Write("How many minutes did you exercise?  ");
```
#### Compile with Mono

- Compiling:  mono is a popular compiler for C#
- To comple run: ```mcs Program.cs```
- To run the program: ```mono Program.exe```

#### Reading From the Console

- The .NET framework provides the this method as well
- When called, this method records user input until the return key is pressed
- The return key marks the end of a line.
- The "System.Console.ReadLine()" method doesn't take any parameters and it returns what the user types back to the program. It returns a string.
- Note the "L" is captialized in "ReadLine"...System.Console.ReadLine();

```cs
   string entry = System.Console.ReadLine();
```

##### Variables

- Variable names can't have spaces and are typically written in CamelCase
- Next, declare a variable then assign a value to it. 
- Variable declaration...declare a variable by giving it a name and type
- Variable assignment, give the variable a value
- Initializing the variable is assigning a name to the variable at the same time it is declared
- String Literal is a string that litterally contains the text value given, eg ```string entry = "25"```
- Don't forget to include semi-colons at the end of a statement

##### Namespace, Class, Method

- Namespaces, Classes and Methods organize code in C#
- Reading a Method call from right to left: Namespace.Class.Method
- The method name is "write"
- The class name is "Console"
- System is the namespace containing the class Console
- Classes are contained in namespaces
- Namespaces make it possible to have multiple classes with the same name because each class name remains in the namespace
- Like an address, method name is the street address, class name is the city and namespace is the state.
- Our program is not assigned to a namespace. To assign it to a name space, put the program in a namespace section inside curly brackets.
- Put the Class Program in the namespace NASA...
- Namespaces can have multiple levels such as company name, then partition the namespacde into smaller namespaces by dots (.), eg NASA.Planets.Saturn
- A Using Directive reduces typing and makes the code more readable.
- A "Using Directive" reduces constant writing out of the namespace by putthing the namespace at the top of the code page, ```using System;```
- Place as many Using Directives as needed at the top of the code page.

```cs
namespace Treehouse
{
    class Program
    {
        ...
    }
}
```

#### Formatting Output

- WriteLine method 
- String concatenation uses a plus sign (+) as the concatenation operator

```
    Console.WriteLine("You entered " + entry + " minutes");
```

- Run two command in the CLI by concatinating them with two ampersands (&&)
- The second command will run after the first command executes successfully

```mcs Program.cs && mono Program.exe```

### Perform

Execute the plan and code.

### Perfect

Improve app through refactoring, input validations, etc..

## R&D
- Does Ruby use Namespace?



------------------------------------------------------------------------------

## REVIEW





## REFERENCES

- [TreeHouse: C# Basics](https://teamtreehouse.com/library/c-basics)
- [C# Keywords](https://msdn.microsoft.com/en-us/library/x53a06bb.aspx)
- [Four Ps to Problem Solving](https://medium.com/@MatHelme/the-four-ps-of-problem-solving-6e15a39a0712)


