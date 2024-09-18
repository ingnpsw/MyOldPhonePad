using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static string OldPhonePad(string input)
    {
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

        StringBuilder result = new StringBuilder();
        char lastKey = '\0';
        int keyPressCount = 0;
        string currentChar = "";

        foreach (char ch in input)
        {
            if (ch == '#') {
                break;
            }

            if (ch == '*')
            {
                if (!string.IsNullOrEmpty(currentChar)) {
                    currentChar = "";
                }
                else if (result.Length > 0)
                {
                    result.Length--;
                }
                lastKey = '\0';
                keyPressCount = 0;
            }
            else if (ch == ' ')
            {
                if (!string.IsNullOrEmpty(currentChar))
                {
                    result.Append(currentChar);
                    currentChar = "";
                }
                lastKey = '\0';
                keyPressCount = 0;
            }
            else if (keyMap.ContainsKey(ch))
            {
                if (ch == lastKey)
                {
                    keyPressCount++;
                }
                else
                {
                    if (!string.IsNullOrEmpty(currentChar))
                    {
                        result.Append(currentChar);
                    }
                    lastKey = ch;
                    keyPressCount = 1;
                }

                string letters = keyMap[ch];
                currentChar = letters[(keyPressCount - 1) % letters.Length].ToString();
            }
        }

        if (!string.IsNullOrEmpty(currentChar))
        {
            result.Append(currentChar);
        }

        return result.ToString();
    }

    public static void Main()
    {
        //Test
        Console.WriteLine("Output: " + OldPhonePad("33#"));  // Output: E
        Console.WriteLine("Output: " + OldPhonePad("227*#"));  // Output: B
        Console.WriteLine("Output: " + OldPhonePad("4433555 555666#"));  // Output: HELLO
        Console.WriteLine("Output: " + OldPhonePad("8 88777444666*664#"));  // Output: ????
    }
}
