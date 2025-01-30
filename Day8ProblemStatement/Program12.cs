

// 12. Write a replace method in C# that replaces a given word with another word in a sentence:
// using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        Console.WriteLine("Enter the word to replace:");
        string oldWord = Console.ReadLine();
        Console.WriteLine("Enter the new word:");
        string newWord = Console.ReadLine();

        string result = "";
        string currentWord = "";

        foreach (char c in sentence + " ") // Add space to process the last word
        {
            if (c != ' ')
            {
                currentWord += c;
            }
            else
            {
                if (currentWord == oldWord)
                    result += newWord + " ";
                else
                    result += currentWord + " ";

                currentWord = "";
            }
        }

        Console.WriteLine($"Modified Sentence: {result.Trim()}");
    }
}

