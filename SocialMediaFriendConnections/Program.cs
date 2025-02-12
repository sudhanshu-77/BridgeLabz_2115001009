using System;
using System.Collections.Generic;

public class User
{
    public int UserID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> FriendIDs { get; set; }
    public User Next { get; set; }

    public User()
    {
        FriendIDs = new List<int>();
    }
}

public class SocialMedia
{
    private User head;

    public void AddUser(int userId, string name, int age)
    {
        User newUser = new User
        {
            UserID = userId,
            Name = name,
            Age = age,
            Next = head
        };
        head = newUser;
    }

    public void AddFriendConnection(int userId1, int userId2)
    {
        User user1 = SearchUserById(userId1);
        User user2 = SearchUserById(userId2);

        if (user1 != null && user2 != null && !user1.FriendIDs.Contains(userId2))
        {
            user1.FriendIDs.Add(userId2);
            user2.FriendIDs.Add(userId1);
        }
    }

    public void RemoveFriendConnection(int userId1, int userId2)
    {
        User user1 = SearchUserById(userId1);
        User user2 = SearchUserById(userId2);

        if (user1 != null && user2 != null)
        {
            user1.FriendIDs.Remove(userId2);
            user2.FriendIDs.Remove(userId1);
        }
    }

    public List<int> FindMutualFriends(int userId1, int userId2)
    {
        User user1 = SearchUserById(userId1);
        User user2 = SearchUserById(userId2);

        if (user1 == null || user2 == null) return new List<int>();

        List<int> mutualFriends = new List<int>();
        foreach (int friendId in user1.FriendIDs)
        {
            if (user2.FriendIDs.Contains(friendId))
            {
                mutualFriends.Add(friendId);
            }
        }
        return mutualFriends;
    }

    public void DisplayAllFriends(int userId)
    {
        User user = SearchUserById(userId);
        if (user != null)
        {
            Console.WriteLine($"Friends of {user.Name}:");
            foreach (int friendId in user.FriendIDs)
            {
                User friend = SearchUserById(friendId);
                if (friend != null)
                {
                    Console.WriteLine($"- {friend.Name} (User ID: {friend.UserID})");
                }
            }
        }
    }

    public User SearchUserById(int userId)
    {
        User current = head;
        while (current != null)
        {
            if (current.UserID == userId)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public User SearchUserByName(string name)
    {
        User current = head;
        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public int CountFriends(int userId)
    {
        User user = SearchUserById(userId);
        return user?.FriendIDs.Count ?? 0;
    }
}

class Program
{
    static void Main()
    {
        SocialMedia socialMedia = new SocialMedia();
        socialMedia.AddUser(1, "Sudhanshu", 20);
        socialMedia.AddUser(2, "Vaibhav", 21);
        socialMedia.AddUser(3, "Shivam", 22);

        socialMedia.AddFriendConnection(1, 2);
        socialMedia.AddFriendConnection(1, 3);

        Console.WriteLine("Displaying all friends of Sudhanshu:");
        socialMedia.DisplayAllFriends(1);

        Console.WriteLine("\nFinding mutual friends between Sudhanshu and Vaibhav:");
        List<int> mutualFriends = socialMedia.FindMutualFriends(1, 2);
        foreach (int friendId in mutualFriends)
        {
            User friend = socialMedia.SearchUserById(friendId);
            if (friend != null)
            {
                Console.WriteLine($"- {friend.Name} (User ID: {friend.UserID})");
            }
        }

        Console.WriteLine("\nRemoving friend connection between Sudhanshu and Vaibhav.");
        socialMedia.RemoveFriendConnection(1, 2);

        Console.WriteLine("\nDisplaying all friends of Sudhanshu after removal:");
        socialMedia.DisplayAllFriends(1);

        Console.WriteLine("\nCounting friends of Shivam:");
        Console.WriteLine($"Shivam has {socialMedia.CountFriends(3)} friends.");
    }
}
