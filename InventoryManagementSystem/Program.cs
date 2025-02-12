using System;

public class InventoryItem
{
    public string ItemName { get; set; }
    public int ItemID { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public InventoryItem Next { get; set; }
}

public class InventoryLinkedList
{
    private InventoryItem head;

    public void AddItemAtBeginning(string itemName, int itemId, int quantity, double price)
    {
        InventoryItem newItem = new InventoryItem
        {
            ItemName = itemName,
            ItemID = itemId,
            Quantity = quantity,
            Price = price,
            Next = head
        };
        head = newItem;
    }

    public void AddItemAtEnd(string itemName, int itemId, int quantity, double price)
    {
        InventoryItem newItem = new InventoryItem
        {
            ItemName = itemName,
            ItemID = itemId,
            Quantity = quantity,
            Price = price,
            Next = null
        };

        if (head == null)
        {
            head = newItem;
            return;
        }

        InventoryItem current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newItem;
    }

    public void RemoveItemById(int itemId)
    {
        if (head == null) return;

        if (head.ItemID == itemId)
        {
            head = head.Next;
            return;
        }

        InventoryItem current = head;
        while (current.Next != null && current.Next.ItemID != itemId)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    public void UpdateItemQuantity(int itemId, int newQuantity)
    {
        InventoryItem item = SearchItemById(itemId);
        if (item != null)
        {
            item.Quantity = newQuantity;
        }
    }

    public InventoryItem SearchItemById(int itemId)
    {
        InventoryItem current = head;
        while (current != null)
        {
            if (current.ItemID == itemId)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public InventoryItem SearchItemByName(string itemName)
    {
        InventoryItem current = head;
        while (current != null)
        {
            if (current.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public double CalculateTotalInventoryValue()
    {
        double totalValue = 0;
        InventoryItem current = head;
        while (current != null)
        {
            totalValue += current.Price * current.Quantity;
            current = current.Next;
        }
        return totalValue;
    }

    public void DisplayAllItems()
    {
        InventoryItem current = head;
        while (current != null)
        {
            Console.WriteLine($"Item Name: {current.ItemName}, Item ID: {current.ItemID}, Quantity: {current.Quantity}, Price: {current.Price}");
            current = current.Next;
        }
    }

    public void SortInventoryByName(bool ascending = true)
    {
        if (head == null) return;

        bool swapped;
        do
        {
            swapped = false;
            InventoryItem current = head;
            while (current.Next != null)
            {
                if ((ascending && string.Compare(current.ItemName, current.Next.ItemName, StringComparison.OrdinalIgnoreCase) > 0) ||
                    (!ascending && string.Compare(current.ItemName, current.Next.ItemName, StringComparison.OrdinalIgnoreCase) < 0))
                {
                    Swap(current, current.Next);
                    swapped = true;
                }
                current = current.Next;
            }
        } while (swapped);
    }

    public void SortInventoryByPrice(bool ascending = true)
    {
        if (head == null) return;

        bool swapped;
        do
        {
            swapped = false;
            InventoryItem current = head;
            while (current.Next != null)
            {
                if ((ascending && current.Price > current.Next.Price) ||
                    (!ascending && current.Price < current.Next.Price))
                {
                    Swap(current, current.Next);
                    swapped = true;
                }
                current = current.Next;
            }
        } while (swapped);
    }

    private void Swap(InventoryItem a, InventoryItem b)
    {
        string tempName = a.ItemName;
        int tempId = a.ItemID;
        int tempQuantity = a.Quantity;
        double tempPrice = a.Price;

        a.ItemName = b.ItemName;
        a.ItemID = b.ItemID;
        a.Quantity = b.Quantity;
        a.Price = b.Price;

        b.ItemName = tempName;
        b.ItemID = tempId;
        b.Quantity = tempQuantity;
        b.Price = tempPrice;
    }
}

class Program
{
    static void Main()
    {
        InventoryLinkedList inventory = new InventoryLinkedList();
        inventory.AddItemAtBeginning("Laptop", 101, 10, 999.99);
        inventory.AddItemAtEnd("Mouse", 102, 50, 19.99);
        inventory.AddItemAtEnd("Keyboard", 103, 30, 49.99);

        Console.WriteLine("All Inventory Items:");
        inventory.DisplayAllItems();

        Console.WriteLine("\nTotal Inventory Value: $" + inventory.CalculateTotalInventoryValue());

        Console.WriteLine("\nSorting Inventory by Name (Ascending):");
        inventory.SortInventoryByName();
        inventory.DisplayAllItems();

        Console.WriteLine("\nSorting Inventory by Price (Descending):");
        inventory.SortInventoryByPrice(false);
        inventory.DisplayAllItems();

        Console.WriteLine("\nUpdating Quantity of Item ID 102 to 60");
        inventory.UpdateItemQuantity(102, 60);

        Console.WriteLine("\nAll Inventory Items after update:");
        inventory.DisplayAllItems();

        Console.WriteLine("\nRemoving Item with ID 101");
        inventory.RemoveItemById(101);

        Console.WriteLine("\nAll Inventory Items after removal:");
        inventory.DisplayAllItems();
    }
}
