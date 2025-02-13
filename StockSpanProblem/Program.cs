using System;
using System.Collections.Generic;

public class StockSpan
{
    public static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();

        stack.Push(0);
        span[0] = 1;

        for (int i = 1; i < n; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

         
            stack.Push(i);
        }

        return span;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        
        Console.WriteLine("Stock Prices: " + string.Join(", ", prices));

        int[] span = StockSpan.CalculateSpan(prices);

        Console.WriteLine("Stock Spans: " + string.Join(", ", span));
    }
}
