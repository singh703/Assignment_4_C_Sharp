using System;

public class CustomList<T>
{
    private T[] items;
    private int count;

    public CustomList()
    {
        items = new T[10]; // Initialize with an initial capacity of 10
        count = 0; // Initialize the count of elements to 0
    }

    // Indexer declaration
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return items[index];
        }
        set
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            items[index] = value;
        }
    }

    public int Count
    {
        get { return count; }
    }

    public void Add(T item)
    {
        if (count == items.Length)
        {
            // Resize the array if it reaches its capacity
            Array.Resize(ref items, items.Length * 2);
        }

        items[count] = item;
        count++;
    }
}

class Program
{
    public static void Main()
    {
        CustomList<int> myList = new CustomList<int>();

        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        Console.WriteLine(myList[0]); // Output: 1
        Console.WriteLine(myList[1]); // Output: 2
        Console.WriteLine(myList[2]); // Output: 3

        myList[1] = 10; // Modify an element using the indexer

        Console.WriteLine(myList[1]); // Output: 10
        Console.ReadLine();
    }
}