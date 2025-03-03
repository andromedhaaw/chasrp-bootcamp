using System;
using System.Collections;

// Delegate declaration
delegate void ShowMessage(string message);

// Class with Event Handler
class Notification
{
    public event ShowMessage OnMessage;
    
    public void SendMessage(string message)
    {
        OnMessage?.Invoke(message);
    }
}

// Class with Operator Overloading
class Box
{
    public int Weight { get; set; }
    
    public Box(int weight)
    {
        Weight = weight;
    }

    public static Box operator +(Box a, Box b)
    {
        return new Box(a.Weight + b.Weight);
    }
    
    public override string ToString()
    {
        return $"{Weight} kg";
    }
}

// Enumerator and Iterator Example
class Fruits : IEnumerable
{
    private string[] fruitList = { "Apple", "Banana", "Orange", "Grapes" };

    public IEnumerator GetEnumerator()
    {
        foreach (var fruit in fruitList)
        {
            yield return fruit;
        }
    }
}

class Program
{
    static void Main()
    {
        // 1. Delegates & Event Handlers
        Notification notification = new Notification();
        notification.OnMessage += message => Console.WriteLine($"Notification: {message}");
        notification.SendMessage("Your order has been shipped!");

        // 2. Try-Catch Exception Handling
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]); // Out of bounds exception
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // 3. Nullable Value Type
        int? score = null;
        Console.WriteLine(score.HasValue ? score.Value.ToString() : "No score available");

        // 4. Operator Overloading
        Box box1 = new Box(5);
        Box box2 = new Box(3);
        Box totalBox = box1 + box2;
        Console.WriteLine($"Total weight: {totalBox}");

        // 5. Enumerator and Iterators
        Fruits myFruits = new Fruits();
        Console.WriteLine("Available Fruits:");
        foreach (var fruit in myFruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
