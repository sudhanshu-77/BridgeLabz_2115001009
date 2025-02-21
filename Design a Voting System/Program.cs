// Design a Voting System
// Dictionary<string, int> to store votes.
// SortedDictionary to display results in order.
// LinkedHashMap to maintain the order of votes.
using System;
using System.Collections.Generic;

class VotingSystem
{
    private Dictionary<string, int> votes = new Dictionary<string, int>();
    private LinkedList<string> voteOrder = new LinkedList<string>();

    public void CastVote(string candidate)
    {
        if (!votes.ContainsKey(candidate))
        {
            votes[candidate] = 0;
        }
        votes[candidate]++;
        voteOrder.AddLast(candidate);
    }

    public Dictionary<string, int> GetVoteCounts() => votes;

    public SortedDictionary<string, int> GetSortedResults()
    {
        return new SortedDictionary<string, int>(votes);
    }

    public IEnumerable<string> GetVoteOrder() => voteOrder;

    static void Main()
    {
        VotingSystem votingSystem = new VotingSystem();

        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Bob");
        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Charlie");
        votingSystem.CastVote("Bob");

        Console.WriteLine("Vote Counts:");
        foreach (var kvp in votingSystem.GetVoteCounts())
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        Console.WriteLine("\nSorted Results:");
        foreach (var kvp in votingSystem.GetSortedResults())
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        Console.WriteLine("\nVote Order:");
        foreach (var candidate in votingSystem.GetVoteOrder())
        {
            Console.WriteLine(candidate);
        }
    }
}



