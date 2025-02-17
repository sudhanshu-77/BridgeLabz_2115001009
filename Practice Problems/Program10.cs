// Linear Search Problem 2: Search for a Specific Word in a List of Sentences
// Problem: You are given an array of sentences. Write a program that performs Linear Search to find the first sentence containing a specific word.


using System;

class Program10
{
    static int FindSentenceWithWord(string[] sentences, string word)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                return i;
            }
        }
        return -1; // Return -1 if the word is not found
    }

    static void Main()
    {
        string[] sentences = { "The quick brown fox", "jumps over the lazy dog", "Hello world" };
        string word = "hello";
        int index = FindSentenceWithWord(sentences, word);
        Console.WriteLine("Sentence containing the word is at index: " + index);
    }
}



