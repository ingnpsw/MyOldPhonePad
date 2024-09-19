# Old Phone Pad Challenge
## Introduction
This project is a solution that simulates how old phone keypads worked. On older phones, pressing a number key multiple times would cycle through letters. For example, pressing `2` would cycle between `A`, `B`, and `C`. This program takes a sequence of key presses and converts them into a message.

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
```

This means:

- Pressing `2` will let you choose between `A`, `B`, or `C`.
- Pressing `3` will give you `D`, `E`, or `F`.
- And so on.

## 2. Processing the Input
The program reads each character in the input, one at a time. If it encounters certain special characters, it will take specific actions:

- `#`: Stops processing the input (acts as a "send" key).
- `*`: Acts as a backspace, removing the last letter typed.
- Space (` `): Finalizes the current letter and prepares for the next one.

## 3. Handling Repeated Key Presses
To determine which letter to use, the program counts how many times a key is pressed. For example:

- Pressing `2` once will give you `A`.
- Pressing `2` twice will give you `B`.
- Pressing it three times will give you `C`.
If the key is pressed more than three times, it wraps around to the first letter (i.e., `A`).

## Example of Logic:
```csharp
if (ch == lastKey) {
    keyPressCount++;  // Increase the count if the same key is pressed again.
} else {
    result.Append(currentChar);  // Add the previous letter to the result.
    lastKey = ch;  // Reset for the new key.
    keyPressCount = 1;
}
```
## 4. Final Output
Once the program has processed the input, it adds the final letter to the message and outputs the result.

Example Inputs and Outputs
Input: `"33#"` → Output: `E`

Input: `"227*#"` → Output: `B` (backspace removes the previous letter)

Input: `"4433555 555666#"` → Output: `HELLO`

Input: `"8 88777444666*664#"` → Output: `TOURING`
