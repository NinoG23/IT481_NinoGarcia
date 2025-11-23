class Program
{
    static void Main()
    {
        // Scenario 1: Default policy (3 rooms, random items)
        Scenario s1 = new Scenario(numRooms: 3, numCustomers: 10, forcedItems: 0);
        s1.Run("Scenario01");

        // Scenario 2: Stress test (5 rooms, 20 customers, forced 6 items each)
        Scenario s2 = new Scenario(numRooms: 5, numCustomers: 20, forcedItems: 6);
        s2.Run("Scenario02");

        // Scenario 3: Bottleneck test (2 rooms, random items)
        Scenario s3 = new Scenario(numRooms: 2, numCustomers: 15, forcedItems: 0);
        s3.Run("Scenario03");
    }
}
