using System;

public class TextState
{
    public string Content { get; set; }
    public TextState Next { get; set; }
    public TextState Prev { get; set; }
}

public class TextEditor
{
    private TextState head;
    private TextState tail;
    private TextState current;
    private int maxHistorySize;
    private int currentSize;

    public TextEditor(int maxHistorySize)
    {
        this.maxHistorySize = maxHistorySize;
        this.currentSize = 0;
    }

    public void AddTextState(string content)
    {
        TextState newState = new TextState
        {
            Content = content,
            Prev = tail,
            Next = null
        };

        if (tail != null)
        {
            tail.Next = newState;
        }
        tail = newState;

        if (head == null)
        {
            head = newState;
        }

        current = newState;
        currentSize++;

        if (currentSize > maxHistorySize)
        {
            RemoveOldestState();
        }
    }

    private void RemoveOldestState()
    {
        if (head != null)
        {
            head = head.Next;
            if (head != null)
            {
                head.Prev = null;
            }
            currentSize--;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
        }
    }

    public void DisplayCurrentState()
    {
        if (current != null)
        {
            Console.WriteLine($"Current Text State: {current.Content}");
        }
        else
        {
            Console.WriteLine("No current text state available.");
        }
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor(10);
        editor.AddTextState("Hello");
        editor.AddTextState("Hello, World");
        editor.AddTextState("Hello, World!");

        Console.WriteLine("Displaying Current State:");
        editor.DisplayCurrentState();

        Console.WriteLine("\nPerforming Undo:");
        editor.Undo();
        editor.DisplayCurrentState();

        Console.WriteLine("\nPerforming Redo:");
        editor.Redo();
        editor.DisplayCurrentState();

        Console.WriteLine("\nAdding more states to exceed history limit:");
        for (int i = 0; i < 10; i++)
        {
            editor.AddTextState($"State {i}");
        }
        editor.DisplayCurrentState();

        Console.WriteLine("\nPerforming Undo:");
        editor.Undo();
        editor.DisplayCurrentState();
    }
}
