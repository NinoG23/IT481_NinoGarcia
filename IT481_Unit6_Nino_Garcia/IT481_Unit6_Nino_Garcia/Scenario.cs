using System;
using System.Collections.Generic;

public class Scenario
{
    private List<Customer> customers = new List<Customer>();
    private DressingRooms rooms;
    private int customerCount;

    public Scenario(int numRooms, int numCustomers, int forcedItems)
    {
        rooms = new DressingRooms(numRooms);
        customerCount = numCustomers;

        for (int i = 0; i < numCustomers; i++)
            customers.Add(new Customer(rooms, forcedItems));
    }

    public void Run(string name)
    {
        Console.WriteLine($"--- Running {name} ---");

        DateTime start = DateTime.Now;

        foreach (Customer c in customers)
            c.Start();

        foreach (Customer c in customers)
            c.Join();

        DateTime end = DateTime.Now;
        TimeSpan elapsed = end - start;

        double avgItems = 0;
        double avgUse = 0;
        double avgWait = 0;

        foreach (var c in customers)
        {
            avgItems += c.ItemsTriedOn;
            avgUse += c.UsageTime.TotalSeconds;
            avgWait += c.WaitingTime.TotalSeconds;
        }

        avgItems /= customerCount;
        avgUse /= customerCount;
        avgWait /= customerCount;

        Console.WriteLine($"Total Time: {elapsed.TotalSeconds:F2} sec");
        Console.WriteLine($"Customers: {customerCount}");
        Console.WriteLine($"Average Items: {avgItems:F2}");
        Console.WriteLine($"Average Room Usage: {avgUse:F2} sec");
        Console.WriteLine($"Average Wait Time: {avgWait:F2} sec");
        Console.WriteLine();
    }
}
