// Implement a Custom Hash Map
// Problem: Design and implement a basic hash map class with operations for insertion, deletion, and retrieval.
// Hint: Use an array of linked lists to handle collisions using separate chaining.


using System;
using System.Collections.Generic;

public class HashMap<K, V>
{
    private const int InitialCapacity = 16;
    private LinkedList<KeyValuePair<K, V>>[] buckets;

    public HashMap()
    {
        buckets = new LinkedList<KeyValuePair<K, V>>[InitialCapacity];
    }

    //  calculate the hash code for a given key
    private int GetBucketIndex(K key)
    {
        int hashCode = key.GetHashCode();
        return Math.Abs(hashCode) % buckets.Length;
    }

    //  insert a key-value pair into the hash map
    public void Insert(K key, V value)
    {
        int index = GetBucketIndex(key);
        if (buckets[index] == null)
        {
            buckets[index] = new LinkedList<KeyValuePair<K, V>>();
        }

        foreach (var pair in buckets[index])
        {
            if (pair.Key.Equals(key))
            {
                throw new ArgumentException("Key already exists in the hash map.");
            }
        }

        buckets[index].AddLast(new KeyValuePair<K, V>(key, value));
    }

    //  retrieve a value by key from the hash map
    public V Retrieve(K key)
    {
        int index = GetBucketIndex(key);
        if (buckets[index] != null)
        {
            foreach (var pair in buckets[index])
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }
        }

        throw new KeyNotFoundException("Key not found in the hash map.");
    }

    //  delete a key-value pair from the hash map
    public void Delete(K key)
    {
        int index = GetBucketIndex(key);
        if (buckets[index] != null)
        {
            var node = buckets[index].First;
            while (node != null)
            {
                if (node.Value.Key.Equals(key))
                {
                    buckets[index].Remove(node);
                    return;
                }
                node = node.Next;
            }
        }

        throw new KeyNotFoundException("Key not found in the hash map.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        HashMap<string, int> hashMap = new HashMap<string, int>();

        // Insert key-value pairs
        hashMap.Insert("apple", 1);
        hashMap.Insert("banana", 2);
        hashMap.Insert("orange", 3);

        // Retrieve values
        Console.WriteLine("Value for 'apple': " + hashMap.Retrieve("apple")); 
        Console.WriteLine("Value for 'banana': " + hashMap.Retrieve("banana"));

        // Delete a key-value pair
        hashMap.Delete("banana");

        // Try to retrieve a deleted key
        try
        {
            Console.WriteLine("Value for 'banana': " + hashMap.Retrieve("banana"));
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e.Message); 
        }
    }
}
