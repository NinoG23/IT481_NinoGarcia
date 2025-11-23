using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Dressing Room Simulation ===\n");

        // --- Get manual input from the user ---
        Console.Write("Enter number of dressing rooms: ");
        int rooms = int.Parse(Console.ReadLine());

        Console.Write("Enter number of customers: ");
        int customers = int.Parse(Console.ReadLine());

        Console.Write("Enter forced number of items (0 for random, 1–20 allowed): ");
        int forcedItems = int.Parse(Console.ReadLine());

        Console.WriteLine();

        // --- Run 3 scenarios using the user input ---
        Scenario s1 = new Scenario(rooms, customers, forcedItems);
        s1.Run("Scenario01");

        Scenario s2 = new Scenario(rooms + 1, customers + 5, forcedItems);
        s2.Run("Scenario02");

        Scenario s3 = new Scenario(rooms - 1 > 0 ? rooms - 1 : 1, (int)(customers * 1.5), forcedItems);
        s3.Run("Scenario03");

        Console.WriteLine("Simulation complete.");
    }
}
