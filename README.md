# Old Phone Pad Challenge
## Introduction
This project is a solution that simulates how old phone keypads worked. On older phones, pressing a number key multiple times would cycle through letters. For example, pressing '2' would cycle between 'A', 'B', and 'C'. This program takes a sequence of key presses and converts them into a message.

As a System and Platform Engineer with expertise in managing infrastructure and OpenShift environments, I created this project to show my understanding of C# and problem-solving, even though my daily work is focused more on infrastructure than coding. I'm aiming to expand my role into DevOps, using my skills to bridge development and operations.

## Project Structure
- Program.cs: The main code that simulates the phone keypad.
- OldPhonePad.csproj: Project file for managing dependencies in C#.

## How the Code Works

## 1. Key Mapping
The program first defines a map (a **dictionary**) that connects each number on the phone keypad to the letters it represents.

```csharp
var keyMap = new Dictionary<char, string>
{
    {'2', "ABC"},
    {'3', "DEF"},
    {'4', "GHI"},
    {'5', "JKL"},
    {'6', "MNO"},
    {'7', "PQRS"},
    {'8', "TUV"},
    {'9', "WXYZ"}
};
