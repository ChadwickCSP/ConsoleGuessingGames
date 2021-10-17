# Console Guessing Games

In this project you will explore writing console applications using C#.

By the end of this project, you should be able to answer the following
questions:

* What is a Class and how does it relate to an Object?
* What is a while loop?
* What is a for each loop?
* What is a List?

## Required Software:

### .NET

.NET (pronounce dot net) is an open source developer platform, created by
Microsoft, for building many different types of applications. For this project,
you will be programming with a language called C# which is a simple, modern,
object-oriented, and type-safe programming language.

To use C#, you must first download the .NET platform for your operating system.

* Mac:
  [LINK](https://drive.google.com/file/d/1VL0sGmF5qYU8JvXGekFkGwVoTybK6qbE/view?usp=sharing)
* Windows:
  [LINK](https://drive.google.com/file/d/1uIuodO-uk_kHxBOUaIiP5_H0mIIZ-8Ch/view?usp=sharing)

### C# Plugin for VS Code

This plugin for VS Code provides syntax highlighting and debugging tools for you
to use while working on project written in C#.

Get it from the VS Code Market Place:
[LINK](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

### XML Documentation Comments Plugin

C# utilizes a very specific documentation format that is used for generating
documentation. It is a bit tricky to enter manually. This plugin helps generate
comments in the proper format.

Get it from the VS Code Market Place:
[LINK](https://marketplace.visualstudio.com/items?itemName=k--kato.docomment)

### Spell Checker Plugin

This plugin will help with spell checking your source code and Markdown files:
[LINK](https://marketplace.visualstudio.com/items?itemName=streetsidesoftware.code-spell-checker)

## Setting up the Project

### Sign up for the Project

TODO:

### Clone your repository

After you have signed up for the project, you can clone it using GitHub Desktop.


1. Click the Current Repository drop down

![Current Repo](support/current_repo.png)

2. Click `Add` > `Clone Repository`

![Step 2](support/step2.png)

3. Select the `GitHub.com` tab

![Step 3](support/step3.png)

4. Select the `console-guessing-games-XXXXXX` repository and click clone. You
   may have to click the refresh icon next to `Filter your repositores` before
   it will be displayed.

5. Open the project in `Visual Studio Code`

### Initialize the Project

TODO

### Running the Project Examples

TODO

## Milestone 1

* **E Period** - Monday, October 25th @ 11:59 PM
* **C Period** - Sunday, October 24th @ 11:59 PM

### Task List

- [ ] Watch Example Videos
- [ ] Follow Tutorial Video to Get Started
- [ ] Complete the `SimpleGuessingGame.cs` file.
- [ ] Commit and push work regularly
- [ ] Tag `milestone-1`
- [ ] Push `milestone-1`

For this milestone, you must implement a simple number guessing game. At a high
level, the guessing game works in the following way:

1. The computer generates a random number between 0 and 100. It is possible that
   0 and 100 could be the random number.
2. The player guesses the number:
3. If the guess is below 0 or above 100, the player must make another guess.
   (Repeat Step 2)
4. If the guess is incorrect, the computer tells the player that they are too
   high or too low and they must guess again. (Repeat Step 2)
5. If the guess was correct, the game ends, the player wins, and a report is
   given to the player.

For example, the output of a game might look like this:

```
Number Guessing Game:
I'm thinking of a number between 0 and 100.
Enter a guess between 0 and 100.
50
Your guess is too high.
Enter a guess between 0 and 100.
25
Your guess is too high.
Enter a guess between 0 and 100.
12
Your guess is too low.
Enter a guess between 0 and 100.
18
Your guess is too low.
Enter a guess between 0 and 100.
22
You guessed my number!
You guessed incorrectly 4 times.
Guesses: 50 25 12 18 22
```

### Flowchart

Below is a flowchart that implements the entire Guessing Game.

![Guessing Game Flowchart](support/SimpleGuessingGameFlowchart.png)


### Getting Started

**Note**: Before starting to program for this milestone, you should study the
[User Input Example](#user-input-example) and the [Random Number Generator
Example](#random-number-generator-example).

TODO: Create video of the following:

1. Start by creating a new folder inside of the `solution` directory.
2. Name this folder `SimpleGuessingGame`.
3. Create a new file called `SimpleGuessingGame.cs`.
4. Copy the template code below into the `SimpleGuessingGame.cs` file.

```csharp
namespace ConsoleGuessingGame
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains a Simple Guessing Game.
    /// </summary>
    public class SimpleGuessingGame
    {
        /// <summary>
        /// Plays a Simple Guessing game where the player must guess a number between 0 and 100.
        /// </summary>
        public static void Play()
        {
          Console.WriteLine("I'm in the Play method!");
        }
    }
}

```

5. Update your `Program.cs` file to call the `SimpleGuessingGame.Play()` method.
6. Follow the flowchart and implement the Simple Number Guessing game.

### Deliverable

To submit Milestone 1, you should complete the Number Guessing Game as described
in the provided flowchart.

When you have completed your code, committed and pushed it, you will create a
tag called `milestone-1`. If you later decide you would like to change the
commit for `milestone-1` you may create additional tags with a version number.
For example, `milestone-1-v2` or `milestone-1-v3`. For final grading, the
`milestone-1` tag with the greatest version number will be used. After creating
your tag, don't forget to push it to GitHub and verify it is available online.


## Milestone 2

* **C Period** - Tuesday, October 26th @ 11:59 PM
* **E Period** - Wednesday, October 27th @ 11:59 PM

### Task List

- [ ] Follow Tutorial Video to Get Started
- [ ] Complete GetGuess flowchart
- [ ] Write GetGuess method
- [ ] Refactor Play method to use new GetGuess.
- [ ] Complete CheckGuess flowchart
- [ ] Write CheckGuess method
- [ ] Refactor Play method to use new CheckGuess method
- [ ] Complete DisplayReport flowchart
- [ ] Write DisplayReport method
- [ ] Refactor Play method to use new DisplayReport method
- [ ] Commit and push work regularly
- [ ] Tag `milestone-2`
- [ ] Push `milestone-2`

For this Milestone, you will refactor the Number Guessing Game you wrote in
Milestone 1 by breaking it down into the following methods:

```csharp
public static void Play(int minimum, int maximum);
public static int GetGuess(int min, int max);
public static string CheckGuess(int guess, int target);
public static void DisplayReport(List<int> guesses);
```

### Getting Started

TODO: Create video of the following

There is an incomplete pencil file in the `diagrams` directory of this project.
[diagrams/SimplifiedGuessingGame.epgz](diagrams/SimplifiedGuessingGame.epgz)

This file contains a complete `Play` method and incomplete flowcharts for the
`GetGuess`, `CheckGuess`, and `DisplayReport` methods.

1. Start by completing the `GetGuess` method flowchart.
2. Create a new folder called `SimplifiedGuessingGame` inside of the `solution`
   directory.
3. Create a new file called `SimplifiedGuessingGame.cs` inside of the new
   folder.
4. Copy the contents of your `SimpleGuessingGame.cs` file from Milestone 1 into
   the new file.
5. Update the class name to be `SimplifiedGuessingGame`
6. Refactor the `Play()` method to take 2 parameters, min and max: `Play(int
   minimum, int maximum)`
7. Add a comment for each variable
8. Create a new method for `GetGuess(int min, int max)`
9. Following your flowchart, complete the `GetGuess` method.
10. Test your GetGuess method in your `Program.cs` file by calling it directly.
11. Refactor the `Play` method to use `GetGuess`

Continue to refactor your `SimplifiedGuessingGame`. When you're finished, the
`Play` method should match the following flowchart:

![Simplified Flowchart](support/SimplifiedGuessingGameFlowchart.png)

### Deliverable

To submit Milestone 2, you should complete the three incomplete flowcharts in
the provided pencil file. Additionally, you must create a new
`SimplifiedGuessingGame.cs` file that implements the flowcharts.

When you have completed your code, committed and pushed it, you will create a
tag called `milestone-2`. If you later decide you would like to change the
commit for `milestone-2` you may create additional tags with a version number.
For example, `milestone-2-v2` or `milestone-2-v3`. For final grading, the
`milestone-2` tag with the greatest version number will be used. After creating
your tag, don't forget to push it to GitHub and verify it is available online.

## Milestone 3

* **C Period** - Thursday, October 28th @ 11:59 PM
* **E Period** - Thursday, October 28th @ 11:59 PM

### Task List

- [ ] Follow Tutorial Video to Get Started
- [ ] Write GuessingGame constructor
- [ ] Refactor Play method
- [ ] Refactor GetGuess method
- [ ] Refactor CheckGuess method
- [ ] Refactor DisplayReport method
- [ ] Commit and push work regularly
- [ ] Tag `milestone-3`
- [ ] Push `milestone-3`

For this Milestone, you will refactor the Number Guessing Game you wrote in
Milestone 2 by turning it into an Object that uses member variables to store
it's data. When you are finished, you will have the following, non-static
methods:

```csharp
public void Play();
public int GetGuess();
public string CheckGuess(int guess);
public void DisplayReport();
```

### Getting Started

TODO: Create video of the following

1. Create a new folder called `GuessingGame` inside of the `solution` directory.
2. Create a new file called `GuessingGame.cs` inside of the new folder.
3. Copy the contents of `SimplifiedGuessingGame.cs` into the new file.
4. Update the class name to `GuessingGame`
5. Remove the `static` keyword from each method in `GuessingGame.cs`
6. Update each method call to use the `this` keyword.
7. Add two member variables to the `GuessingGame` class:
    * `private readonly int minimum`
    * `private readonly int maximum`
8. Create a constructor for `GuessingGame` which takes in two parameters:
    * `GuessingGame(int minimum, int maximum)` and initializes the member
      variables
    * `this.minimum = minimum`
    * `this.maximum = maximum`
9. Refactor the `GuessingGame` code to use the member variables.

To finish Milestone 3, you will need to add the following two member variables:

```csharp
private List<int> guesses;
private int randomNumber;
```

Notice that these two variables are do not have the `readonly` keyword. This is
because these variables need to be reinitialized each time the `Play()` method
is called. The `readonly` keyword ensures that the variable may only be assigned
to a single time.

### Deliverable

To submit Milestone 3, you should complete the object oriented version of the
number guessing game in your `GuessingGame.cs` file.

When you have completed your code, committed and pushed it, you will create a
tag called `milestone-3`. If you later decide you would like to change the
commit for `milestone-3` you may create additional tags with a version number.
For example, `milestone-3-v2` or `milestone-3-v3`. For final grading, the
`milestone-3` tag with the greatest version number will be used. After creating
your tag, don't forget to push it to GitHub and verify it is available online.

## Milestone 4: AP Written Response

* **C Period** - Sunday, October 31st @ 11:59 PM
* **E Period** - Sunday, October 31st @ 11:59 PM

### Task List

- [ ] Fix all previous milestones for final grading
- [ ] Complete Written Response README.md
- [ ] Commit and push work regularly
- [ ] Tag `milestone-4`
- [ ] Push `milestone-4`

In May, you will need to create and submit a project to the AP College Board as
well as a write up explaining how you meet the rubric.

For this Milestone, you will create a written response of the required format.

A template README.md file is available in the `WrittenResponse` directory of
this project. Complete each of the TODO sections.

### Deliverable

To submit Milestone 4, you should complete *ALL* TODOs from the
`WrittenResponse/README.md` file. You may may changes to any previous milestone
for full points in the Computational Thinking and Computing, Programming, and
Practice categories and resubmit with this milestone.

When you have completed your code, committed and pushed it, you will create a
tag called `milestone-3`. If you later decide you would like to change the
commit for `milestone-3` you may create additional tags with a version number.
For example, `milestone-3-v2` or `milestone-3-v3`. For final grading, the
`milestone-3` tag with the greatest version number will be used. After creating
your tag, don't forget to push it to GitHub and verify it is available online.

## Appendix A: Examples

### User Input Example

TODO: Create video showing the creation of this file.

This example shows how to print messages to the console as well as reading user
input from the console.

To run this example, update the `Program.cs` file to call the `UserInput.Run()`
method.

![User Input Example Flowchart](support/UserInputExample.png)

### Random Number Generator Example

TODO: Create video showing the creation of this file.

This example shows how to generate a list of random numbers and print them to
the console.

To run this example, update the `Program.cs` file to call the
`RandomNumerGenerator.Generate(0, 100, 10)` method. Notice that you can modify
the values that are passed to the method to change the outcome of the method.

![Random Number Generator Example
Flowchart](support/RandomNumberGeneratorExample.png)